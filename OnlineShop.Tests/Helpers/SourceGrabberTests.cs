using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShop.Helpers;
using OnlineShop.Helpers.Interfaces;
using OnlineShop.Tests.Mocks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop.Helpers.Tests
{
    [TestClass()]
    public class SourceGrabberTests
    {
        private readonly string path = Environment.CurrentDirectory + "\\Files\\source.xml";
        ISourceGrabber grabber;
        IDataParser parser;

        [TestInitialize]
        public void TeatUp()
        {
            grabber = new SourceGrabber();
            parser = new MockXmlParser();
        }

        [TestMethod()]
        public void GetItemsTest_ItemsCount()
        {
            var result = grabber.GetItems(parser, path);

            Assert.AreEqual(2, result.Count());
        }
        [TestMethod()]
        public void GetItemsTest_ItemsUnique()
        {
            var result = grabber.GetItems(parser, path);

            Assert.AreNotEqual(result.ToList()[0].Id, result.ToList()[1].Id);
        }
    }
}