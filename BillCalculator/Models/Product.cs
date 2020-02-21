using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator.Models
{
    public class Product
    {
        public string Title { get; set; }
        public Category Category { get; set; }
        public double Price { get; set; }
    }
}
