using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Microsoft.Extensions.Configuration;

namespace Domain.DataContext
{
    public class AppConfiguration
    {
        public string SQLConnectionString { get; set; }

        public AppConfiguration()
        {
            ConfigurationBuilder configBuilder = new ConfigurationBuilder();
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsetting.json");
            configBuilder.AddJsonFile(path, false);
            var root = configBuilder.Build();
            var appSetting = root.GetSection("ConnectionStrings:DefaultConnection");
            SQLConnectionString = appSetting.Value;
        }
    }
}
