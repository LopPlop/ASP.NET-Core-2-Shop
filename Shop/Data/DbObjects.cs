using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.IdentityModel.Tokens;
using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;
using System.Linq;

namespace Shop.Data
{
    public class DbObjects
    {
        private static Dictionary<string, Category> category;
        private static Dictionary<string, Car> car;

        public static void Initial(AppDBContent content)
        {
            
            if (!content.categories.Any())
            {
                content.categories.AddRange(Categories.Select(c => c.Value));
            }
            if (!content.cars.Any())
            {
                content.cars.AddRange(

                    new Car
                    {
                        name = "First Car",
                        price = 12000,
                        image = "/img/First.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = true,
                        Category = Categories["Классические автомобили"]

                    },
                    new Car
                    {
                        name = "Second Car",
                        price = 12000,
                        image = "/img/Second.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = false,
                        isAvailable = false,
                        Category = Categories["Классические автомобили"]
                    },
                    new Car
                    {
                        name = "Third Car",
                        price = 12000,
                        image = "/img/Third.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = false,
                        isAvailable = true,
                        Category = Categories["Классические автомобили"]
                    }, new Car
                    {
                        name = "Fourth car",
                        price = 12000,
                        image = "/img/Fourth.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = Categories["Классические автомобили"]
                    }
                    , new Car
                    {
                        name = "Fifth",
                        price = 12000,
                        image = "/img/Cybertruck.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = Categories["Электромобили"]
                    }
                    , new Car
                    {
                        name = "Six",
                        price = 12000,
                        image = "/img/Tesla_Model_3.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = Categories["Электромобили"]
                    }
                    , new Car
                    {
                        name = "Seventh",
                        price = 12000,
                        image = "/img/Tesla_Plaid.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = Categories["Электромобили"]
                    }
                    , new Car
                    {
                        name = "Eight",
                        price = 12000,
                        image = "/img/Audi_RS4.jpg",
                        descriptionLong = "Здесь находится описание машины",
                        descriptionShort = "Здесь находится описание машины",
                        isFavourite = true,
                        isAvailable = false,
                        Category = Categories["Классические автомобили"]
                    }

                    );
            }
            content.SaveChanges();
        }
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (category == null)
                {
                    var list = new List<Category>
                    {
                        new Category { categoryName = "Электромобили", desription = "Электрические автомобили" },
                        new Category { categoryName = "Классические автомобили", desription = "Машины с двс" }
                    };

                    category = new Dictionary<string, Category>();

                    foreach (var item in list)
                        category.Add(item.categoryName, item);
                }
                return category;
            }
            
        }
    }
}
