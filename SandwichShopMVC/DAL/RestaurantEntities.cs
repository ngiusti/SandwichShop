using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SandwichShopMVC.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace SandwichShopMVC.DAL
{
    public class RestaurantEntities: DbContext
    {
        public RestaurantEntities() : base("RestaurantContext")
        {
        }

        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Inventory> Inventory { get; set; }
        public DbSet<Menu> Menu { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}