namespace Dal;
using DO;
using DalApi;

/// <summary>
/// מימוש של ממשק IProduct לניהול מוצרים.
/// </summary>
internal class ProductImplementation : IProduct
{
    /// <summary>
    /// יוצר מוצר חדש
    /// </summary>
    /// <param name="item">הוספת מוצר</param>
    /// <returns>קוד המוצר שנוצר.</returns>
    public int Create(Product item)
    {
        var isExist = DataSource.Products.FirstOrDefault(p => p.Id == item.Id);
        if (isExist != null)
        {
            throw new dal_idExist("The product already exists");
        }
        else
        {
            DataSource.Products.Add(item);
        }
        return item.Id;

    }

    /// <summary>
    /// קורא מוצר לפי מזהה.
    /// </summary>
    /// <param name="Id">מזהה המוצר לקריאה.</param>
    /// <returns>המוצר עם המזהה הנתון, או null אם לא נמצא.</returns>
    public Product? Read(int Id)
    {
        Product? product = DataSource.Products.FirstOrDefault(p => p.Id == Id);
        if (product!=null)
        {
            return product;
        }
        throw new dal_idNotFound("id not found");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        Product? product = DataSource.Products.FirstOrDefault(filter);
        if (product != null)
        {
            return product;
        }
        throw new dal_objcectNotFound("Not found");
    }

    /// <summary>
    /// קורא את כל המוצרים.
    /// </summary>
    /// <returns>רשימה של כל המוצרים</returns>
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        return filter!=null ? DataSource.Products.Where(filter).ToList() : DataSource.Products;
    }

    /// <summary>
    /// מעדכן מוצר קיים.
    /// </summary>
    /// <param name="item">פריט המוצר לעדכון.</param>
    public void Update(Product item)
    {
        Delete(item.Id);
        DataSource.Products.Add(item);
    }

    /// <summary>
    /// מוחק מוצר לפי מזהה.
    /// </summary>
    /// <param name="id">מזהה המוצר למחיקה</param>
    public void Delete(int id)
    {
        try
        {   
            Product p = Read(id);
            DataSource.Products.Remove(p);
        }
        catch (Exception ex)
        {
            throw new dal_idNotFound($"id not found {ex}");
        }
    }
}


