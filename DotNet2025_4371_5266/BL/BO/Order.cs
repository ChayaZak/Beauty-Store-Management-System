using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;

namespace BO
{
    public class Order
    {
        public bool IsPreferredCustomer { get; set; }
        public List<ProductInOrder> Products { get; set; }
        public double TotalPrice { get; set; }

        public Order() 
        {
            IsPreferredCustomer = false;
            Products = new List<ProductInOrder>();
            TotalPrice = 0;
        }

        public Order(bool isPreferredCustomer)
        {
            IsPreferredCustomer = isPreferredCustomer;
            Products = new List<ProductInOrder>();
            TotalPrice = 0;
        }

        public Order(bool isPreferredCustomer, List<ProductInOrder> products, double totalPrice)
        {
            IsPreferredCustomer = isPreferredCustomer;
            Products = products;
            TotalPrice = totalPrice;
        }

        public override string? ToString() => Tools.ToStringProperty(this);


    }
}
