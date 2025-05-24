namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;

/// <summary>
/// מימוש של ממשק ICustomer לניהול לקוחות
/// </summary>
internal class CustomerImplementation : ICustomer
{
    private string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
    /// <summary>
    /// יוצר לקוח חדש
    /// </summary>
    /// <param name="item">פריט הלקוח ליצירה</param>
    /// <returns>קוד הלקוח שנוצר.</returns>
    public int Create(Customer item)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Creating customer with ID: {item.Id}");
        var isExist = DataSource.Customers.FirstOrDefault(c => c.Id == item.Id);
        if (isExist != null)
        {
            throw new dal_idExist("The customer already exists");
        }
        else
        {
            DataSource.Customers.Add(item);
        }
        LogManager.Log(projectName, funcName, $"Customer created with ID: {item.Id}");
        return item.Id;

    }

    /// <summary>
    /// קורא לקוח לפי מזהה.
    /// </summary>
    /// <param name="Id">מזהה הלקוח לקריאה.</param>
    /// <returns>הלקוח עם המזהה הנתון, או null אם לא נמצא.</returns>
    public Customer? Read(int Id)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading customer with ID: {Id}");
        Customer? customer = DataSource.Customers.FirstOrDefault(c => c.Id == Id);
        if (customer != null)
        {
            LogManager.Log(projectName, funcName, $"Customer found with ID: {Id}");
            return customer;
        }
        throw new dal_idNotFound("id not found");
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading customer with filter");
        Customer? customer = DataSource.Customers.FirstOrDefault(filter);
        if (customer != null)
        {
            LogManager.Log(projectName, funcName, $"Customer found with filter");
            return customer;
        }
        throw new dal_objcectNotFound("Not found");
    }

    /// <summary>
    /// קורא את כל הלקוחות.
    /// </summary>
    /// <returns>רשימה של כל הלקוחות.</returns>
    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading all customers");
        return filter != null ? DataSource.Customers.Where(filter).ToList() : DataSource.Customers;
    }


    /// <summary>
    /// מעדכן לקוח קיים
    /// </summary>
    /// <param name="item">פריט הלקוח לעדכון.</param>
    public void Update(Customer item)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Updating customer with ID: {item.Id}");
        Delete(item.Id);
        DataSource.Customers.Add(item);
        LogManager.Log(projectName, funcName, $"Customer updated with ID: {item.Id}");
    }

    /// <summary>
    /// מוחק לקוח לפי מזהה.
    /// </summary>
    /// <param name="id">מזהה הלקוח למחיקה.</param>
    public void Delete(int id)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        try
        {
            LogManager.Log(projectName, funcName, $"Deleting customer with ID: {id}");
            Customer c = Read(id);
            DataSource.Customers.Remove(c);
            LogManager.Log(projectName, funcName, $"Customer deleted with ID: {id}");
        }
        catch (dal_idNotFound ex)
        {
            throw new dal_idNotFound($"Failed to delete customer with ID {id}. {ex.Message}");
        }
        catch (Exception ex)
        {
            throw new dal_idNotFound($"id not found ");
        }
    }
}


