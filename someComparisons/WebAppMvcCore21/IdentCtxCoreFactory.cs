using System;
using System.Collections.Generic;
using System.Text;
using ClaLibCore21.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace WebAppMvcCore21
{
    public class IdentCtxCoreFactory : IDesignTimeDbContextFactory<IdentCtxCore>
    {
        IdentCtxCore IDesignTimeDbContextFactory<IdentCtxCore>.CreateDbContext (string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<IdentCtxCore> ();
            string connectionString;
            try { connectionString = configuration.GetConnectionString("DevelopmentConnection"); }
            catch { connectionString = configuration.GetConnectionString("DefaultConnection"); };
            optionsBuilder.UseSqlServer(connectionString, ob => ob.MigrationsAssembly("WebAppMvcCore21"));
            return new IdentCtxCore(optionsBuilder.Options);
        }
    }
}
