using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data.Mocks
{
    public class MockAllCars : IAllCars
    {
        public readonly ICarsCategory carsCategory = new MockCarsCategory();

        public IEnumerable<Car> getAllCars
        {
            get {
                return new List<Car>
                {
                    new Car {
                        name = "First Car",
                        price = 12000,
                        image = "/img/First.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = true,
                        Category = carsCategory.getCategories.Last()
                    },
                    new Car {
                        name = "Second Car",
                        price = 12000,
                        image = "/img/Second.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = false,
                        isAvailable = false,
                        Category = carsCategory.getCategories.Last()
                    },
                    new Car {
                        name = "Third Car",
                        price = 12000,
                        image = "/img/Third.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = false,
                        isAvailable = true,
                        Category = carsCategory.getCategories.Last()
                    },new Car {
                        name = "Fourth car",
                        price = 12000,
                        image = "/img/Fourth.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = carsCategory.getCategories.First()
                    }
                    ,new Car {
                        name = "Fifth",
                        price = 12000,
                        image = "/img/Cybertruck.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = carsCategory.getCategories.First()
                    }
                    ,new Car {
                        name = "Six",
                        price = 12000,
                        image = "/img/Tesla_Model_3.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = carsCategory.getCategories.First()
                    }
                    ,new Car {
                        name = "Seventh",
                        price = 12000,
                        image = "/img/Tesla_Plaid.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = carsCategory.getCategories.First()
                    }
                    ,new Car {
                        name = "Eight",
                        price = 12000,
                        image = "/img/Audi_RS4.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = carsCategory.getCategories.First()
                    }
                };
            }
        }


        public IEnumerable<Car> getFavCars
        {
            get { return null; }
        }

        public Car getCarById(int carId)
        {
            return null;
        }
    }
}
