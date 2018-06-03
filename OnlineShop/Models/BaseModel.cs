using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace OnlineShop.Models
{
    public class BaseDbModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
    }
}