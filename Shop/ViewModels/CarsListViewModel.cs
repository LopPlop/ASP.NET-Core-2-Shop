using Shop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop.ViewModels
{
    public class CarsListViewModel
    {
        public IEnumerable<Car> getAllCars { get; set; }
        public string currCategory { get; set; }
    }
}
