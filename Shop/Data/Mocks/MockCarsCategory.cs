using Shop.Data.Interfaces;
using Shop.Data.Models;
using System.Collections.Generic;

namespace Shop.Data.Mocks
{
    public class MockCarsCategory : ICarsCategory
    {
        public IEnumerable<Category> getCategories
        {
            get
            {
                return new List<Category> {
                    new Category { categoryName = "Электромобили", desription = "Электрические автомобили" },
                    new Category { categoryName = "Классические автомобили", desription = "Машины с двс" }
                };
            }
        }
    }
}
