官方ChatGLM-6B仓库：https://github.com/THUDM/ChatGLM-6B

winform控件仓库：https://github.com/kwwwvagaa/NetWinformControl

基于winform编写了一个美观的ChatGLM客户端，支持流式输出，兼容官方api
![录制_2023_04_18_16_24_50_283](https://user-images.githubusercontent.com/42195561/232732815-1a33fb48-aa08-4e88-9278-d72439a3f035.gif)

因为现在官方的ChatGLM-6B还不支持api key，所以请求的地址做了加密显示，请求地址会以key.txt的形式保存到本地，如果需要加密保存，大家自行处理。

发送请求时，stream参数为1请求流式输出。
发送请求格式如下：

curl -X POST "http://127.0.0.1:8000"
-H 'Content-Type: application/json'
-d '{"prompt": "你好", "history": [], "stream":1}'

回复按照SSE流式输出格式

data:{
"response":"你好👋！我是人工智能助手 ChatGLM-6B，很高兴见到你，欢迎问我任何问题。",
"history":[["你好","你好👋！我是人工智能助手 ChatGLM-6B，很高兴见到你，欢迎问我任何问题。"]],
"status":200,
"time":"2023-03-23 21:38:40"
}
