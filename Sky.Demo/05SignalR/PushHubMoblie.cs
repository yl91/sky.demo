using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace _05SignalR
{
    [HubName("pushHub")]
    public class PushHubMoblie:Hub
    {
        public override Task OnConnected()
        {
            var c = this.Clients;
            c.All.notice("大家注意有人来了");
            return base.OnConnected();
        }

        public override Task OnReconnected()
        {
            Console.WriteLine("有个人重连了");
            return base.OnReconnected();
        }

        public override Task OnDisconnected()
        {
            var c = this.Clients.Caller;
            this.Clients.All.notice("有人断开了 ,他是" + this.Context.ConnectionId);
            return base.OnDisconnected();
        }
    }
}