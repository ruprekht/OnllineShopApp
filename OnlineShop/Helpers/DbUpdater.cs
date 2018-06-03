using OnlineShop.Data;
using OnlineShop.Helpers.Interfaces;
using OnlineShop.Models;
using System;
using System.Linq;

namespace OnlineShop.Helpers
{
    public class DbUpdater
    {
        public void AddOrUpdateItems(EntityDbContext context, ISourceGrabber grabber, IDataParser parcer, string path)
        {
            var items = grabber.GetItems(parcer, path);
            items.ToList().ForEach(item =>
            {
                if (context.Items.Where(i => i.ExternalId == item.Id).Count() == 0)
                {
                    context.Items.Add(new Item()
                    {
                        Description = item.Description,
                        Image = item.Image,
                        Name = item.Name,
                        ExternalId = item.Id
                    });
                }

                if (context.Prices.Where(i => i.ExternalId == item.Id && i.Value == item.Price).Count() == 0)
                {
                    context.Prices.Add(new Price()
                    {
                        DateTime = DateTime.Now,
                        Value = item.Price,
                        ExternalId = item.Id
                    });
                }
            });
            context.SaveChanges();
        }
    }
}