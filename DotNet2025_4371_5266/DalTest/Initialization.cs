using DalApi;
using DO;
using System.Reflection;
using Tools;
namespace DalTest;


public static class Initialization
{
    static string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;

    private static IDal? s_dal;


    private static void CreateProducts()
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        if (s_dal?.Product != null)
        {
            LogManager.Log(projectName, funcName, "Creating products");
            s_dal.Product.Create(new Product(101, "סבון", Category.טיפוח_עור_הפנים, 40.0, 50));
            s_dal.Product.Create(new Product(123, "קרם לחות", Category.טיפוח_אישי, 50.00, 100));
            s_dal.Product.Create(new Product(244, "קרם הגנה", Category.טיפוח_אישי, 70.00, 200));
            s_dal.Product.Create(new Product(032, "אלוורה", Category.משקאות, 130.00, 20));
            s_dal.Product.Create(new Product(447, "דבש", Category.מוצרי_כוורת, 20.00, 300));
            s_dal.Product.Create(new Product(245, "פילינג", Category.טיפוח_העור, 80.00, 70));
            LogManager.Log(projectName, funcName, "Products created");
        }
    }


    private static void CreateSales()
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        if (s_dal?.Sale != null)
        {
            LogManager.Log(projectName, funcName, "Creating sales");
            s_dal.Sale.Create(new Sale(3699, 102, 2, 140, false, DateTime.Now, DateTime.Now.AddDays(6)));
            s_dal.Sale.Create(new Sale(3552, 104, 3, 300, true, DateTime.Now, DateTime.Now.AddDays(8)));
            s_dal.Sale.Create(new Sale(110, 100, 3, 100, false, DateTime.Now, DateTime.Now.AddDays(8)));
            s_dal.Sale.Create(new Sale(111, 100, 5, 150, true, DateTime.Now, DateTime.Now.AddDays(8)));
            LogManager.Log(projectName, funcName, "Sales created");
        }
    }


    private static void CreateCustomers()
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        if (s_dal?.Customer != null)
        {
            LogManager.Log(projectName, funcName, "Creating customers");
            s_dal.Customer.Create(new Customer(327824371, "מירי", "מתתיהו", 0534198438));
            s_dal.Customer.Create(new Customer(214915266, "חיה", "ירושלים", 0534192458));
            s_dal.Customer.Create(new Customer(025547241, "שושי", "כרמיאל", 0502446876));
            s_dal.Customer.Create(new Customer(354788898, "שרה", "ראש הנקרה", 089741004));
            LogManager.Log(projectName, funcName, "Customers created");
        }
    }


    public static void Initialize()
    {
        string funcName = MethodBase.GetCurrentMethod().Name;
        LogManager.Log(projectName, funcName, "Initializing data");
        s_dal = DalApi.Factory.Get;

        CreateProducts();
        CreateSales();
        CreateCustomers();
        LogManager.Log(projectName, funcName, "Data initialized");
    }
}
