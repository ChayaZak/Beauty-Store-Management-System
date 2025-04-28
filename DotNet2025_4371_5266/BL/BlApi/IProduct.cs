using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface IProduct
    {
        /// <summary>
        /// יוצר מוצר חדש
        /// </summary>
        /// <param name="item">המוצר ליצירה</param>
        /// <returns>מזהה המוצר שנוצר</returns>
        int Create(BO.Product item);

        /// <summary>
        /// קורא מוצר לפי מזהה
        /// </summary>
        /// <param name="Id">מזהה המוצר לקריאה</param>
        /// <returns>המוצר שנמצאה, או null אם לא נמצא</returns>
        BO.Product? Read(int Id);

        /// <summary>
        /// קורא מוצר לפי תנאי
        /// </summary>
        /// <param name="filter">תנאי החיפוש</param>
        /// <returns>המוצר שנמצא, או null אם לא נמצא</returns>
        BO.Product? Read(Func<BO.Product, bool> filter);

        /// <summary>
        /// קורא את כל המוצרים
        /// </summary>
        /// <param name="filter">תנאי סינון אופציונלי</param>
        /// <returns>רשימה של כל המוצרים</returns>
        List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null);

        /// <summary>
        /// מעדכן מוצר קיים
        /// </summary>
        /// <param name="item">המוצר לעדכון</param>
        void Update(BO.Product item);

        /// <summary>
        /// מוחק מוצר לפי מזהה
        /// </summary>
        /// <param name="id">מזהה המוצר למחיקה</param>
        void Delete(int id);

        /// <summary>
        /// קבלת כל המבצעים שבותקף של המוצר
        /// </summary>
        /// <param name="id">קוד מוצר</param>
        /// <param name="IsExcess">האם לקוח מועדף</param>
        /// <returns></returns>
        List<BO.SaleInProduct> AllSales(int id, bool IsExcess);
    }
}
