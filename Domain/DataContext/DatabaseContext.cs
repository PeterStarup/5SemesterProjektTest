using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Domain.Entities;

namespace Domain.DataContext
{
    public class DatabaseContext: DbContext
    {
        public class OptionsBuild
        {
            public DbContextOptionsBuilder<DatabaseContext> OptionsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> DBOptions { get; set; }
            private AppConfiguration Settings { get; set; }

            public OptionsBuild()
            {
                Settings = new AppConfiguration();
                OptionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                OptionsBuilder.UseSqlServer(Settings.SQLConnectionString);
                DBOptions = OptionsBuilder.Options;
            }
        }
        public static OptionsBuild options = new OptionsBuild();

        public DatabaseContext(DbContextOptions<DatabaseContext> options): base(options) { }

        public DbSet<User> Users { get; set; }
    }
}
