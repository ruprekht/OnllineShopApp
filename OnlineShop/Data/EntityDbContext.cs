using OnlineShop.Models;
using System.Data.Entity;

namespace OnlineShop.Data
{
    public class EntityDbContext : DbContext
    {
        public EntityDbContext() : base("name=EntityDbContext")
        { }

        public DbSet<Item> Items { get; set; }
        public DbSet<Price> Prices { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}