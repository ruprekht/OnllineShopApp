using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Linq;
using System.Xml;

namespace OnlineShop.Helpers.Tests
{
    [TestClass()]
    public class XmlParserTests
    {
        private readonly string path = Environment.CurrentDirectory + "\\Files\\source.xml";
        private const string name = "Тарелка Banquet Rosalia (25 см)";
        XmlParser parser;
        XmlDocument xmlDoc;

        [TestInitialize]
        public void TeatUp()
        {
            parser = new XmlParser();
            xmlDoc = new XmlDocument();
            xmlDoc.Load(path);
        }

        [TestMethod()]
        public void ParseTest_ItemsCount()
        {
            var result = parser.Parse(xmlDoc);

            Assert.AreEqual(3, result.Count());
        }

        [TestMethod()]
        public void ParseTest_ItemsName()
        {
            var result = parser.Parse(xmlDoc);

            Assert.AreEqual(name, result.ToList()[0].Name);
        }
    }
}