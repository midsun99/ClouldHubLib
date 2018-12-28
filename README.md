# ClouldHubLib
云之家网页版C#库使用方法
一、添加引用命名空间
using LYDLib.CloudHub;
using LYDLib.Common;
二、声明一个客户端，并订阅相关事件
private Client I9Client = new Client();
//获取登录二维码完成
I9Client.GetLoginQrCodeComplete += this.I9Client_GetLoginQrCodeComplete;
//用户扫描完成，登录成功
I9Client.LoginComplete += I9Client_LoginComplete;
//接收到消息，目前可能存在重复获取消息的问题
I9Client.ReceiveMsg += I9Client_ReceiveMsg;
//获取最近联系人
I9Client.LoadConversation += I9Client_LoadConversation;
//异常捕获，目前功能未开发完^~^等我有经历在搞吧。
I9Client.CatchException += I9Client_CatchException;
三、启动
a、使用账号密码登录
 I9Client.Start("账号", "密码");
b、使用二维码登录
//QRForm qr = new QRForm(); 
I9Client.StartByQR();
//qr.ShowDialog();
需要自己定义窗体，传递图片过去，在GetLoginQrCodeComplete事件中获取图片e.Result
qr.SetQR(e.Result);



剩下的就自己玩了哈哈，有个简略的测试项目，大家且用且小心，小心入坑，反正哪里有坑我也不知道
