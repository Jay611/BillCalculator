using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BillCalculator.Models
{
    public class Order : BindableBase
    {
        public ObservableCollection<OrderItem> Orders = new ObservableCollection<OrderItem>();
        private const double taxRate = 0.13;
        private double subTotal;
        public double SubTotal {
            get => subTotal;
            private set
            {
                Set(ref subTotal, value);
            }
        }
        private double tax;
        public double Tax
        {
            get => tax;
            private set
            {
                Set(ref tax, value);
            }
        }
        private double total;
        public double Total {
            get => total;
            private set
            {
                Set(ref total, value);
            }
        }

        public void CalBill()
        {
            SubTotal = 0;
    
            foreach (var o in Orders)
                SubTotal += o.Product.Price * o.Quantity;
            Tax = SubTotal * taxRate;
            Total = SubTotal + Tax;
        }
        public void AddItemToList(OrderItem orderItem)
        {
            OrderItem tmp = Orders.FirstOrDefault(o => o.Product == orderItem.Product);
            if (tmp != null)
                tmp.Quantity += orderItem.Quantity;
            else
                Orders.Add(orderItem);
            CalBill();
        }
        public void OrderQuantityChange()
        {
            for (int i = 0; i < Orders.Count; i++)
            {
                if (Orders.ElementAt(i).Quantity == 0)
                {
                    Orders.RemoveAt(i);
                }

            }
            CalBill();
        }
    }
}
