using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator.Models
{
    public class OrderItem : BindableBase
    {
        public Product Product { get; set; }

        private int quantity;
        public int Quantity
        {
            get => quantity;
            set
            {
                Set(ref quantity, value);
                Total = Product.Price * quantity;
            }
        }

        private double total;
        public double Total
        {
            get => total;
            private set
            {
                Set(ref total, value);
            }
        }

    }
}
