using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlApi
{
    public interface ISale
    {
        /// <summary>
        /// יוצר מבצע חדש
        /// </summary>
        /// <param name="item">המבצע ליצירה</param>
        /// <returns>מזהה המבצע שנוצר</returns>
        int Create(BO.Sale item);

        /// <summary>
        /// קורא מבצע לפי מזהה
        /// </summary>
        /// <param name="Id">מזהה המבצע לקריאה</param>
        /// <returns>המבצע שנמצאה, או null אם לא נמצא</returns>
        BO.Sale? Read(int Id);

        /// <summary>
        /// קורא מבצע לפי תנאי
        /// </summary>
        /// <param name="filter">תנאי החיפוש</param>
        /// <returns>המבצע שנמצא, או null אם לא נמצא</returns>
        BO.Sale? Read(Func<BO.Sale, bool> filter);

        /// <summary>
        /// קורא את כל המבצעים
        /// </summary>
        /// <param name="filter">תנאי סינון אופציונלי</param>
        /// <returns>רשימה של כל המבצעים</returns>
        List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null);

        /// <summary>
        /// מעדכן מבצע קיים
        /// </summary>
        /// <param name="item">המבצע לעדכון</param>
        void Update(BO.Sale item);

        /// <summary>
        /// מוחק מבצע לפי מזהה
        /// </summary>
        /// <param name="id">מזהה המבצע למחיקה</param>
        void Delete(int id);

    }
}
