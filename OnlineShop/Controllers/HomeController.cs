using OnlineShop.Data.Interfaces;
using OnlineShop.Models.DataContracts;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace OnlineShop.Controllers
{
    public class HomeController : Controller
    {
        IShopRepository _repo;

        public HomeController(IShopRepository repo)
        {
            _repo = repo;
        }

        public ActionResult Index()
        {
            var items = new List<ItemDTO>();
            var dbItems = _repo.GetSomeRandomItems(10);
            foreach (var item in dbItems)
            {
                items.Add(new ItemDTO
                {
                    Id = item.Id,
                    ExternalId = item.ExternalId,
                    Description = item.Description,
                    Image = item.Image,
                    Name = item.Name,
                    Price = _repo.GetActualPrice(item.ExternalId)
                });
            }
            ViewBag.Items = items;            
            return View();
        }

        public ActionResult Details(int id)
        {
            var prices = _repo.GetPricesByExternalId(id);
            ViewBag.History = prices;
            ViewBag.Item = _repo.GetItemByExternalId(id);
            ViewBag.Price = prices.Last();
            return View();
        }
    }
}