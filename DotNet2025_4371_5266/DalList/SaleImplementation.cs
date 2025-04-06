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
        var isExist = DataSource.Sales.FirstOrDefault(s => s.Code == item.Code);
        if (isExist != null)
        {
            throw new dal_idExist("The sale already exists");
        }
        else
        {
            DataSource.Sales.Add(item);
        }
        return item.Code;
    }

    /// <summary>
    /// קורא מבצע לפי מזהה.
    /// </summary>
    /// <param name="Id">מזהה המבצע לקריאה.</param>
    /// <returns>המבצע עם המזהה הנתון, או null אם לא נמצא.</returns>
    public Sale? Read(int Id)
    {
        Sale? sale = DataSource.Sales.FirstOrDefault(s => s.Code == Id);
        if (sale != null)
        {
            return sale;
        }
        throw new dal_idNotFound("id not found");
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        Sale? sale = DataSource.Sales.FirstOrDefault(filter);
        if (sale != null)
        {
            return sale;
        }
        throw new dal_objcectNotFound("Not found");
    }

    /// <summary>
    /// קורא את כל המבצעים.
    /// </summary>
    /// <returns>רשימה של כל המבצעים.</returns>
    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        return filter!=null ? DataSource.Sales.Where(filter).ToList() : DataSource.Sales;
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
            throw new dal_idNotFound($"id not found {ex}");
        }
    }
}


