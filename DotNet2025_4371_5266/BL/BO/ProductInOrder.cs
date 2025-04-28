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

        /// <summary>
        /// בנאי ריק
        /// </summary>
        public ProductInOrder()
        {
            ProductName = string.Empty;
            Sales = new List<SaleInProduct>();
        }

        /// <summary>
        /// בנאי מלא
        /// </summary>
        /// <param name="productId">מזהה מוצר</param>
        /// <param name="productName">שם המוצר</param>
        /// <param name="basePrice">מחיר מקורי</param>
        /// <param name="quantityInOrder">כמות המוצר בהזמנה</param>
        /// <param name="sales">רשימת המצבעים התואמים למוצר בהזמנה</param>
        /// <param name="finalPrice">מחיר סופי</param>
        public ProductInOrder(int productId, string productName, double basePrice, int quantityInOrder, List<SaleInProduct> sales, double finalPrice)
        {
            ProductId = productId;
            ProductName = productName;
            BasePrice = basePrice;
            QuantityInOrder = quantityInOrder;
            Sales = sales;
            FinalPrice = finalPrice;
        }

        /// <summary>
        /// בנאי חלקי
        /// </summary>
        /// <param name="productId">מזהה מוצר</param>
        /// <param name="productName">שם המוצר</param>
        /// <param name="basePrice">מחיר מקורי</param>
        /// <param name="quantityInOrder">כמות המוצר בהזמנה</param>

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
