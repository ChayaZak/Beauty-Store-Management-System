using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    /// <summary>
    /// ישות עזר לתיאור מבצע של מוצר
    /// </summary>
    public class SaleInProduct
    {
        /// <summary>
        /// קוד מבצע
        /// </summary>
        public int SaleId { get; set; }
       
        /// <summary>
        /// כמות המוצר במבצע
        /// </summary>
        public int QuantityForSale { get; set; }
       
        /// <summary>
        /// מחיר המוצר במבצע
        /// </summary>
        public double SalePrice { get; set; }

        /// <summary>
        /// האם המבצע הוא לכל הלקוחות
        /// </summary>
        public bool IsForAllCustomers { get; set; } 

        /// <summary>
        /// בנאי ריק
        /// </summary>
        public SaleInProduct() { }

        /// <summary>
        /// בנאי עם פרמטרים
        /// </summary>
        /// <param name="saleId">555</param>
        /// <param name="quantityForSale">כמות המוצר במבצע</param>
        /// <param name="salePrice">מחיר המוצר במבצע</param>
        /// <param name="isForAllCustomers">האם המצבע מיועד לכל הלקוחות</param>
        public SaleInProduct(int saleId, int quantityForSale, double salePrice, bool isForAllCustomers)
        {
            SaleId = saleId;
            QuantityForSale = quantityForSale;
            SalePrice = salePrice;
            IsForAllCustomers = isForAllCustomers;
        }

        /// <summary>
        /// הדפסה יפה של האוביקט 
        /// </summary>
        /// <returns></returns>
        public override string? ToString() => Tools.ToStringProperty(this);
    }
}
