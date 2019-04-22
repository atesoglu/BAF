using BAF.Data.EFCore.Store;
using Microsoft.EntityFrameworkCore;
using System;
using System.Diagnostics;

namespace BAF.Konsole
{

    public class DataContext : DbContext
    {
        public DbSet<DomainModel> ObjectCollection { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=BAF_Test;Persist Security Info=True;User ID=sa;Password=uBU!!e8T**4PX5Yd");
            }
        }
    }
}