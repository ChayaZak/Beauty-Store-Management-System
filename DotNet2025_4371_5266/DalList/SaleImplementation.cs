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
        foreach (var item in DataSource.Sales)
        {
            if (item.Code==Id)
                return item;
        }
        throw new Exception("id not found");
    }

    /// <summary>
    /// קורא את כל המבצעים.
    /// </summary>
    /// <returns>רשימה של כל המבצעים.</returns>
    public List<Sale?> ReadAll()
    {
        return DataSource.Sales;
    }

    /// <summary>
    /// מעדכן מבצע קיים.
    /// </summary>
    /// <param name="item">פריט המבצע לעדכון.</param>
    public void Update(Sale item)
    {
        Delete(item.Code);
        DataSource.Sales.Add(item);
    }

    /// <summary>
    /// מוחק מבצע לפי מזהה.
    /// </summary>
    /// <param name="id">מזהה המבצע למחיקה.</param>
    public void Delete(int id)
    {
        try
        {
            Sale s= Read(id);
            DataSource.Sales.Remove(s);
        }
        catch (Exception ex)
        {
            throw new Exception("id not found", ex);
        }
    }
}


