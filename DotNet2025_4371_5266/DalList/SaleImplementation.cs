namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;


internal class SaleImplementation : ISale
{
    string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;

    public int Create(Sale item)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Creating sale with ID: {item.Code}");
        var isExist = DataSource.Sales.FirstOrDefault(s => s.Code == item.Code);
        Sale s;
        if (isExist != null)
        {
            throw new dal_idExist("The sale already exists");
        }
        else
        {
            s = item with { Code = DataSource.Config.SaleCode };
            DataSource.Sales.Add(s);
        }
        LogManager.Log(projectName, funcName, $"Sale created with ID: {item.Code}");
        return s.Code;
    }


    public Sale? Read(int Id)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading sale with ID: {Id}");
        Sale? sale = DataSource.Sales.FirstOrDefault(s => s.Code == Id);
        if (sale != null)
        {
            LogManager.Log(projectName, funcName, $"Sale found with ID: {Id}");
            return sale;
        }
        throw new dal_idNotFound("id not found");
    }

    public Sale? Read(Func<Sale, bool> filter)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading sale with filter");
        Sale? sale = DataSource.Sales.FirstOrDefault(filter);
        if (sale != null)
        {
            LogManager.Log(projectName, funcName, $"Sale found with filter");
            return sale;
        }
        throw new dal_objcectNotFound("Not found");
    }


    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading all sales");
        return filter!=null ? DataSource.Sales.Where(filter).ToList() : DataSource.Sales;
    }


    public void Update(Sale item)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Updating sale with ID: {item.Code}");
        Delete(item.Code);
        DataSource.Sales.Add(item);
        LogManager.Log(projectName, funcName, $"Sale updated with ID: {item.Code}");
    }


    public void Delete(int id)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        try
        {
            LogManager.Log(projectName, funcName, $"Deleting sale with ID: {id}");
            Sale? s= Read(id);
            DataSource.Sales.Remove(s);
            LogManager.Log(projectName, funcName, $"Sale deleted with ID: {id}");
        }
        catch (Exception ex)
        {
            throw new dal_idNotFound($"id not found {ex}");
        }
    }
}


