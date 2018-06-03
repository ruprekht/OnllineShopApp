using OnlineShop.Data.Interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OnlineShop.Data
{
    public class ShopRepository : IShopRepository, IDisposable
    {
        private readonly EntityDbContext _context;

        public ShopRepository(IDbContextProvider provider)
        {
            _context = provider.Context;
        }

        public IEnumerable<Item> GetSomeRandomItems(int number)
        {
            return _context.Items.OrderBy(i => Guid.NewGuid()).Take(number).ToList();
        }

        public Item GetItemByExternalId(int externalId)
        {
            return _context.Items.Where(i => i.ExternalId == externalId).First();
        }

        public IEnumerable<Price> GetPricesByExternalId(int externalId)
        {
            return _context.Prices
                        .Where(p => p.ExternalId == externalId)
                        .OrderBy(o => o.DateTime)
                        .ToList();
        }

        public decimal GetActualPrice(int externalId)
        {
            return _context.Prices
                        .Where(p => p.ExternalId == externalId)
                        .OrderByDescending(o => o.DateTime)
                        .Select(p => p.Value)
                        .First();
        }

        public bool SaveAll()
        {
            return _context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}