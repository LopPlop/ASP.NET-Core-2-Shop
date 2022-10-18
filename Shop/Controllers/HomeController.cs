using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class HomeController : Controller
    {
        private readonly IAllCars _allCars;
        public HomeController(IAllCars _carsRepository)
        {
            this._allCars = _carsRepository;
        }

        public ViewResult Index()
        {
            var homeCar = new HomeViewModel
            {
                FavCars = _allCars.getFavCars
            };
            return View(homeCar);
        }
    }
}
