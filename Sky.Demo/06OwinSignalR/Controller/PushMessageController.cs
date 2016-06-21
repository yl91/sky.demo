using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace _06OwinSignalR.Controller
{
    public class PushMessageController: ApiController
    {
        [HttpGet]
        public string SayHello(string name="zs")
        {
            return $"Hello,{name}!";
        }

        [HttpGet]
        public string Test(string msg)
        {
            if (string.IsNullOrEmpty(msg))
            {
                return "no";
            }
            IHubContext chat = GlobalHost.ConnectionManager.GetHubContext<LogHub>();
            chat.Clients.All.notice(msg);
            return "ok";
        }
    }
}
