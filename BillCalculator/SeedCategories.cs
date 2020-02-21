using BillCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator
{
    public static class SeedCategories
    {
        public static Category Beverage = new Category { ID = 1, Name = "Beverage" };
        public static Category Appetizer = new Category { ID = 2, Name = "Appetizer" };
        public static Category MainCourse = new Category { ID = 3, Name = "Main Course" };
        public static Category Dessert = new Category { ID = 4, Name = "Dessert" };

    }
}
