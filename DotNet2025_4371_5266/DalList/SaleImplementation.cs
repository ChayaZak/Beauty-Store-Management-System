namespace Dal;
using DO;
using DalApi;

/// <summary>
/// מימוש של ממשק ISale לניהול מבצעים.
/// </summary>
internal class SaleImplementation : ISale
{
    /// <summary>
    /// יוצר מבצע חדש.
    /// </summary>
    /// <param name="item">פריט המבצע ליצירה.</param>
    /// <returns>קוד המבצע שנוצר.</returns>
    public int Create(Sale item)
    {
        Sale s = item with { Code = DataSource.Config.SaleCode };
        DataSource.Sales.Add(s);
        return s.Code;
    }

    /// <summary>
    /// קורא מבצע לפי מזהה.
    /// </summary>
    /// <param name="Id">מזהה המבצע לקריאה.</param>
    /// <returns>המבצע עם המזהה הנתון, או null אם לא נמצא.</returns>
    public Sale? Read(int Id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// קורא את כל המבצעים.
    /// </summary>
    /// <returns>רשימה של כל המבצעים.</returns>
    public List<Sale?> ReadAll()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// מעדכן מבצע קיים.
    /// </summary>
    /// <param name="item">פריט המבצע לעדכון.</param>
    public void Update(Sale item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// מוחק מבצע לפי מזהה.
    /// </summary>
    /// <param name="id">מזהה המבצע למחיקה.</param>
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}


