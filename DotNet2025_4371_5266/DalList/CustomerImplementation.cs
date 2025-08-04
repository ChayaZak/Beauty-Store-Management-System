namespace Dal;
using DO;
using DalApi;
using System.Reflection;
using Tools;


internal class CustomerImplementation : ICustomer
{
    private string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;

    public int Create(Customer item)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Creating customer with ID: {item.Id}");
        var isExist = DataSource.Customers.FirstOrDefault(c => c.Id == item.Id);
        if (isExist != null)
        {
            throw new dal_idExist("The customer already exists");
        }
        else
        {
            DataSource.Customers.Add(item);
        }
        LogManager.Log(projectName, funcName, $"Customer created with ID: {item.Id}");
        return item.Id;

    }


    public Customer? Read(int Id)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading customer with ID: {Id}");
        Customer? customer = DataSource.Customers.FirstOrDefault(c => c.Id == Id);
        if (customer != null)
        {
            LogManager.Log(projectName, funcName, $"Customer found with ID: {Id}");
            return customer;
        }
        throw new dal_idNotFound("id not found");
    }

    public Customer? Read(Func<Customer, bool> filter)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading customer with filter");
        Customer? customer = DataSource.Customers.FirstOrDefault(filter);
        if (customer != null)
        {
            LogManager.Log(projectName, funcName, $"Customer found with filter");
            return customer;
        }
        throw new dal_objcectNotFound("Not found");
    }


    public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Reading all customers");
        return filter != null ? DataSource.Customers.Where(filter).ToList() : DataSource.Customers;
    }



    public void Update(Customer item)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, $"Updating customer with ID: {item.Id}");
        Delete(item.Id);
        DataSource.Customers.Add(item);
        LogManager.Log(projectName, funcName, $"Customer updated with ID: {item.Id}");
    }


    public void Delete(int id)
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        try
        {
            LogManager.Log(projectName, funcName, $"Deleting customer with ID: {id}");
            Customer c = Read(id);
            DataSource.Customers.Remove(c);
            LogManager.Log(projectName, funcName, $"Customer deleted with ID: {id}");
        }
        catch (dal_idNotFound ex)
        {
            throw new dal_idNotFound($"Failed to delete customer with ID {id}. {ex.Message}");
        }
        catch (Exception ex)
        {
            throw new dal_idNotFound($"id not found ");
        }
    }
}


