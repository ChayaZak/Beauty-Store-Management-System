namespace Dal;
using DO;
using DalApi;

/// <summary>
/// מימוש של ממשק ICustomer לניהול לקוחות.
/// </summary>
internal class CustomerImplementation : ICustomer
{
    /// <summary>
    /// יוצר לקוח חדש.
    /// </summary>
    /// <param name="item">פריט הלקוח ליצירה.</param>
    /// <returns>קוד הלקוח שנוצר.</returns>
    public int Create(Customer item)
    {
        var isExist = DataSource.Customers.FirstOrDefault(c => c.Id == item.Id);
        if (isExist != null)
        {
            throw new Exception("The customer already exists");
        }
        else
        {
            DataSource.Customers.Add(item);
        }
        return item.Id;
        
    }

    /// <summary>
    /// קורא לקוח לפי מזהה.
    /// </summary>
    /// <param name="Id">מזהה הלקוח לקריאה.</param>
    /// <returns>הלקוח עם המזהה הנתון, או null אם לא נמצא.</returns>
    public Customer? Read(int Id)
    {
        foreach (var item in DataSource.Customers)
        {
            if (item.Id == Id)
                return item;
        }
        throw new Exception("id not found");
    }

    /// <summary>
    /// קורא את כל הלקוחות.
    /// </summary>
    /// <returns>רשימה של כל הלקוחות.</returns>
    public List<Customer?> ReadAll()
    {
        return DataSource.Customers;
    }

    /// <summary>
    /// מעדכן לקוח קיים.
    /// </summary>
    /// <param name="item">פריט הלקוח לעדכון.</param>
    public void Update(Customer item)
    {
        Delete(item.Id);
        DataSource.Customers.Add(item);
    }

    /// <summary>
    /// מוחק לקוח לפי מזהה.
    /// </summary>
    /// <param name="id">מזהה הלקוח למחיקה.</param>
    public void Delete(int id)
    {
        try
        {
            Customer c= Read(id);
            DataSource.Customers.Remove(c);
        }
        catch (Exception ex)
        {
            throw new Exception("id not found", ex);
        }   
    }
}


