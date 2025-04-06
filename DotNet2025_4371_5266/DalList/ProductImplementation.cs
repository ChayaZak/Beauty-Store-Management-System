namespace Dal;
using DO;
using DalApi;

/// <summary>
/// מימוש של ממשק IProduct לניהול מוצרים.
/// </summary>
public class ProductImplementation : IProduct
{
    /// <summary>
    /// יוצר מוצר חדש
    /// </summary>
    /// <param name="item">הוספת מוצר</param>
    /// <returns>קוד המוצר שנוצר.</returns>
    public int Create(Product item)
    {
        Product p = item with { Id = DataSource.Config.ProductCode };
        DataSource.Products.Add(p);
        return p.Id;
    }

    /// <summary>
    /// קורא מוצר לפי מזהה.
    /// </summary>
    /// <param name="Id">מזהה המוצר לקריאה.</param>
    /// <returns>המוצר עם המזהה הנתון, או null אם לא נמצא.</returns>
    public Product? Read(int Id)
    {
        foreach (Product item in DataSource.Products)
        {
            if (item.Id == Id)
                return item;
        }
        throw new Exception("id not found");
    }

    /// <summary>
    /// קורא את כל המוצרים.
    /// </summary>
    /// <returns>רשימה של כל המוצרים</returns>
    public List<Product?> ReadAll()
    {
        return DataSource.Products;
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
            throw new Exception("id not found", ex);
        }
    }
}


