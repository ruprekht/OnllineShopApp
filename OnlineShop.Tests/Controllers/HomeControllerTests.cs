using Microsoft.VisualStudio.TestTools.UnitTesting;
using OnlineShop.Tests.Mocks;
using System.Web.Mvc;

namespace OnlineShop.Controllers.Tests
{
    [TestClass()]
    public class HomeControllerTests
    {
        private MockRepo repo;

        [TestInitialize]
        public void TeatUp()
        {
            repo = new MockRepo();
        }

        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController(repo);

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void Details()
        {
            // Arrange
            HomeController controller = new HomeController(repo);

            // Act
            ViewResult result = controller.Details(1) as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }
    }
}