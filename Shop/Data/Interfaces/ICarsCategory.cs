using Shop.Data.Models;
using System.Collections;
using System.Collections.Generic;

namespace Shop.Data.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> getCategories { get; }
    }
}
