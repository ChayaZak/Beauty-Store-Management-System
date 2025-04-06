using Dal;
using DalApi;
using DO;
using System.Data.Common;
using System.Xml;
using System.Reflection;
using Tools;

namespace DalTest
{
    /// <summary>
    /// תוכנית ראשית לבדיקות.
    /// </summary>
    internal class Program
    {
        static string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        private static readonly IDal? s_dal = DalApi.Factory.Get;


        private static void Main(string[] args)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            // אתחול בסיס הנתונים
            Initialization.Initialize();
            try
            {
                int select1;
                select1 = PrintMenu();
                while (select1 != 0)
                {
                    switch (select1)
                    {
                        case 1:
                            Console.WriteLine("מוצרים");
                            ProductMenu();
                            break;
                        case 2:
                            Console.WriteLine("לקוחות");
                            CustomerMenu();
                            break;
                        case 3:
                            Console.WriteLine("מבצעים");
                            SaleMenu();
                            break;
                        case 4:
                            Console.WriteLine("למחיקת תקיית הלוגים");
                            LogManager.CleanLog();
                            break;
                        default:
                            Console.WriteLine(" בחירה שגויה אנא הקש שוב");
                            break;
                    }
                    select1 = PrintMenu();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                LogManager.Log(projectName, funcName, $"Error: {ex.Message}");
                throw new dal_InvalidMenu($"בחירה לא חוקית {ex}");
            }
        }

        /// <summary>
        /// מציג תפריט ראשי ומחזיר את הבחירה של המשתמש.
        /// </summary>
        /// <returns>הבחירה של המשתמש.</returns>
        public static int PrintMenu()
        {
            Console.WriteLine("למוצרים הקש 1");
            Console.WriteLine("ללקוחות הקש 2");
            Console.WriteLine("למבצעים הקש 3");
            Console.WriteLine("למחיקת תקיית הלוגים הקש 4");
            Console.WriteLine("ליציאה הקש 0");

            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;
        }

        /// <summary>
        /// מציג תפריט משנה ומחזיר את הבחירה של המשתמש.
        /// </summary>
        /// <param name="item">סוג הפריט בתפריט המשנה.</param>
        /// <returns>הבחירה של המשתמש.</returns>
        public static int PrintSubMenu(string item)
        {
            int select;

            Console.WriteLine($"להוספת {item} הקש 1");
            Console.WriteLine($"לקבלת {item} הקש 2");
            Console.WriteLine($"לקבלת כל ה{item} הקש 3");
            Console.WriteLine($"לעדכון {item} הקש 4");
            Console.WriteLine($"למחיקת {item} הקש 5");

            if (!int.TryParse(Console.ReadLine(), out select))
                select = -1;
            return select;
        }

