using System;
using System.Collections.Generic;
using System.Text;
using ClaLibStd20.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;


namespace WebAppMvcFworkCore21
{
    public class IdentCtxStdFactory : IDesignTimeDbContextFactory<IdentCtxStd>
    {
        IdentCtxStd IDesignTimeDbContextFactory<IdentCtxStd>.CreateDbContext (string[] args)
        {
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(System.IO.Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();
            var optionsBuilder = new DbContextOptionsBuilder<IdentCtxStd> ();
            string connectionString;
            try { connectionString = configuration.GetConnectionString("DevelopmentConnection"); }
            catch { connectionString = configuration.GetConnectionString("DefaultConnection"); };
            optionsBuilder.UseSqlServer(connectionString, ob => ob.MigrationsAssembly("WebAppMvcFworkCore21"));
            return new IdentCtxStd(optionsBuilder.Options);
        }
    }
}
