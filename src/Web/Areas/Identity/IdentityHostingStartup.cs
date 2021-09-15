using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(FarmFresh.Web.Areas.Identity.IdentityHostingStartup))]
namespace FarmFresh.Web.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}