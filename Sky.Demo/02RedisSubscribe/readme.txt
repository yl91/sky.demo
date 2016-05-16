->运行次实例，必须先安装Redis服务
Redis安装
window下安装
下载地址:https://github.com/dmajkic/redis/downloads
 1.选择对应版本cd命令切换根目录 ，运行 redis-server.exe redis.conf
 2.这时候打开另一个cmd窗口 ，原来不要关闭 。找到对应的redis目录下运行 redis-cli.exe -h 127.0.0.1 -p 637
 3.设置键值对 set mykey abc  去除键值对 get mykey
客户端插件 ServiceStack.dll StackExchange.Redis.dll 

Redis发布订阅
->Redis 发布订阅(pub/sub)是一种消息通信模式：发送者(pub)发送消息，订阅者(sub)接收消息。
->Redis 客户端可以订阅任意数量的频道。

下图展示了频道 channel1 ， 以及订阅这个频道的三个客户端 —— client2 、 client5 和 client1 之间的关系：

当有新消息通过 PUBLISH 命令发送给频道 channel1 时， 这个消息就会被发送给订阅它的三个客户端：





