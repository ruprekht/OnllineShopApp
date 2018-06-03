namespace OnlineShop.Data.Interfaces
{
    public interface IDbContextProvider
    {
        EntityDbContext Context { get; }
    }
}
