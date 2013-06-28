using Nancy;

namespace Chat
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = x => View["Index"];
        }
    }
}