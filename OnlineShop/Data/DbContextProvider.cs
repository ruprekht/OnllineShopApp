using OnlineShop.Data.Interfaces;
using System;

namespace OnlineShop.Data
{
    public class DbContextProvider : IDbContextProvider, IDisposable
    {
        public DbContextProvider()
        {
            Context = new EntityDbContext();
        }

        public EntityDbContext Context { get; }

        public void Dispose()
        {
            Context?.Dispose();
        }
    }
}