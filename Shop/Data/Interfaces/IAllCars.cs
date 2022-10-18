using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> getAllCars { get; }
        IEnumerable<Car> getFavCars { get; }
        Car getCarById(int carId);
    }
}
