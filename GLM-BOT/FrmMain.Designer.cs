namespace GLM_BOT
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.ucSamplingBot = new HZH_Controls.Controls.UCSampling();
            this.ucTextBoxExAPI = new HZH_Controls.Controls.UCTextBoxEx();
            this.label1 = new System.Windows.Forms.Label();
            this.ucBtnImgSend = new HZH_Controls.Controls.UCBtnImg();
            this.richTextBoxAnswer = new System.Windows.Forms.RichTextBox();
            this.ucBtnExt1 = new HZH_Controls.Controls.UCBtnExt();
            this.ucBtnImgMaxTokens = new HZH_Controls.Controls.UCBtnImg();
            this.ucTrackBarMaxTokens = new HZH_Controls.Controls.UCTrackBar();
            this.labelMaxTokens = new System.Windows.Forms.Label();
            this.ucBtnImgTemp = new HZH_Controls.Controls.UCBtnImg();
            this.ucTrackBarTemp = new HZH_Controls.Controls.UCTrackBar();
            this.labelTemp = new System.Windows.Forms.Label();
            this.ucBtnImgTopp = new HZH_Controls.Controls.UCBtnImg();
            this.labelTopp = new System.Windows.Forms.Label();
            this.ucTrackBarTopp = new HZH_Controls.Controls.UCTrackBar();
            this.ucBtnImgClear = new HZH_Controls.Controls.UCBtnImg();
            this.richTextBoxQuestion = new System.Windows.Forms.RichTextBox();
            this.ucBtnExt2 = new HZH_Controls.Controls.UCBtnExt();
            this.label2 = new System.Windows.Forms.Label();
            this.ucSwitchStream = new HZH_Controls.Controls.UCSwitch();
            this.SuspendLayout();
            // 
            // ucSamplingBot
            // 
            this.ucSamplingBot.Alpha = 50;
            this.ucSamplingBot.ColorThreshold = 10;
            this.ucSamplingBot.Location = new System.Drawing.Point(248, 6);
            this.ucSamplingBot.Name = "ucSamplingBot";
            this.ucSamplingBot.SamplingImag = global::GLM_BOT.Properties.Resources.机器人;
            this.ucSamplingBot.Size = new System.Drawing.Size(43, 43);
            this.ucSamplingBot.TabIndex = 55;
            this.ucSamplingBot.Transparent = null;
            // 
            // ucTextBoxExAPI
            // 
            this.ucTextBoxExAPI.BackColor = System.Drawing.Color.Transparent;
            this.ucTextBoxExAPI.ConerRadius = 10;
            this.ucTextBoxExAPI.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ucTextBoxExAPI.DecLength = 2;
            this.ucTextBoxExAPI.FillColor = System.Drawing.Color.Empty;
            this.ucTextBoxExAPI.FocusBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTextBoxExAPI.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucTextBoxExAPI.InputText = "";
            this.ucTextBoxExAPI.InputType = HZH_Controls.TextInputType.NotControl;
            this.ucTextBoxExAPI.IsFocusColor = true;
            this.ucTextBoxExAPI.IsRadius = true;
            this.ucTextBoxExAPI.IsShowClearBtn = true;
            this.ucTextBoxExAPI.IsShowKeyboard = false;
            this.ucTextBoxExAPI.IsShowRect = true;
            this.ucTextBoxExAPI.IsShowSearchBtn = false;
            this.ucTextBoxExAPI.KeyBoardType = HZH_Controls.Controls.KeyBoardType.UCKeyBorderAll_EN;
            this.ucTextBoxExAPI.Location = new System.Drawing.Point(293, 67);
            this.ucTextBoxExAPI.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucTextBoxExAPI.MaxValue = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.ucTextBoxExAPI.MinValue = new decimal(new int[] {
            1000000,
            0,
            0,
            -2147483648});
            this.ucTextBoxExAPI.Name = "ucTextBoxExAPI";
            this.ucTextBoxExAPI.Padding = new System.Windows.Forms.Padding(5);
            this.ucTextBoxExAPI.PasswordChar = '\0';
            this.ucTextBoxExAPI.PromptColor = System.Drawing.Color.Gray;
            this.ucTextBoxExAPI.PromptFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucTextBoxExAPI.PromptText = "";
            this.ucTextBoxExAPI.RectColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.ucTextBoxExAPI.RectWidth = 1;
            this.ucTextBoxExAPI.RegexPattern = "";
            this.ucTextBoxExAPI.Size = new System.Drawing.Size(324, 30);
            this.ucTextBoxExAPI.TabIndex = 56;
            this.ucTextBoxExAPI.Leave += new System.EventHandler(this.ucTextBoxExAPI_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(224, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 44;
            this.label1.Text = "API地址";
            // 
            // ucBtnImgSend
            // 
            this.ucBtnImgSend.BackColor = System.Drawing.Color.White;
            this.ucBtnImgSend.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImgSend.BtnFont = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgSend.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.ucBtnImgSend.BtnText = "提问";
            this.ucBtnImgSend.ConerRadius = 10;
            this.ucBtnImgSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImgSend.EnabledMouseEffect = false;
            this.ucBtnImgSend.FillColor = System.Drawing.Color.White;
            this.ucBtnImgSend.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgSend.ForeColor = System.Drawing.Color.Gray;
            this.ucBtnImgSend.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgSend.Image")));
            this.ucBtnImgSend.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgSend.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgSend.ImageFontIcons")));
            this.ucBtnImgSend.IsRadius = true;
            this.ucBtnImgSend.IsShowRect = true;
            this.ucBtnImgSend.IsShowTips = false;
            this.ucBtnImgSend.Location = new System.Drawing.Point(541, 132);
            this.ucBtnImgSend.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgSend.Name = "ucBtnImgSend";
            this.ucBtnImgSend.RectColor = System.Drawing.Color.Red;
            this.ucBtnImgSend.RectWidth = 1;
            this.ucBtnImgSend.Size = new System.Drawing.Size(80, 42);
            this.ucBtnImgSend.TabIndex = 58;
            this.ucBtnImgSend.TabStop = false;
            this.ucBtnImgSend.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgSend.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgSend.TipsText = "";
            this.ucBtnImgSend.BtnClick += new System.EventHandler(this.ucBtnImgSend_BtnClick);
            // 
            // richTextBoxAnswer
            // 
            this.richTextBoxAnswer.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxAnswer.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.richTextBoxAnswer.Location = new System.Drawing.Point(34, 249);
            this.richTextBoxAnswer.Name = "richTextBoxAnswer";
            this.richTextBoxAnswer.ReadOnly = true;
            this.richTextBoxAnswer.Size = new System.Drawing.Size(584, 327);
            this.richTextBoxAnswer.TabIndex = 60;
            this.richTextBoxAnswer.TabStop = false;
            this.richTextBoxAnswer.Text = "";
            this.richTextBoxAnswer.TextChanged += new System.EventHandler(this.richTextBoxAnswer_TextChanged);
            // 
            // ucBtnExt1
            // 
            this.ucBtnExt1.BackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt1.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt1.BtnText = null;
            this.ucBtnExt1.ConerRadius = 20;
            this.ucBtnExt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt1.EnabledMouseEffect = false;
            this.ucBtnExt1.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnExt1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt1.IsRadius = true;
            this.ucBtnExt1.IsShowRect = true;
            this.ucBtnExt1.IsShowTips = false;
            this.ucBtnExt1.Location = new System.Drawing.Point(31, 246);
            this.ucBtnExt1.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt1.Name = "ucBtnExt1";
            this.ucBtnExt1.RectColor = System.Drawing.Color.Silver;
            this.ucBtnExt1.RectWidth = 1;
            this.ucBtnExt1.Size = new System.Drawing.Size(590, 333);
            this.ucBtnExt1.TabIndex = 61;
            this.ucBtnExt1.TabStop = false;
            this.ucBtnExt1.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt1.TipsText = "";
            // 
            // ucBtnImgMaxTokens
            // 
            this.ucBtnImgMaxTokens.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgMaxTokens.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgMaxTokens.BtnText = "Maximum length";
            this.ucBtnImgMaxTokens.ConerRadius = 5;
            this.ucBtnImgMaxTokens.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgMaxTokens.EnabledMouseEffect = false;
            this.ucBtnImgMaxTokens.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgMaxTokens.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgMaxTokens.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgMaxTokens.Image")));
            this.ucBtnImgMaxTokens.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgMaxTokens.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgMaxTokens.ImageFontIcons")));
            this.ucBtnImgMaxTokens.IsRadius = true;
            this.ucBtnImgMaxTokens.IsShowRect = true;
            this.ucBtnImgMaxTokens.IsShowTips = false;
            this.ucBtnImgMaxTokens.Location = new System.Drawing.Point(20, 68);
            this.ucBtnImgMaxTokens.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgMaxTokens.Name = "ucBtnImgMaxTokens";
            this.ucBtnImgMaxTokens.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgMaxTokens.RectWidth = 1;
            this.ucBtnImgMaxTokens.Size = new System.Drawing.Size(186, 31);
            this.ucBtnImgMaxTokens.TabIndex = 63;
            this.ucBtnImgMaxTokens.TabStop = false;
            this.ucBtnImgMaxTokens.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgMaxTokens.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgMaxTokens.TipsText = "";
            // 
            // ucTrackBarMaxTokens
            // 
            this.ucTrackBarMaxTokens.DcimalDigits = 0;
            this.ucTrackBarMaxTokens.IsShowTips = true;
            this.ucTrackBarMaxTokens.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarMaxTokens.LineWidth = 8F;
            this.ucTrackBarMaxTokens.Location = new System.Drawing.Point(25, 92);
            this.ucTrackBarMaxTokens.MaxValue = 4096F;
            this.ucTrackBarMaxTokens.MinValue = 0F;
            this.ucTrackBarMaxTokens.Name = "ucTrackBarMaxTokens";
            this.ucTrackBarMaxTokens.Size = new System.Drawing.Size(141, 30);
            this.ucTrackBarMaxTokens.TabIndex = 64;
            this.ucTrackBarMaxTokens.TipsFormat = null;
            this.ucTrackBarMaxTokens.Value = 2048F;
            this.ucTrackBarMaxTokens.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTrackBarMaxTokens.ValueChanged += new System.EventHandler(this.ucTrackBarMaxTokens_ValueChanged);
            // 
            // labelMaxTokens
            // 
            this.labelMaxTokens.AutoSize = true;
            this.labelMaxTokens.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelMaxTokens.Location = new System.Drawing.Point(166, 98);
            this.labelMaxTokens.Name = "labelMaxTokens";
            this.labelMaxTokens.Size = new System.Drawing.Size(45, 19);
            this.labelMaxTokens.TabIndex = 65;
            this.labelMaxTokens.Text = "2048";
            // 
            // ucBtnImgTemp
            // 
            this.ucBtnImgTemp.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgTemp.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTemp.BtnText = "Temperature";
            this.ucBtnImgTemp.ConerRadius = 5;
            this.ucBtnImgTemp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgTemp.EnabledMouseEffect = false;
            this.ucBtnImgTemp.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgTemp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTemp.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgTemp.Image")));
            this.ucBtnImgTemp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgTemp.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgTemp.ImageFontIcons")));
            this.ucBtnImgTemp.IsRadius = true;
            this.ucBtnImgTemp.IsShowRect = true;
            this.ucBtnImgTemp.IsShowTips = false;
            this.ucBtnImgTemp.Location = new System.Drawing.Point(22, 122);
            this.ucBtnImgTemp.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgTemp.Name = "ucBtnImgTemp";
            this.ucBtnImgTemp.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTemp.RectWidth = 1;
            this.ucBtnImgTemp.Size = new System.Drawing.Size(152, 30);
            this.ucBtnImgTemp.TabIndex = 66;
            this.ucBtnImgTemp.TabStop = false;
            this.ucBtnImgTemp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgTemp.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgTemp.TipsText = "";
            // 
            // ucTrackBarTemp
            // 
            this.ucTrackBarTemp.DcimalDigits = 1;
            this.ucTrackBarTemp.IsShowTips = true;
            this.ucTrackBarTemp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarTemp.LineWidth = 8F;
            this.ucTrackBarTemp.Location = new System.Drawing.Point(25, 149);
            this.ucTrackBarTemp.MaxValue = 1F;
            this.ucTrackBarTemp.MinValue = 0F;
            this.ucTrackBarTemp.Name = "ucTrackBarTemp";
            this.ucTrackBarTemp.Size = new System.Drawing.Size(141, 30);
            this.ucTrackBarTemp.TabIndex = 67;
            this.ucTrackBarTemp.TipsFormat = null;
            this.ucTrackBarTemp.Value = 0.9F;
            this.ucTrackBarTemp.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTrackBarTemp.ValueChanged += new System.EventHandler(this.ucTrackBarTemp_ValueChanged);
            // 
            // labelTemp
            // 
            this.labelTemp.AutoSize = true;
            this.labelTemp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTemp.Location = new System.Drawing.Point(166, 155);
            this.labelTemp.Name = "labelTemp";
            this.labelTemp.Size = new System.Drawing.Size(40, 19);
            this.labelTemp.TabIndex = 68;
            this.labelTemp.Text = "0.95";
            // 
            // ucBtnImgTopp
            // 
            this.ucBtnImgTopp.BackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.BtnBackColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgTopp.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTopp.BtnText = "Top p";
            this.ucBtnImgTopp.ConerRadius = 5;
            this.ucBtnImgTopp.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ucBtnImgTopp.EnabledMouseEffect = false;
            this.ucBtnImgTopp.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgTopp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.ucBtnImgTopp.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgTopp.Image")));
            this.ucBtnImgTopp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgTopp.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgTopp.ImageFontIcons")));
            this.ucBtnImgTopp.IsRadius = true;
            this.ucBtnImgTopp.IsShowRect = true;
            this.ucBtnImgTopp.IsShowTips = false;
            this.ucBtnImgTopp.Location = new System.Drawing.Point(24, 180);
            this.ucBtnImgTopp.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgTopp.Name = "ucBtnImgTopp";
            this.ucBtnImgTopp.RectColor = System.Drawing.Color.Transparent;
            this.ucBtnImgTopp.RectWidth = 1;
            this.ucBtnImgTopp.Size = new System.Drawing.Size(98, 30);
            this.ucBtnImgTopp.TabIndex = 69;
            this.ucBtnImgTopp.TabStop = false;
            this.ucBtnImgTopp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgTopp.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgTopp.TipsText = "";
            // 
            // labelTopp
            // 
            this.labelTopp.AutoSize = true;
            this.labelTopp.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelTopp.Location = new System.Drawing.Point(166, 211);
            this.labelTopp.Name = "labelTopp";
            this.labelTopp.Size = new System.Drawing.Size(31, 19);
            this.labelTopp.TabIndex = 71;
            this.labelTopp.Text = "0.7";
            // 
            // ucTrackBarTopp
            // 
            this.ucTrackBarTopp.DcimalDigits = 1;
            this.ucTrackBarTopp.IsShowTips = true;
            this.ucTrackBarTopp.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.ucTrackBarTopp.LineWidth = 8F;
            this.ucTrackBarTopp.Location = new System.Drawing.Point(25, 209);
            this.ucTrackBarTopp.MaxValue = 1F;
            this.ucTrackBarTopp.MinValue = 0F;
            this.ucTrackBarTopp.Name = "ucTrackBarTopp";
            this.ucTrackBarTopp.Size = new System.Drawing.Size(141, 23);
            this.ucTrackBarTopp.TabIndex = 70;
            this.ucTrackBarTopp.TipsFormat = null;
            this.ucTrackBarTopp.Value = 0.7F;
            this.ucTrackBarTopp.ValueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucTrackBarTopp.ValueChanged += new System.EventHandler(this.ucTrackBarTopp_ValueChanged);
            // 
            // ucBtnImgClear
            // 
            this.ucBtnImgClear.BackColor = System.Drawing.Color.White;
            this.ucBtnImgClear.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnImgClear.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnImgClear.BtnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(51)))));
            this.ucBtnImgClear.BtnText = "清空";
            this.ucBtnImgClear.ConerRadius = 10;
            this.ucBtnImgClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnImgClear.EnabledMouseEffect = false;
            this.ucBtnImgClear.FillColor = System.Drawing.Color.White;
            this.ucBtnImgClear.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnImgClear.ForeColor = System.Drawing.Color.Gray;
            this.ucBtnImgClear.Image = ((System.Drawing.Image)(resources.GetObject("ucBtnImgClear.Image")));
            this.ucBtnImgClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ucBtnImgClear.ImageFontIcons = ((object)(resources.GetObject("ucBtnImgClear.ImageFontIcons")));
            this.ucBtnImgClear.IsRadius = true;
            this.ucBtnImgClear.IsShowRect = true;
            this.ucBtnImgClear.IsShowTips = false;
            this.ucBtnImgClear.Location = new System.Drawing.Point(541, 209);
            this.ucBtnImgClear.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnImgClear.Name = "ucBtnImgClear";
            this.ucBtnImgClear.RectColor = System.Drawing.Color.Red;
            this.ucBtnImgClear.RectWidth = 1;
            this.ucBtnImgClear.Size = new System.Drawing.Size(79, 30);
            this.ucBtnImgClear.TabIndex = 59;
            this.ucBtnImgClear.TabStop = false;
            this.ucBtnImgClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ucBtnImgClear.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnImgClear.TipsText = "";
            this.ucBtnImgClear.BtnClick += new System.EventHandler(this.ucBtnImgClear_BtnClick);
            // 
            // richTextBoxQuestion
            // 
            this.richTextBoxQuestion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxQuestion.ImeMode = System.Windows.Forms.ImeMode.On;
            this.richTextBoxQuestion.Location = new System.Drawing.Point(231, 107);
            this.richTextBoxQuestion.Name = "richTextBoxQuestion";
            this.richTextBoxQuestion.Size = new System.Drawing.Size(293, 97);
            this.richTextBoxQuestion.TabIndex = 85;
            this.richTextBoxQuestion.Text = "";
            // 
            // ucBtnExt2
            // 
            this.ucBtnExt2.BackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnBackColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ucBtnExt2.BtnForeColor = System.Drawing.Color.White;
            this.ucBtnExt2.BtnText = null;
            this.ucBtnExt2.ConerRadius = 20;
            this.ucBtnExt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ucBtnExt2.EnabledMouseEffect = false;
            this.ucBtnExt2.FillColor = System.Drawing.Color.Transparent;
            this.ucBtnExt2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ucBtnExt2.IsRadius = true;
            this.ucBtnExt2.IsShowRect = true;
            this.ucBtnExt2.IsShowTips = false;
            this.ucBtnExt2.Location = new System.Drawing.Point(228, 104);
            this.ucBtnExt2.Margin = new System.Windows.Forms.Padding(0);
            this.ucBtnExt2.Name = "ucBtnExt2";
            this.ucBtnExt2.RectColor = System.Drawing.Color.Silver;
            this.ucBtnExt2.RectWidth = 1;
            this.ucBtnExt2.Size = new System.Drawing.Size(299, 103);
            this.ucBtnExt2.TabIndex = 86;
            this.ucBtnExt2.TabStop = false;
            this.ucBtnExt2.TipsColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.ucBtnExt2.TipsText = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(227, 220);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 19);
            this.label2.TabIndex = 87;
            this.label2.Text = "聊天记录：文字流";
            // 
            // ucSwitchStream
            // 
            this.ucSwitchStream.BackColor = System.Drawing.Color.Transparent;
            this.ucSwitchStream.Checked = true;
            this.ucSwitchStream.FalseColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.ucSwitchStream.FalseTextColr = System.Drawing.Color.White;
            this.ucSwitchStream.Location = new System.Drawing.Point(348, 218);
            this.ucSwitchStream.Name = "ucSwitchStream";
            this.ucSwitchStream.Size = new System.Drawing.Size(43, 22);
            this.ucSwitchStream.SwitchType = HZH_Controls.Controls.SwitchType.Ellipse;
            this.ucSwitchStream.TabIndex = 88;
            this.ucSwitchStream.Texts = new string[] {
        "I",
        "O"};
            this.ucSwitchStream.TrueColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(77)))), ((int)(((byte)(59)))));
            this.ucSwitchStream.TrueTextColr = System.Drawing.Color.White;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Snow;
            this.ClientSize = new System.Drawing.Size(650, 609);
            this.Controls.Add(this.ucSwitchStream);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxQuestion);
            this.Controls.Add(this.ucBtnExt2);
            this.Controls.Add(this.ucTextBoxExAPI);
            this.Controls.Add(this.ucBtnImgClear);
            this.Controls.Add(this.labelTopp);
            this.Controls.Add(this.ucTrackBarTopp);
            this.Controls.Add(this.ucBtnImgTopp);
            this.Controls.Add(this.labelTemp);
            this.Controls.Add(this.ucTrackBarTemp);
            this.Controls.Add(this.ucBtnImgTemp);
            this.Controls.Add(this.labelMaxTokens);
            this.Controls.Add(this.ucTrackBarMaxTokens);
            this.Controls.Add(this.ucBtnImgMaxTokens);
            this.Controls.Add(this.richTextBoxAnswer);
            this.Controls.Add(this.ucBtnImgSend);
            this.Controls.Add(this.ucSamplingBot);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucBtnExt1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsShowCloseBtn = true;
            this.Name = "FrmMain";
            this.RegionRadius = 40;
            this.ShowIcon = true;
            this.ShowInTaskbar = true;
            this.Text = "FrmMain";
            this.Title = "      ChatGLM";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Controls.SetChildIndex(this.ucBtnExt1, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.ucSamplingBot, 0);
            this.Controls.SetChildIndex(this.ucBtnImgSend, 0);
            this.Controls.SetChildIndex(this.richTextBoxAnswer, 0);
            this.Controls.SetChildIndex(this.ucBtnImgMaxTokens, 0);
            this.Controls.SetChildIndex(this.ucTrackBarMaxTokens, 0);
            this.Controls.SetChildIndex(this.labelMaxTokens, 0);
            this.Controls.SetChildIndex(this.ucBtnImgTemp, 0);
            this.Controls.SetChildIndex(this.ucTrackBarTemp, 0);
            this.Controls.SetChildIndex(this.labelTemp, 0);
            this.Controls.SetChildIndex(this.ucBtnImgTopp, 0);
            this.Controls.SetChildIndex(this.ucTrackBarTopp, 0);
            this.Controls.SetChildIndex(this.labelTopp, 0);
            this.Controls.SetChildIndex(this.ucBtnImgClear, 0);
            this.Controls.SetChildIndex(this.ucTextBoxExAPI, 0);
            this.Controls.SetChildIndex(this.ucBtnExt2, 0);
            this.Controls.SetChildIndex(this.richTextBoxQuestion, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.ucSwitchStream, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private HZH_Controls.Controls.UCSampling ucSamplingBot;
        private HZH_Controls.Controls.UCTextBoxEx ucTextBoxExAPI;
        private System.Windows.Forms.Label label1;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgSend;
        private System.Windows.Forms.RichTextBox richTextBoxAnswer;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt1;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgMaxTokens;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarMaxTokens;
        private System.Windows.Forms.Label labelMaxTokens;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgTemp;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarTemp;
        private System.Windows.Forms.Label labelTemp;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgTopp;
        private System.Windows.Forms.Label labelTopp;
        private HZH_Controls.Controls.UCTrackBar ucTrackBarTopp;
        private HZH_Controls.Controls.UCBtnImg ucBtnImgClear;
        private System.Windows.Forms.RichTextBox richTextBoxQuestion;
        private HZH_Controls.Controls.UCBtnExt ucBtnExt2;
        private System.Windows.Forms.Label label2;
        private HZH_Controls.Controls.UCSwitch ucSwitchStream;
    }
}

