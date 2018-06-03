using OnlineShop.Helpers.Interfaces;
using OnlineShop.Models;
using System.Collections.Generic;
using System.Xml;

namespace OnlineShop.Helpers
{
    public class SourceGrabber : ISourceGrabber
    {
        public IEnumerable<SourceItem> GetItems(IDataParser parser, string path)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
            return parser.Parse(xmlDoc);
        }
    }
}