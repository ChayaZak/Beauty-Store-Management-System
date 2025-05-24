namespace Dal;
using DalApi;
using DO;
using System.Reflection;
using Tools;

/// <summary>
/// מימוש של ממשק IProduct לניהול מוצרים
/// </summary>
internal class ProductImplementation : IProduct
{
    string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    /// <summary>
    /// יוצר מוצר חדש
    /// </summary>
    /// <param name="item">הוספת מוצר</param>
    /// <returns>קוד המוצר שנוצר</returns>
    public int Create(Product item)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Creating product with ID: {item.Id}");
        var isExist = DataSource.Products.FirstOrDefault(p => p.Id == item.Id);
        Product p;
        if (isExist != null)
        {
            throw new dal_idExist("The product already exists");
        }
        else
        {
            p = item with { Id = DataSource.Config.ProductCode };
            DataSource.Products.Add(p);
        }
        LogManager.Log(projectName, funcName, $"Product created with ID: {item.Id}");
        return p.Id;

    }

    /// <summary>
    /// קורא מוצר לפי מזהה
    /// </summary>
    /// <param name="Id">מזהה המוצר לקריאה.</param>
    /// <returns>המוצר עם המזהה הנתון, או null אם לא נמצא.</returns>
    public Product? Read(int Id)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading product with ID: {Id}");
        Product? product = DataSource.Products.FirstOrDefault(p => p.Id == Id);
        if (product != null)
        {
            LogManager.Log(projectName, funcName, $"Product found with ID: {Id}");
            return product;
        }
        throw new dal_idNotFound("id not found");
    }

    public Product? Read(Func<Product, bool> filter)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading product with filter");
        Product? product = DataSource.Products.FirstOrDefault(filter);
        if (product != null)
        {
            LogManager.Log(projectName, funcName, $"Product found with filter");
            return product;
        }
        throw new dal_objcectNotFound("Not found");
    }

    /// <summary>
    /// קורא את כל המוצרים
    /// </summary>
    /// <returns>רשימה של כל המוצרים</returns>
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading all products");
        return filter != null ? DataSource.Products.Where(filter).ToList() : DataSource.Products;
    }

    /// <summary>
    /// מעדכן מוצר קיים
    /// </summary>
    /// <param name="item">פריט המוצר לעדכון.</param>
    public void Update(Product item)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Updating product with ID: {item.Id}");
        Delete(item.Id);
        DataSource.Products.Add(item);
        LogManager.Log(projectName, funcName, $"Product updated with ID: {item.Id}");
    }

    /// <summary>
    /// מוחק מוצר לפי מזהה.
    /// </summary>
    /// <param name="id">מזהה המוצר למחיקה</param>
    public void Delete(int id)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        try
        {
            LogManager.Log(projectName, funcName, $"Deleting product with ID: {id}");
            Product p = Read(id);
            DataSource.Products.Remove(p);
            LogManager.Log(projectName, funcName, $"Product deleted with ID: {id}");
        }
        catch (Exception ex)
        {
            throw new dal_idNotFound($"id not found {ex}");
        }
    }
}


