using BillCalculator.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator
{
    public class MenuViewModel : ObservableCollection<Product>
    {
        public SeedMenu seedMenu = new SeedMenu();
        public List<Product> BeverageFilter;
        public List<Product> AppetizerFilter;
        public List<Product> MainCourseFilter;
        public List<Product> DessertFilter;

        public MenuViewModel(SeedMenu seed)
        {
            seedMenu = seed;

            BeverageFilter = seedMenu.MenuList.Where(p => p.Category.Name == "Beverage").ToList();
            AppetizerFilter = seedMenu.MenuList.Where(p => p.Category.Name == "Appetizer").ToList();
            MainCourseFilter = seedMenu.MenuList.Where(p => p.Category.Name == "Main Course").ToList();
            DessertFilter = seedMenu.MenuList.Where(p => p.Category.Name == "Dessert").ToList();
        }
    }
}
