using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System.Linq;
using System.Web.Mvc;
using Controller = Microsoft.AspNetCore.Mvc.Controller;
using ViewResult = Microsoft.AspNetCore.Mvc.ViewResult;

namespace Shop.Controllers
{
    public class ShopCartController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ShopCart _shopCart;
        public ShopCartController(IAllCars _carsRepository, ShopCart _shopCart)
        {
            this._allCars = _carsRepository;
            this._shopCart = _shopCart;
        }
        public ViewResult Index()
        {
            var _items = _shopCart.getShopItems();
            _shopCart.listShopItems = _items;

            var _obj = new ShopCartViewModel
            {
                _shopCart = _shopCart,
            };

            return View(_obj);
        }

        public RedirectToActionResult addToCart(int id)
        {
            var item = _allCars.getAllCars.FirstOrDefault(i => i.id == id);
            if(item != null)
            {
                _shopCart.AddToCart(item);
            }
            return RedirectToAction("Index");
        }
    }
}
