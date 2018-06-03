using OnlineShop.Helpers;
using OnlineShop.Models;
using System.Collections.Generic;
using System.Xml;

namespace OnlineShop.Tests.Mocks
{
    class MockXmlParser : IDataParser
    {
        public IEnumerable<SourceItem> Parse(XmlDocument data)
        {
            return new List<SourceItem>
            {
                new SourceItem
                {
                    Id = 1,
                    Name = "Fisrt",
                    Price = 100
                },
                new SourceItem
                {
                    Id = 2,
                    Name = "Second",
                    Price = 200
                }
            };
        }
    }
}
