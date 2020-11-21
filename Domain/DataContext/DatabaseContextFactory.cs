using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;

namespace Domain.DataContext
{
    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfiguration = new AppConfiguration();
            var optionBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionBuilder.UseSqlServer(appConfiguration.SQLConnectionString);
            return new DatabaseContext(optionBuilder.Options);
        }
    }
}
