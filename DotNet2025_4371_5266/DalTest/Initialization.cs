using DO;
using DalApi;
using System.Runtime.InteropServices;
namespace DalTest;

/// <summary>
/// מחלקה לאתחול נתונים.
/// </summary>
public static class Initialization
{
    private static IProduct? _dalProduct;
    private static ICustomer? _dalCustomer;
    private static ISale? _dalSale;

    /// <summary>
    /// יוצר מוצרים לדוגמה.
    /// </summary>
    private static void CreateProducts()
    {
        if (_dalProduct != null)
        {
            _dalProduct.Create(new Product(101, "סבון", Category.טיפוח_עור_הפנים, 40.0, 50));
            _dalProduct.Create(new Product(123, "קרם לחות", Category.טיפוח_אישי, 50.00, 100));
            _dalProduct.Create(new Product(244, "קרם הגנה", Category.טיפוח_אישי, 70.00, 200));
            _dalProduct.Create(new Product(032, "אלוורה", Category.משקאות, 130.00, 20));
            _dalProduct.Create(new Product(447, "דבש", Category.מוצרי_כוורת, 20.00, 300));
            _dalProduct.Create(new Product(245, "פילינג", Category.טיפוח_העור, 80.00, 70));
        }
    }

    /// <summary>
    /// יוצר מבצעים לדוגמה.
    /// </summary>
    private static void CreateSales()
    {
        if (_dalSale != null)
        {
            _dalSale.Create(new Sale(3552, 032, 3, 300, true, DateTime.Now, DateTime.Now.AddDays(8)));
            _dalSale.Create(new Sale(3699, 245, 2, 140, false, DateTime.Now, DateTime.Now.AddDays(6)));
        }
    }

    /// <summary>
    /// יוצר לקוחות לדוגמה.
    /// </summary>
    private static void CreateCustomers()
    {
        if (_dalCustomer != null)
        {
            _dalCustomer.Create(new Customer(101, "אבי", "אבי@a.com", 0521234567));
            _dalCustomer.Create(new Customer(123, "מאיה", "מאיה@a.com", 0521234567));
            _dalCustomer.Create(new Customer(244, "רוני", "רוני@a.com", 0521234567));
            _dalCustomer.Create(new Customer(032, "אורן", "אורן@a.com", 0521234567));
            _dalCustomer.Create(new Customer(447, "עדי", "עדי@a.com", 0521234567));
            _dalCustomer.Create(new Customer(327824371, "מירי", "מתתיהו", 0534198438));
            _dalCustomer.Create(new Customer(214915266, "חיה", "ברכפלד", 0534192458));
            _dalCustomer.Create(new Customer(025547241, "שושי", "ברכפלד", 0502446876));
            _dalCustomer.Create(new Customer(354788898, "שרה", "קרית ספר", 089741004));
        }
    }

    /// <summary>
    /// מאתחל את הנתונים.
    /// </summary>
    /// <param name="dalProduct">ממשק לניהול מוצרים.</param>
    /// <param name="dalCustomer">ממשק לניהול לקוחות.</param>
    /// <param name="dalSale">ממשק לניהול מבצעים.</param>
    public static void Initialize(IProduct dalProduct, ICustomer dalCustomer, ISale dalSale)
    {
        _dalProduct = dalProduct;
        _dalCustomer = dalCustomer;
        _dalSale = dalSale;
        CreateProducts();
        CreateSales();
        CreateCustomers();
    }
}
