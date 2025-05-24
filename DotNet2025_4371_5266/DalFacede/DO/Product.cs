namespace DO;

/// <summary>
/// תכונות של מוצר
/// </summary>
/// <param name="Id">מזהה המוצר</param>
/// <param name="ProductName">שם המוצר</param>
/// <param name="Category">קטגוריית המוצר</param>
/// <param name="Price">מחיר המוצר</param>
/// <param name="QuantityInStock">כמות במלאי</param>
[Serializable]
public record Product(int Id, string? ProductName, Category Category, double Price, int QuantityInStock)
{
    public Product() : this(0, "ספה", Category.טיפוח_עור_הפנים, 5000, 10)
    {

    }
}


