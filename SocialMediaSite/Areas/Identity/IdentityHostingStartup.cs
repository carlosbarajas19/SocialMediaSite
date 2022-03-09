using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SocialMediaSite.Data;

[assembly: HostingStartup(typeof(SocialMediaSite.Areas.Identity.IdentityHostingStartup))]
namespace SocialMediaSite.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<SocialMediaSiteContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("SocialMediaSiteContextConnection")));

                services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<SocialMediaSiteContext>();
            });
        }
    }
}