namespace DalApi;
using DO;

/// <summary>
/// ממשק לניהול מוצרים
/// </summary>
public interface IProduct
{
    int Create(Product item);
    Product? Read(int Id);
    List<Product?> ReadAll();
    void Update(Product item);
    void Delete(int id);
}


