

namespace DalApi;
using DO;
public interface IProduct
{
    int Create(Product item);
    Product? Read(int Id);
    List<Product?> ReadAll();
    void Update(Product item);  
    void Delete(int id);  

}