        /// <summary>
        /// תפריט לניהול מוצרים.
        /// </summary>
        public static void ProductMenu()
        {
            int select;
            select = PrintSubMenu("מוצר");

            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        AddProduct();
                        break;
                    case 2:
                        Read(s_dal.Product);
                        break;
                    case 3:
                        ReadAll(s_dal.Product.ReadAll());
                        break;
                    case 4:
                        UpdateProduct();
                        break;
                    case 5:
                        Delete(s_dal.Product);
                        break;
                    default:
                        Console.WriteLine("לא קיים תפריט כזה");
                        break;
                }
                select = PrintSubMenu("מוצר");
            }
        }

        /// <summary>
        /// תפריט לניהול לקוחות.
        /// </summary>
        public static void CustomerMenu()
        {
            int select;
            select = PrintSubMenu("לקוח");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        AddCustomer();
                        break;
                    case 2:
                        Read(s_dal.Customer);
                        break;
                    case 3:
                        ReadAll(s_dal.Customer.ReadAll());
                        break;
                    case 4:
                        UpdateCustomer();
                        break;
                    case 5:
                        Delete(s_dal.Customer);
                        break;
                    default:
                        Console.WriteLine("לא קיים תפריט כזה");
                        break;
                }
                select = PrintSubMenu("לקוח");
            }
        }

        /// <summary>
        /// תפריט לניהול מבצעים.
        /// </summary>
        public static void SaleMenu()
        {
            int select;
            select = PrintSubMenu("מבצע");
            while (select != 0)
            {
                switch (select)
                {
                    case 1:
                        AddSale();
                        break;
                    case 2:
                        Read(s_dal.Sale);
                        break;
                    case 3:
                        ReadAll(s_dal.Sale.ReadAll());
                        break;
                    case 4:
                        UpdateSale();
                        break;
                    case 5:
                        Delete(s_dal.Sale);
                        break;
                    default:
                        Console.WriteLine("לא קיים תפריט כזה");
                        break;
                }
                select = PrintSubMenu("מבצע");
            }
        }

        /// <summary>
        /// מוסיף מוצר חדש.
        /// </summary>
        public static void AddProduct()
        {
            string? productName;
            Category category;
            double price;
            int QuantityInStock;
            Console.WriteLine("הכנס שם מוצר");
            productName = Console.ReadLine();
            Console.WriteLine("תבחר קטגוריה בין 0-5");
            int cat;
            if (!int.TryParse(Console.ReadLine(), out cat)) category = 0;
            else category = Category(cat);
            Console.WriteLine("הכנס מחיר");
            if (!double.TryParse(Console.ReadLine(), out price)) price = 10;
            Console.WriteLine("הכנס כמות");
            if (!int.TryParse(Console.ReadLine(), out QuantityInStock)) QuantityInStock = 0;

            Product p = new Product(0, productName, category, price, QuantityInStock);
            int code = s_dal.Product.Create(p);
            p = p with { Id = code };

            Console.WriteLine("המוצר נוצר בהצלחה");
            Console.WriteLine(p);
        }

        /// <summary>
        /// מוסיף לקוח חדש.
        /// </summary>
        public static void AddCustomer()
        {
            int id;
            string customerName;
            string address;
            int phone;
            Console.WriteLine("הכנס ת.ז.");
            if(!int.TryParse(Console.ReadLine(), out id)) id = 0;
            Console.WriteLine("הכנס שם לקוח");
            customerName = Console.ReadLine();
            Console.WriteLine("הכנס כתובת");
            address = Console.ReadLine();
            Console.WriteLine("הכנס טלפון");
            if (!int.TryParse(Console.ReadLine(), out phone)) phone = 0;
            Customer c = new Customer(id, customerName, address, phone);
            int code = s_dal.Customer.Create(c);
            
            Console.WriteLine($"הלקוח {code} נוצר בהצלחה");
            Console.WriteLine(c);
        }

        /// <summary>
        /// מוסיף מבצע חדש.
        /// </summary>
        public static void AddSale()
        {
            int productId;
            DateTime date;
            DateTime endDate;
            int quantity;
            double price;
            bool isDiscount;
            Console.WriteLine("הכנס מזהה מוצר");
            if (!int.TryParse(Console.ReadLine(), out productId)) productId = 0;
            Console.WriteLine("הכנס תאריך");
            if (!DateTime.TryParse(Console.ReadLine(), out date)) date = DateTime.Now;
            Console.WriteLine("הכנס תאריך סיום");
            if (!DateTime.TryParse(Console.ReadLine(), out endDate)) endDate = DateTime.Now.AddDays(7);
            Console.WriteLine("הכנס כמות");
            if (!int.TryParse(Console.ReadLine(), out quantity)) quantity = 0;
            Console.WriteLine("הכנס מחיר");
            if (!double.TryParse(Console.ReadLine(), out price)) price = 0;
            Console.WriteLine("האם יש הנחה? (true/false)");
            if (!bool.TryParse(Console.ReadLine(), out isDiscount)) isDiscount = false;
            Sale s = new Sale(0, productId, quantity, price, isDiscount, date, endDate);
            int code = s_dal.Sale.Create(s);
            s = s with { Code = code };
            Console.WriteLine("המבצע נוצר בהצלחה");
            Console.WriteLine(s);
        }

        /// <summary>
        /// קורא פריט לפי מזהה.
        /// </summary>
        /// <typeparam name="T">סוג הפריט.</typeparam>
        /// <param name="ICrud">ממשק לניהול הפריט.</param>
        private static void Read<T>(ICrud<T> ICrud)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            try
            {
                Console.WriteLine("הכנס קוד");
                int id = int.Parse(Console.ReadLine());
                Console.WriteLine(ICrud.Read(id));
            }
            catch (Exception e)
            {
                Console.WriteLine("שגיאה: לא נמצא פריט עם מזהה זה");
                LogManager.Log(projectName, funcName, $"Error: {e.Message}");
                Console.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// קורא את כל הפריטים.
        /// </summary>
        /// <typeparam name="T">סוג הפריט.</typeparam>
        /// <param name="list">רשימת הפריטים.</param>
        private static void ReadAll<T>(List<T> list)
        {
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
        }

        /// <summary>
        /// מוחק לפי מזהה.
        /// </summary>
        private static void Delete<T>(ICrud<T> ICrud)
        {
            int id;
            Console.WriteLine($"למחיקת פריט הכנס קוד ");
            if (!int.TryParse(Console.ReadLine(), out id)) id = 0;
            ICrud.Delete(id);
            Console.WriteLine("הפריט נמחק בהצלחה");
        }

      

        /// <summary>
        /// מעדכן מוצר קיים.
        /// </summary>
        private static void UpdateProduct()
        {
            string productName;
            Category category;
            double price;
            int quantityInStock;

            Console.WriteLine("הכנס שם מוצר:");
            productName = Console.ReadLine();

            Product productToUpdate = s_dal.Product.ReadAll().FirstOrDefault(p => p.ProductName.Equals(productName, StringComparison.OrdinalIgnoreCase));

            if (productToUpdate == null)
            {
                Console.WriteLine("לא נמצא מוצר בשם זה.");
                return;
            }

            Console.WriteLine($"המוצר שנמצא: {productToUpdate}");
            Console.WriteLine("מה תרצה לשנות?");
            Console.WriteLine("1 - מחיר");
            Console.WriteLine("2 - כמות");
            Console.WriteLine("3 - קטגוריה");
            Console.WriteLine("0 - יציאה");

            int choice = int.TryParse(Console.ReadLine(), out choice) ? choice : -1;

            Product updatedProduct = productToUpdate;

            switch (choice)
            {
                case 1:  // שינוי מחיר
                    Console.WriteLine("הכנס מחיר חדש:");
                    if (!double.TryParse(Console.ReadLine(), out price)) price = productToUpdate.Price;
                    updatedProduct = updatedProduct with { Price = price };
                    break;

                case 2:  // שינוי כמות
                    Console.WriteLine("הכנס כמות חדשה במלאי:");
                    if (!int.TryParse(Console.ReadLine(), out quantityInStock)) quantityInStock = productToUpdate.QuantityInStock; // אם לא הכנס כמות תקנית, שמור את הכמות הנוכחית
                    updatedProduct = updatedProduct with { QuantityInStock = quantityInStock };
                    break;

                case 3:  // שינוי קטגוריה
                    Console.WriteLine("הכנס קטגוריה חדשה:");
                    if (int.TryParse(Console.ReadLine(), out int cat))
                        category = Category(cat);
                    else
                        category = productToUpdate.Category;
                    updatedProduct = updatedProduct with { Category = category };
                    break;
                case 0:
                    return;

                default:
                    Console.WriteLine("בחירה לא חוקית.");
                    break;
            }

            s_dal.Product.Update(updatedProduct);

            Console.WriteLine($"המוצר עודכן בהצלחה: {updatedProduct}");

            ProductMenu();
        }

        /// <summary>
        /// מעדכן לקוח קיים.
        /// </summary>
        private static void UpdateCustomer()
        {
            int id;
            string name;
            string address;
            int phone;

            Console.WriteLine("הכנס קוד לקוח");
            if (!int.TryParse(Console.ReadLine(), out id)) id = 0;

            Console.WriteLine("הכנס שם");
            name = Console.ReadLine();

            Console.WriteLine("הכנס כתובת");
            address = Console.ReadLine();

            Console.WriteLine("הכנס מס' טלפון");
            if (!int.TryParse(Console.ReadLine(), out phone)) phone = 0000000000;

            Customer c = new Customer(id, name, address, phone);
            s_dal.Customer.Update(c);

            Console.WriteLine("הלקוח עודכן בהצלחה");
            Console.WriteLine(c);
        }

        /// <summary>
        /// מעדכן מבצע קיים.
        /// </summary>
        private static void UpdateSale()
        {
            int code;
            int productId;
            int minQuantity;
            double price;
            bool inClob;
            DateTime beginSale;
            DateTime endSale;
            Console.WriteLine("הכנס קוד מבצע");
            if (!int.TryParse(Console.ReadLine(), out code)) code = 0;
            Console.WriteLine("הכנס קוד מוצר");
            if (!int.TryParse(Console.ReadLine(), out productId)) productId = 0;

            Console.WriteLine("הכנס מחיר");
            if (!double.TryParse(Console.ReadLine(), out price)) price = 0;

            Console.WriteLine("הכנס כמות מינימלית במבצע");
            if (!int.TryParse(Console.ReadLine(), out minQuantity)) minQuantity = 0;

            Console.WriteLine("האם במועדון?");
            if (!bool.TryParse(Console.ReadLine(), out inClob)) inClob = false;

            
            Console.WriteLine("הכנס תאריך התחלה");
            if (!DateTime.TryParse(Console.ReadLine(), out beginSale)) beginSale = DateTime.Now;

            Console.WriteLine("הכנס תאריך תפוגה");
            if (!DateTime.TryParse(Console.ReadLine(), out endSale)) endSale = DateTime.Now.AddDays(1);

            Sale s = new Sale(code, productId, minQuantity, price, inClob, beginSale, endSale);
            s_dal.Sale.Update(s);

            Console.WriteLine("המבצע עודכן בהצלחה");
            Console.WriteLine(s);
        }

        /// <summary>
        /// מחזיר קטגוריה לפי מזהה.
        /// </summary>
        /// <param name="cat">מזהה הקטגוריה.</param>
        /// <returns>הקטגוריה המתאימה.</returns>
        private static Category Category(int cat)
        {
            switch (cat)
            {
                case 0:
                    return DO.Category.טיפוח_עור_הפנים;
                case 1:
                    return DO.Category.טיפוח_אישי;
                case 2:
                    return DO.Category.טיפוח_העור;
                case 3:
                    return DO.Category.משקאות;
                case 4:
                    return DO.Category.מוצרי_כוורת;
                default:
                    throw new dal_InvalidMenu($"קטגוריה לא חוקית {cat}");
                    
            }
        }
    }
}
