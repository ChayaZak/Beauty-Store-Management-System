
namespace Dal;
using DO;
using DalApi;

public class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        Product p = item with { Id = DataSource.Config.ProductCode };
        DataSource.Products.Add(p);
        return p.Id;
    }
    public Product? Read(int Id)
    {
        foreach (Product item in DataSource.Products)
        {
            if (item.Id == Id)
                return item;
        }
        throw new Exception("id not found");
    }
    public List<Product?> ReadAll()
    {
        return DataSource.Products;
    }
    public void Update(Product item)
    {
        Delete(item.Id);
        DataSource.Products.Add(item);
    }
    public void Delete(int id)
    {
        Product p = Read(id);
        DataSource.Products.Remove(p);
    }
}
