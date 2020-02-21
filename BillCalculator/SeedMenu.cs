using BillCalculator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator
{
    public class SeedMenu : ObservableCollection<Product>
    {
        public List<Product> MenuList = new List<Product>();

        public SeedMenu()
        {
            MenuList.Add(new Product { Title = "Soda", Category = SeedCategories.Beverage, Price = 1.95 });
            MenuList.Add(new Product { Title = "Tea", Category = SeedCategories.Beverage, Price = 1.50 });
            MenuList.Add(new Product { Title = "Coffee", Category = SeedCategories.Beverage, Price = 1.25 });
            MenuList.Add(new Product { Title = "Mineral Water", Category = SeedCategories.Beverage, Price = 2.95 });
            MenuList.Add(new Product { Title = "Juice", Category = SeedCategories.Beverage, Price = 2.50 });
            MenuList.Add(new Product { Title = "Milk", Category = SeedCategories.Beverage, Price = 1.50 });

            MenuList.Add(new Product { Title = "Buffalo Wings", Category = SeedCategories.Appetizer, Price = 5.95 });
            MenuList.Add(new Product { Title = "Buffalo Fingers", Category = SeedCategories.Appetizer, Price = 6.95 });
            MenuList.Add(new Product { Title = "Potato Skins", Category = SeedCategories.Appetizer, Price = 8.95 });
            MenuList.Add(new Product { Title = "Nachos", Category = SeedCategories.Appetizer, Price = 8.95 });
            MenuList.Add(new Product { Title = "Mushroom Caps", Category = SeedCategories.Appetizer, Price = 10.95 });
            MenuList.Add(new Product { Title = "Shrimp Cocktail", Category = SeedCategories.Appetizer, Price = 12.95 });
            MenuList.Add(new Product { Title = "Chips and Salsa", Category = SeedCategories.Appetizer, Price = 6.95 });

            MenuList.Add(new Product { Title = "Seafood Alfredo", Category = SeedCategories.MainCourse, Price = 15.95 });
            MenuList.Add(new Product { Title = "Chicken Alfredo", Category = SeedCategories.MainCourse, Price = 13.95 });
            MenuList.Add(new Product { Title = "Seafood Picatta", Category = SeedCategories.MainCourse, Price = 15.95 });
            MenuList.Add(new Product { Title = "Turkey Club", Category = SeedCategories.MainCourse, Price = 11.95 });
            MenuList.Add(new Product { Title = "Labster Pie", Category = SeedCategories.MainCourse, Price = 19.95 });
            MenuList.Add(new Product { Title = "Prime Rib", Category = SeedCategories.MainCourse, Price = 20.95 });
            MenuList.Add(new Product { Title = "Shrimp Scampi", Category = SeedCategories.MainCourse, Price = 18.95 });
            MenuList.Add(new Product { Title = "Turkey Dinner", Category = SeedCategories.MainCourse, Price = 13.95 });
            MenuList.Add(new Product { Title = "Stuffed Chicken", Category = SeedCategories.MainCourse, Price = 14.95 });
            MenuList.Add(new Product { Title = "Apple Pie", Category = SeedCategories.Dessert, Price = 5.95 });
            MenuList.Add(new Product { Title = "Sundae", Category = SeedCategories.Dessert, Price = 3.95 });
            MenuList.Add(new Product { Title = "Carrot Cake", Category = SeedCategories.Dessert, Price = 5.95 });
            MenuList.Add(new Product { Title = "Mude Pie", Category = SeedCategories.Dessert, Price = 4.95 });
            MenuList.Add(new Product { Title = "Apple Crisp", Category = SeedCategories.Dessert, Price = 5.95 });

        }
    }
}
