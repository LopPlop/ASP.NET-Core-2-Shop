
using Microsoft.AspNetCore.Mvc;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using Shop.ViewModels;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allcars;
        private readonly ICarsCategory _carsCategory;

        public CarsController(IAllCars allCars, ICarsCategory carsCategory)
        {
            _allcars = allCars;
            _carsCategory = carsCategory;
        }
        [Route("Cars/ViewList")]
        [Route("Cars/ViewList/{category}")]
        public ViewResult ViewList(string category)
        {
            IEnumerable<Car> cars = null;
            string _curCategory = "";
            if (string.IsNullOrEmpty(category))
            {
                cars = _allcars.getAllCars.OrderBy(i => i.id);

            }
            if (string.Equals("fuel", category, System.StringComparison.OrdinalIgnoreCase))
            {
                cars = _allcars.getAllCars.Where(i => i.Category.categoryName == "Классические автомобили").OrderBy(i => i.id);
                _curCategory = "Классические автомобили";
            }
            if (string.Equals("electro", category, System.StringComparison.OrdinalIgnoreCase))
            {
                cars = _allcars.getAllCars.Where(i=> i.Category.categoryName == "Электромобили").OrderBy(i => i.id);
                _curCategory = "Электромобили";
            }

            var carObj = new CarsListViewModel
            {
                getAllCars = cars,
                currCategory = _curCategory,
            };

            if (!string.IsNullOrEmpty(category))
                ViewBag.Title = category;
            else
                ViewBag.Title = "Весь ассортимент автомобилей";

            return View(carObj);
        }
    }
}
