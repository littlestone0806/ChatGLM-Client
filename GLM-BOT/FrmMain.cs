using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Security.Authentication;
using System.Security.Policy;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using HZH_Controls;
using HZH_Controls.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace GLM_BOT
{
    public partial class FrmMain : FrmWithTitle
    {
        string history = "[]";
        private string apiAddress = "";//api地址全局变量
        string result = "";//存储流式数据返回的新结果
        string result_old = "";//存储流式数据返回的旧结果
        string data = "";//存储流式数据新增的数据
        public FrmMain()
        {
            InitializeComponent();
        }
        private void FrmMain_Load(object sender, EventArgs e)
        {
            ucTextBoxExAPI.PasswordChar = '*';//APIKEY输入窗口

            //读取本地key文件
            try
            {
                string key = @"key.txt";
                StreamReader re = new StreamReader(key);
                ucTextBoxExAPI.InputText = re.ReadLine();
                re.Close();
            }
            catch { }

            //将API地址窗口输入的值赋值给全局apiAddress变量
            apiAddress = ucTextBoxExAPI.InputText;

            //初始化各窗口右键菜单
            InitRichTextBoxContextMenu(richTextBoxQuestion, false);
            InitRichTextBoxContextMenu(richTextBoxAnswer, true);

        }

        private async void GLMSend(string str)
        {
            try
            {
                string postdata =
                    "{\"prompt\": \"" + str +
                    "\", \"history\":" + history +
                    ", \"top_p\":" + ucTrackBarTopp.Value +
                    ", \"temperature\":" + ucTrackBarTemp.Value +
                    ", \"max_length\":" + ucTrackBarMaxTokens.Value + "}";
                HttpWebRequest request = HttpWebRequest.Create(ucTextBoxExAPI.InputText) as HttpWebRequest;
                request.Method = "POST";
                request.ContentType = "application/json";
                byte[] data = Encoding.UTF8.GetBytes(postdata);

                request.ContentLength = data.Length;
                using (Stream reqStream = request.GetRequestStream())
                {
                    reqStream.Write(data, 0, data.Length);
                    reqStream.Close();
                }

                HttpWebResponse resp = (HttpWebResponse)await request.GetResponseAsync().ConfigureAwait(false);
                Stream stream = resp.GetResponseStream();

                //获取响应内容
                string result = "";
                using (StreamReader reader = new StreamReader(stream, Encoding.UTF8))
                {
                    result = reader.ReadToEnd();
                }
                JObject jo = JsonConvert.DeserializeObject<JObject>(result); ;
                history = jo["history"].ToString();
                this.Invoke((EventHandler)(delegate
                {
                    richTextBoxAnswer.AppendText("ChatGLM：" + jo["response"].ToString());
                    richTextBoxAnswer.AppendText("\n---------------------------------------------------------------------------------------------\n");
                }));
            }
            catch (Exception ex)
            {
                this.Invoke((EventHandler)(delegate
                {
                    richTextBoxAnswer.AppendText("\n---------------------------------------------------------------------------------------------\n");
                }));
                MessageBox.Show("您的请求被服务器拒绝，请检查是否存在违规的请求\n" + ex.Message);
            }
        }
        private async Task GLMSendStream(string str)
        {
            string postdata =
                "{\"prompt\": \"" + str +
                "\", \"history\":" + history +
                ", \"top_p\":" + ucTrackBarTopp.Value +
                ", \"temperature\":" + ucTrackBarTemp.Value +
                ", \"max_length\":" + ucTrackBarMaxTokens.Value +
                ", \"stream\":1" + "}";
            // 创建一个 HttpClient 实例
            var httpClient = new HttpClient();

            var postData = new StringContent(postdata, Encoding.UTF8, "application/json");
            var request = new HttpRequestMessage(HttpMethod.Post, ucTextBoxExAPI.InputText) { Content = postData };

            // 发送 POST 请求
            var response = await httpClient.SendAsync(request, HttpCompletionOption.ResponseHeadersRead);

            Stream stream = await response.Content.ReadAsStreamAsync();
            var streamReader = new StreamReader(stream, Encoding.UTF8);

            // 读取数据流
            while (!streamReader.EndOfStream)
            {
                try
                {
                    result = streamReader.ReadLine();//逐行读取
                    if (result != "")
                    {
                        result = result.Replace("data:", "");//去掉SSE通信开头的data：
                        JObject jo = JsonConvert.DeserializeObject<JObject>(result); //转为json
                        result = jo["response"].ToString(); //提取response键值
                        history = jo["history"].ToString(); //提取history键值
                        if (result != result_old) //当新的结果和旧的结果不一致时，表示有新的数据接收
                        {
                            if (result.Length < result_old.Length) //当遇到表情符号时，新的结果长度小于旧结果
                            {
                                data = result;
                                data = data.Substring(result_old.Length - 3); //表情符号需要删掉最后三个乱码开始截取
                                this.Invoke((EventHandler)(delegate
                                {
                                    //将更改的结果删除，将新结果追加到界面
                                    richTextBoxAnswer.Text = richTextBoxAnswer.Text.Remove(richTextBoxAnswer.Text.Length - result_old.Length + result.Length - 2);
                                    richTextBoxAnswer.AppendText(data);
                                }));
                                await Task.Delay(5);
                            }
                            else
                            {
                                data = result;
                                data = data.Substring(result_old.Length);
                                this.Invoke((EventHandler)(delegate
                                {
                                    richTextBoxAnswer.AppendText(data);
                                }));
                                await Task.Delay(5);
                            }
                            result_old = result;
                        }
                    }
                }
                catch{  }         
            }
            result = result_old = data = ""; //每回答一次问题，清空一下结果缓存，防止下次出错
            this.Invoke((EventHandler)(delegate
            {
                richTextBoxAnswer.AppendText("\n---------------------------------------------------------------------------------------------\n");
            }));
        }

        private void ucTrackBarMaxTokens_ValueChanged(object sender, EventArgs e)
        {
            labelMaxTokens.Text = ucTrackBarMaxTokens.Value.ToString();
        }

        private void ucTrackBarTemp_ValueChanged(object sender, EventArgs e)
        {
            labelTemp.Text = ucTrackBarTemp.Value.ToString();
        }

        private void ucTrackBarTopp_ValueChanged(object sender, EventArgs e)
        {
            labelTopp.Text = ucTrackBarTopp.Value.ToString();
        }

        private async void ucBtnImgSend_BtnClick(object sender, EventArgs e)
        {
            string question = richTextBoxQuestion.Text; //获取问题框中的文字作为问题
            richTextBoxAnswer.AppendText("提问：" + question + "\n"); //将问题写入到答案框，并加上开头
            richTextBoxQuestion.Clear(); //清空问题框
            if (ucSwitchStream.Checked) //根据是否选择文字流来处理答案
            {
                await GLMSendStream(question.Replace("\n", "<br>")); //流式GLM问题函数,将\n转为<br>否则服务器会报错
            }
            else GLMSend(question.Replace("\n", "<br>")); //非流式GLM问答函数，将\n转为<br>否则服务器会报错
        }

        private void ucBtnImgClear_BtnClick(object sender, EventArgs e)
        {
            richTextBoxAnswer.Clear();
            history = "[]";
        }

        private void richTextBoxAnswer_TextChanged(object sender, EventArgs e)
        {
            richTextBoxAnswer.SelectionStart = richTextBoxAnswer.Text.Length;
            richTextBoxAnswer.SelectionLength = 0;
            richTextBoxAnswer.Focus();
        }

        private void ucTextBoxExAPI_Leave(object sender, EventArgs e)
        {
            apiAddress = ucTextBoxExAPI.InputText;
            try
            {
                string key = @"key.txt";
                StreamWriter wr = new StreamWriter(key, false, Encoding.Default);
                wr.WriteLine(apiAddress);
                wr.Flush();
                wr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("API地址更改失败，请检查是否有写入权限\n" + ex.Message);
            }
        }

        private void InitRichTextBoxContextMenu(RichTextBox textBox, bool read_only)
        {

            var contextMenu = new ContextMenu();
            //创建复制子菜单
            var copyMenuItem = new System.Windows.Forms.MenuItem("复制");
            copyMenuItem.Click += (sender, eventArgs) => textBox.Copy();
            contextMenu.MenuItems.Add(copyMenuItem);

            if (read_only == false)
            {
                //创建剪切子菜单
                var cutMenuItem = new System.Windows.Forms.MenuItem("剪切");
                cutMenuItem.Click += (sender, eventArgs) => textBox.Cut();


                //创建粘贴子菜单
                var pasteMenuItem = new System.Windows.Forms.MenuItem("粘贴");
                pasteMenuItem.Click += (sender, eventArgs) => textBox.Paste();

                //创建右键菜单并将子菜单加入到右键菜单中
                contextMenu.MenuItems.Add(cutMenuItem);
                contextMenu.MenuItems.Add(pasteMenuItem);
            }
            textBox.ContextMenu = contextMenu;
        }
    }
}
