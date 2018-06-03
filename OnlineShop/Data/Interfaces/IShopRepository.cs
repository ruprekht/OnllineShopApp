using OnlineShop.Models;
using System.Collections.Generic;

namespace OnlineShop.Data.Interfaces
{
    public interface IShopRepository
    {
        IEnumerable<Item> GetSomeRandomItems(int number);
        Item GetItemByExternalId(int externalId);
        IEnumerable<Price> GetPricesByExternalId(int externalId);
        decimal GetActualPrice(int externalId);
        bool SaveAll();
    }
}
