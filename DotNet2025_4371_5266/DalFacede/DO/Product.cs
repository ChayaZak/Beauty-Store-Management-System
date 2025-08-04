namespace DO;


[Serializable]
public record Product(int Id, string? ProductName, Category Category, double Price, int QuantityInStock)
{
    public Product() : this(0, "ספה", Category.טיפוח_עור_הפנים, 5000, 10)
    {

    }
}


