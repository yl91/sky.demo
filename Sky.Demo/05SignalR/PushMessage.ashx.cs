using Microsoft.AspNet.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _05SignalR
{
    /// <summary>
    /// PushMessage 的摘要说明
    /// </summary>
    public class PushMessage : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string msginfo = context.Request["msginfo"];
            if (string.IsNullOrEmpty(msginfo))
            {
                context.Response.Write("false");
                context.Response.End();
            }
            else
            {
                IHubContext chat = GlobalHost.ConnectionManager.GetHubContext<PushHubMoblie>();
                chat.Clients.All.notice(msginfo);
                context.Response.Write("success");
                context.Response.End();
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}