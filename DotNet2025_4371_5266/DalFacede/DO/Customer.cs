
namespace DO;
/// <summary>
/// תכונות של לקוח
/// </summary>
/// <param name="Id"></param>
/// <param name="Name"></param>
/// <param name="Address"></param>
/// <param name="Phone"></param>
public record Customer(int Id, string Name, string Address, int Phone)
{
    public Customer():this(0,"אילה", "נתיבות המשפט 56", 089743343)
    {

    }
}
