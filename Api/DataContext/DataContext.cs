using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Api.DataContext
{
    public class DataContext : DbContext
    {
        public DataContext() : base("name=DataContextEntities")
        {
        }
        public DbSet<Models.Corresponsales> Corresponsales { get; set; }
        public DbSet<Models.Oficinas> Oficinas { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            Database.SetInitializer<DataContext>(null);
            base.OnModelCreating(modelBuilder);
        }
    }
}