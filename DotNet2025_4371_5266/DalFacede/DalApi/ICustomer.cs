namespace DalApi;
using DO;

/// <summary>
/// ממשק לניהול לקוחות
/// </summary>
public interface ICustomer
{
    int Create(Customer item);
    Customer? Read(int Id);
    List<Customer?> ReadAll();
    void Update(Customer item);
    void Delete(int id);
}

