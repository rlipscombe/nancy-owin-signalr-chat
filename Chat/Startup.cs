using Microsoft.AspNet.SignalR;
using Owin;

namespace Chat
{
    internal class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Map the hubs first, otherwise Nancy grabs them and you get a 404.
            var configuration = new HubConfiguration { EnableDetailedErrors = true };
            app.MapHubs(configuration);

            var bootstrapper = new Bootstrapper();
            app.UseNancy(bootstrapper);
        }
    }
}