namespace DalApi;

/// <summary>
/// ממשק לניהול שכבת הנתונים (DAL)
/// </summary>
public interface IDal
{
    /// <summary>
    /// ניהול מוצרים
    /// </summary>
    IProduct Product { get; }

    /// <summary>
    /// ניהול מבצעים
    /// </summary>
    ISale Sale { get; }

    /// <summary>
    /// ניהול לקוחות
    /// </summary>
    ICustomer Customer { get; }
}

