namespace DO;

/// <summary>
/// תכונות של לקוח
/// </summary>
/// <param name="Id">מזהה הלקוח</param>
/// <param name="Name">שם הלקוח</param>
/// <param name="Address">כתובת הלקוח</param>
/// <param name="Phone">טלפון הלקוח</param>
public record Customer(int Id, string Name, string Address, int Phone)
{
    public Customer() : this(0, "אילה", "נתיבות המשפט 56", 089743343)
    {

    }
}


