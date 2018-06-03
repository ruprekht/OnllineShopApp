namespace OnlineShop.Models
{
    public class Item : BaseDbModel
    {
        public int ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
    }
}