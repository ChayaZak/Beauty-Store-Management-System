namespace DalApi;

/// <summary>
/// ממשק כללי לניהול פעולות CRUD עבור ישויות
/// </summary>
/// <typeparam name="T">סוג הישות</typeparam>
public interface ICrud<T>
{
    /// <summary>
    /// יוצר ישות חדשה
    /// </summary>
    /// <param name="item">הישות ליצירה</param>
    /// <returns>מזהה הישות שנוצרה</returns>
    int Create(T item);

    /// <summary>
    /// קורא ישות לפי מזהה
    /// </summary>
    /// <param name="Id">מזהה הישות לקריאה</param>
    /// <returns>הישות שנמצאה, או null אם לא נמצאה</returns>
    T? Read(int Id);

    /// <summary>
    /// קורא ישות לפי תנאי
    /// </summary>
    /// <param name="filter">תנאי החיפוש</param>
    /// <returns>הישות שנמצאה, או null אם לא נמצאה</returns>
    T? Read(Func<T, bool> filter);

    /// <summary>
    /// קורא את כל הישויות
    /// </summary>
    /// <param name="filter">תנאי סינון אופציונלי</param>
    /// <returns>רשימה של כל הישויות</returns>
    List<T?> ReadAll(Func<T, bool>? filter = null);

    /// <summary>
    /// מעדכן ישות קיימת
    /// </summary>
    /// <param name="item">הישות לעדכון</param>
    void Update(T item);

    /// <summary>
    /// מוחק ישות לפי מזהה
    /// </summary>
    /// <param name="id">מזהה הישות למחיקה</param>
    void Delete(int id);
}
