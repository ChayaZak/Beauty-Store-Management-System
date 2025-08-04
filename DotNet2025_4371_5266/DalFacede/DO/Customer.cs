namespace DO;


public record Customer(int Id, string Name, string? Address, int Phone)
{
    public Customer() : this(0, "אילה", "נתיבות המשפט 56", 089743343)
    {

    }
}