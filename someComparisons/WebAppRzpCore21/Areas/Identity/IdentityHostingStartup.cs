using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ClaLibCore21.Models;

[assembly: HostingStartup(typeof(WebAppRzpCore21.Areas.Identity.IdentityHostingStartup))]
namespace WebAppRzpCore21.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                string connectionString;
                try { connectionString = context.Configuration.GetConnectionString("DevelopmentConnection"); }
                catch { connectionString = context.Configuration.GetConnectionString("DefaultConnection"); };


                services.AddDbContext<IdentCtxCore>(options =>
                    options.UseSqlServer(connectionString,optionsBuilder=>optionsBuilder.MigrationsAssembly("WebAppMvcCore21")));

                services.AddDefaultIdentity<ApplicationUser>()
                    .AddEntityFrameworkStores<IdentCtxCore>();
            });
        }
    }
}
