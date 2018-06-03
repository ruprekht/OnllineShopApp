using System.Data.Entity;

namespace OnlineShop.Data
{
    public class ShopDBInitializer : CreateDatabaseIfNotExists<EntityDbContext>
    {
    }
}