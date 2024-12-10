
namespace Dal;
using DO;
using DalApi;

internal class SaleImplementation : ISale
{
    public int Create(Sale item)
    {
        Sale s = item with { Code = DataSource.Config.SaleCode };
        DataSource.Sales.Add(s);
        return s.Code;
    }
    public Sale? Read(int Id)
    {
        throw new NotImplementedException();
    }
    public List<Sale?> ReadAll()
    {
        throw new NotImplementedException();

    }
    public void Update(Sale item)
    {
        throw new NotImplementedException();

    }
    public void Delete(int id)
    {
        throw new NotImplementedException();

    }
}
