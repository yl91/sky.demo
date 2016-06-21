using System;
using System.Threading.Tasks;
using Microsoft.Owin;
using Owin;
using System.Web.Http;
using Microsoft.AspNet.SignalR;

[assembly: OwinStartup(typeof(_06OwinSignalR.Startup))]

namespace _06OwinSignalR
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // 有关如何配置应用程序的详细信息，请访问 http://go.microsoft.com/fwlink/?LinkID=316888
            //HttpConfiguration config = new HttpConfiguration();
            ////config.Filters.Add(new ErrorAttribute());
            //WebApiConfig.Register(config);
            //app.UseWebApi(config);

            HttpConfiguration config = new HttpConfiguration();
            WebApiConfig.Register(config);
            app.UseWebApi(config);

            var hubConfig = new HubConfiguration();
            app.RunSignalR(hubConfig);
        }
    }
}
