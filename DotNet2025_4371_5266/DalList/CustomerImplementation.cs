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
        throw new NotImplementedException();
    }

    /// <summary>
    /// קורא לקוח לפי מזהה.
    /// </summary>
    /// <param name="Id">מזהה הלקוח לקריאה.</param>
    /// <returns>הלקוח עם המזהה הנתון, או null אם לא נמצא.</returns>
    public Customer? Read(int Id)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// קורא את כל הלקוחות.
    /// </summary>
    /// <returns>רשימה של כל הלקוחות.</returns>
    public List<Customer?> ReadAll()
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// מעדכן לקוח קיים.
    /// </summary>
    /// <param name="item">פריט הלקוח לעדכון.</param>
    public void Update(Customer item)
    {
        throw new NotImplementedException();
    }

    /// <summary>
    /// מוחק לקוח לפי מזהה.
    /// </summary>
    /// <param name="id">מזהה הלקוח למחיקה.</param>
    public void Delete(int id)
    {
        throw new NotImplementedException();
    }
}


