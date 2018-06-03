using OnlineShop.Data.Interfaces;
using OnlineShop.Models;
using System;
using System.Collections.Generic;

namespace OnlineShop.Tests.Mocks
{
    class MockRepo : IShopRepository
    {
        public decimal GetActualPrice(int externalId)
        {
            return 100;
        }

        public Item GetItemByExternalId(int externalId)
        {
            return new Item
            {
                ExternalId = 1,
                Description = "Test",
                Name = "Test"
            };
        }

        public IEnumerable<Price> GetPricesByExternalId(int externalId)
        {
            return new List<Price>
            {
                new Price
                {
                    ExternalId = 1,
                    Value = 100
                },
                new Price
                {
                    ExternalId = 2,
                    Value = 200
                }
            };
        }

        public IEnumerable<Item> GetSomeRandomItems(int number)
        {
            return new List<Item>();
        }

        public bool SaveAll()
        {
            return true;
        }
    }
}
