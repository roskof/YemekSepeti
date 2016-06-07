using Core.Application;
using ProjeYemekSepeti.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjeYemekSepeti.Controllers
{
    public class HomeController : Controller
    {
        private IShopService _shopService;

        public HomeController(IShopService shopService)
        {
            _shopService = shopService;
        }

        public ActionResult Index()
        {
            HomeViewModel homeModel = new HomeViewModel();

            var shopList = _shopService.GetHomeShopList();

            homeModel.ShopList = ModelFactory.Parse(shopList);

            return View(homeModel);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}