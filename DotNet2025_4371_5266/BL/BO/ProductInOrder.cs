using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int ProductId { get; set; } 
        public string ProductName { get; set; } 
        public double? BasePrice { get; set; } 
        public int QuantityInOrder { get; set; } 
        public List<SaleInProduct> Sales { get; set; } 
        public double FinalPrice { get; set; }

    
        public ProductInOrder()
        {
            ProductName = string.Empty;
            Sales = new List<SaleInProduct>();
        }


        public ProductInOrder(int productId, string productName, double basePrice, int quantityInOrder, List<SaleInProduct> sales, double finalPrice)
        {
            ProductId = productId;
            ProductName = productName;
            BasePrice = basePrice;
            QuantityInOrder = quantityInOrder;
            Sales = sales;
            FinalPrice = finalPrice;
        }



        public ProductInOrder(int productId, string productName, double basePrice, int quantityInOrder)
        {
            ProductId = productId;
            ProductName = productName;
            BasePrice = basePrice;
            QuantityInOrder = quantityInOrder;
            Sales = new List<SaleInProduct>();
            FinalPrice = basePrice*quantityInOrder;
        }
        public override string? ToString() => Tools.ToStringProperty(this);

    }
}
