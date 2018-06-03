using System;

namespace OnlineShop.Models.DataContracts
{
    public class ItemDTO
    {
        public Guid Id { get; set; }
        public int ExternalId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public decimal Price { get; set; }
    }
}