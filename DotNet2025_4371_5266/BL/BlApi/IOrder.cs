using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IOrder
    {
        /// <summary>
        /// הוספת מוצר להזמנה
        /// </summary>
        /// <param name="order">ההזמנה</param>
        /// <param name="productId">מזהה המוצר להוספה</param>
        /// <param name="quantity">כמות</param>
        /// <returns>רשימת מבצעים רלוונטים למוצר</returns>
        List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int quantity);

        /// <summary>
        /// חישוב המחיר הסופי למוצר
        /// </summary>
        /// <param name="product">מוצר שבהזמנה</param>
        void CalcTotalPriceForProduct(BO.ProductInOrder product);   
        
        /// <summary>
        /// חישוב המחיר הסופי להזמנה
        /// </summary>
        /// <param name="order">הזמנה</param>
        void CalcTotalPrice(BO.Order order);

        /// <summary>
        /// ביצוע הזמנה
        /// </summary>
        /// <param name="order">הזמנה</param>
        void DoOrder(BO.Order order);

        /// <summary>
        /// עדכון המבצעים המתאימים למוצר בהזמנה
        /// </summary>
        /// <param name="product">מוצר בהזמנה</param>
        /// <param name="order">האם הלקוח הוא לקוח מועדף</param>
        void SearchSalesForProduct(BO.ProductInOrder product, bool isClab);
    }
}
