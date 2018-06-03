using OnlineShop.Models;
using System.Collections.Generic;
using System.Xml;

namespace OnlineShop.Helpers
{
    public class XmlParser : IDataParser
    {
        public IEnumerable<SourceItem> Parse(XmlDocument xmlDoc)
        {
            List<SourceItem> sourceItems = new List<SourceItem>();
            XmlNodeList items = xmlDoc.SelectNodes("/price/items/item");
            foreach (XmlNode item in items)
            {
                int.TryParse(item.SelectSingleNode("id").InnerText, out int shopId);
                decimal.TryParse(item.SelectSingleNode("priceRUAH").InnerText, out decimal price);

                sourceItems.Add(new SourceItem()
                {
                    Id = shopId,
                    Image = item.SelectSingleNode("image").InnerText,
                    Name = item.SelectSingleNode("name").InnerText,
                    Description = item.SelectSingleNode("description").InnerText,
                    Price = price
                });

            }
            return sourceItems;
        }
    }
}