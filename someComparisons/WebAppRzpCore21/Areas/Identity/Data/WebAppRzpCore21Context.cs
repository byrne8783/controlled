using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebAppRzpCore21.Areas.Identity.Data;

namespace WebAppRzpCore21.Models
{
    public class WebAppRzpCore21Context : IdentityDbContext<WebAppRzpCore21User>
    {
        public WebAppRzpCore21Context(DbContextOptions<WebAppRzpCore21Context> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
        }
    }
}
