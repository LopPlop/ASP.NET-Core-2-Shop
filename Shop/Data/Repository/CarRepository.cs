using Microsoft.EntityFrameworkCore;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Repository
{
    public class CarRepository : IAllCars
    {
        private readonly AppDBContent appDBContent;

        public CarRepository(AppDBContent appDBContent)
        {
            this.appDBContent = appDBContent;
        }

        public IEnumerable<Car> getAllCars => appDBContent.cars.Include(c => c.Category);

        public IEnumerable<Car> getFavCars => appDBContent.cars.Where(p => p.isFavourite).Include(c => c.Category);

        public Car getCarById(int carId) => appDBContent.cars.FirstOrDefault(p => p.id == carId);
        
    }
}
