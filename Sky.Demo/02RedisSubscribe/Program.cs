using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackExchange.Redis;

namespace _02RedisSubscribe
{
    class Program
    {
        static void Main(string[] args)
        {
            string host = "172.18.11.77:6379";
            //取连接对象
            ConnectionMultiplexer redis = ConnectionMultiplexer.Connect(host);
            //设置数据对象
            //取得订阅对象
            ISubscriber sub = redis.GetSubscriber();
            //设置订阅事件
            sub.Subscribe("c1", new Action<RedisChannel, RedisValue>(GetMessage));

            Console.Read();


            Console.ReadLine();
        }

        /// <summary>
        /// 获取消息
        /// </summary>
        /// <param name="channel"></param>
        /// <param name="message"></param>
        static void GetMessage(RedisChannel channel, RedisValue message)
        {
            Console.WriteLine(channel);
            Console.WriteLine(message);
        }
    }
}
