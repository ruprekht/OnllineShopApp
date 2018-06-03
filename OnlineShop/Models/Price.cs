using System;

namespace OnlineShop.Models
{
    public class Price : BaseDbModel
    {
        public decimal Value { get; set; }
        public DateTime DateTime { get; set; }
        public int ExternalId { get; set; }
    }
}