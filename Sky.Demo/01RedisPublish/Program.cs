using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace _01RedisPublish
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ==连接Redis==
            //string host = "172.18.11.77:6379";
            ////取连接对象
            //ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(host);
            ////取得DB对象
            //IDatabase db = redis.GetDatabase();
            ////设置数据对象
            //db.StringSet("User", "{Name:\"TOM\"}");
            ////添加数据对象
            //db.StringAppend("User", ",{Name:\"JACK\"}");

            ////取得数据对象
            //string user = db.StringGet("User");

            //Console.WriteLine(user);
            //Console.ReadKey();
            #endregion

            string host = "172.18.11.77:6379";
            //取连接对象
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(host);
            //设置数据对象
            //取得订阅对象
            ISubscriber sub = redis.GetSubscriber();
            //发布消息到channel:c1
            sub.Publish("c1", "123");
            //发送100万个字符的消息
            sub.Publish("c1", "zx".PadRight(1000000, 'x'));
            string reader = "start send";
            while (reader != "exit")
            {
                reader = Console.ReadLine();
                sub.Publish("c1", reader);
            }
            Console.ReadLine();
        }
    }
}
