using OnlineShop.Models;
using System.Collections.Generic;
using System.Xml;

namespace OnlineShop.Helpers
{
    public interface IDataParser
    {
        IEnumerable<SourceItem> Parse(XmlDocument data);
    }
}
