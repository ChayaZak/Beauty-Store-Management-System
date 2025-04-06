using DO;
using DalApi;
using System.Runtime.InteropServices;
namespace DalTest;

/// <summary>
/// מחלקה לאתחול נתונים.
/// </summary>
public static class Initialization
{
    private static IDal? s_dal;

    /// <summary>
    /// יוצר מוצרים לדוגמה.
    /// </summary>
    private static void CreateProducts()
    {
        if (s_dal?.Product != null)
        {
            s_dal.Product.Create(new Product(101, "סבון", Category.טיפוח_עור_הפנים, 40.0, 50));
            s_dal.Product.Create(new Product(123, "קרם לחות", Category.טיפוח_אישי, 50.00, 100));
            s_dal.Product.Create(new Product(244, "קרם הגנה", Category.טיפוח_אישי, 70.00, 200));
            s_dal.Product.Create(new Product(032, "אלוורה", Category.משקאות, 130.00, 20));
            s_dal.Product.Create(new Product(447, "דבש", Category.מוצרי_כוורת, 20.00, 300));
            s_dal.Product.Create(new Product(245, "פילינג", Category.טיפוח_העור, 80.00, 70));
        }
    }

    /// <summary>
    /// יוצר מבצעים לדוגמה.
    /// </summary>
    private static void CreateSales()
    {
        if (s_dal?.Sale != null)
        {
            s_dal.Sale.Create(new Sale(3552, 032, 3, 300, true, DateTime.Now, DateTime.Now.AddDays(8)));
            s_dal.Sale.Create(new Sale(3699, 245, 2, 140, false, DateTime.Now, DateTime.Now.AddDays(6)));
        }
    }

    /// <summary>
    /// יוצר לקוחות לדוגמה.
    /// </summary>
    private static void CreateCustomers()
    {
        if (s_dal?.Customer != null)
        {
            s_dal.Customer.Create(new Customer(101, "אבי", "אבי@a.com", 0521234567));
            s_dal.Customer.Create(new Customer(123, "מאיה", "מאיה@a.com", 0521234567));
            s_dal.Customer.Create(new Customer(244, "רוני", "רוני@a.com", 0521234567));
            s_dal.Customer.Create(new Customer(032, "אורן", "אורן@a.com", 0521234567));
            s_dal.Customer.Create(new Customer(447, "עדי", "עדי@a.com", 0521234567));
            s_dal.Customer.Create(new Customer(327824371, "מירי", "מתתיהו", 0534198438));
            s_dal.Customer.Create(new Customer(214915266, "חיה", "ברכפלד", 0534192458));
            s_dal.Customer.Create(new Customer(025547241, "שושי", "ברכפלד", 0502446876));
            s_dal.Customer.Create(new Customer(354788898, "שרה", "קרית ספר", 089741004));
        }
    }

    /// <summary>
    /// מאתחל את הנתונים.
    /// </summary>
    /// <param name="dalProduct">ממשק לניהול מוצרים.</param>
    /// <param name="dalCustomer">ממשק לניהול לקוחות.</param>
    /// <param name="dalSale">ממשק לניהול מבצעים.</param>
    public static void Initialize(IDal dal)
    {
        s_dal = dal;

        CreateProducts();
        CreateSales();
        CreateCustomers();
    }
}
