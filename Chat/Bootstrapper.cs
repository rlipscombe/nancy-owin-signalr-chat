using Nancy;
using Nancy.Conventions;

namespace Chat
{
    internal class Bootstrapper : DefaultNancyBootstrapper
    {
        protected override void ConfigureConventions(NancyConventions nancyConventions)
        {
            base.ConfigureConventions(nancyConventions);

            // By default, Nancy will serve static content from the 'Content' folder. We want to add 'Scripts' as well.
            nancyConventions.StaticContentsConventions.Add(StaticContentConventionBuilder.AddDirectory("Scripts", "Scripts"));
        }
    }
}