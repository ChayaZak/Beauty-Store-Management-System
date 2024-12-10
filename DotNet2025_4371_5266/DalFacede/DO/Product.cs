
namespace DO;

/// <summary>
/// תכונות של מוצר
/// </summary>
/// <param name="Id"></param>
/// <param name="ProductName"></param>
/// <param name="Category"></param>
/// <param name="Price"></param>
/// <param name="QuantityInStock"></param>
public record Product(int Id, string ProductName, Category Category, double Price, int QuantityInStock)
{
    public Product() : this(0, "ספה", Category.טיפוח_עור_הפנים, 5000, 10)
    {

    }
}
