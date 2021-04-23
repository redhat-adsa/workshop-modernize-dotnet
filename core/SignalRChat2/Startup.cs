using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(SignalRChat2.Startup))]
namespace SignalRChat2
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}
