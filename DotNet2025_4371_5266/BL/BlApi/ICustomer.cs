using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ICustomer
    {
        /// <summary>
        /// יוצר לקוח חדש
        /// </summary>
        /// <param name="item">הלקוח ליצירה</param>
        /// <returns>מזהה הלקוח שנוצר</returns>
        int Create(BO.Customer item);

        /// <summary>
        /// קורא לקוח לפי מזהה
        /// </summary>
        /// <param name="Id">מזהה הלקוח לקריאה</param>
        /// <returns>הלקוח שנמצא, או null אם לא נמצא</returns>
        BO.Customer? Read(int Id);

        /// <summary>
        /// קורא לקוח לפי תנאי
        /// </summary>
        /// <param name="filter">תנאי החיפוש</param>
        /// <returns>הלקוח שנמצא, או null אם לא נמצא</returns>
        BO.Customer? Read(Func<BO.Customer, bool> filter);

        /// <summary>
        /// קורא את כל הלקוחות
        /// </summary>
        /// <param name="filter">תנאי סינון אופציונלי</param>
        /// <returns>רשימה של כל הלקוחות</returns>
        List<BO.Customer?> ReadAll(Func<BO.Customer, bool>? filter = null);

        /// <summary>
        /// מעדכן לקוח קיים
        /// </summary>
        /// <param name="item">הלקוח לעדכון</param>
        void Update(BO.Customer item);

        /// <summary>
        /// מוחק לקוח לפי מזהה
        /// </summary>
        /// <param name="id">מזהה הלקוח למחיקה</param>
        void Delete(int id);
        /// <summary>
        /// בודק האם הלקוח קיים
        /// </summary>
        /// <param name="id">מזהה הלקוח לבדיקה</param>
        /// <returns>האם הלקוח קיים</returns>
        bool IsExist(int id);
    }
}
