using BO;
using DalTest;

namespace BlTest
{
    internal class Program
    {
        public static Order order = new BO.Order();

        static readonly BlApi.IBl s_bl = BlApi.Factory.Get();
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            Initialization.Initialize();

            int select;
            select = PrintMenu();
            while (select != 0)
            {

                Menu(select);
                select = PrintMenu();
            }
        }


        public static void AddOrGetCustomer()


        {
            try
            {
                Console.WriteLine("insert ID of customer, to new customer insert 0");
                int id = int.Parse(Console.ReadLine());
                if (id == 0)
                {
                    Console.WriteLine("insert ID of customer");
                    id = int.Parse(Console.ReadLine());
                    Console.WriteLine("insert name of customer");
                    string name = Console.ReadLine();
                    Console.WriteLine("insert address of customer");
                    string address = Console.ReadLine();
                    Console.WriteLine("insert phone of customer");
                    int phone = int.Parse(Console.ReadLine());
                    s_bl.Customer.Create(new BO.Customer() { Id = id, Name = name, Address = address, Phone = phone });
                }
                else
                {
                    BO.Customer? customer = s_bl.Customer.Read(id);
                    if (customer != null)
                        Console.WriteLine(customer.ToString());
                    else
                        Console.WriteLine("Customer not found");
                }
            }
            catch (BO.Bl_ObjectIsNull ex)
            {
                Console.WriteLine("Object is null");
            }
            catch (BO.Bl_IdNotFound ex)
            {
                Console.WriteLine("Id not found");
            }
            catch (BO.Bl_IdExist ex)
            {
                Console.WriteLine("Id already exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public static void AddProductTOOrder()
        {
            try
            {
                Console.WriteLine("insert id of product");
                int productId = int.Parse(Console.ReadLine());
                Console.WriteLine("insert quantity of product");
                int quantity = int.Parse(Console.ReadLine());
                List<SaleInProduct> sales = s_bl.Order.AddProductToOrder(order, productId, quantity);
                if (sales != null)
                {
                    Console.WriteLine(sales.Count == 0 ? "No sales found" : "Sales found");
                    foreach (var sale in sales)
                    {
                        Console.WriteLine(sale.ToString());
                    }
                }
                Console.WriteLine($"The final price to pay: {order.TotalPrice}");
            }
            catch (BO.Bl_ObjectIsNull ex)
            {
                Console.WriteLine("Object is null");
            }
            catch (BO.Bl_IdNotFound ex)
            {
                Console.WriteLine("Id not found");
            }
            catch (BO.Bl_IdExist ex)
            {
                Console.WriteLine("Id already exists");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }


        public static int PrintMenu()
        {
            Console.WriteLine("1. Add or get customer");
            Console.WriteLine("2. Add product to order");
            Console.WriteLine("3. Do order");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Please select an option:");
            int option = int.Parse(Console.ReadLine());
            return option;
        }

        public static void Menu(int option)
        {
            switch (option)
            {
                case 1:
                    AddOrGetCustomer();
                    break;
                case 2:
                    AddProductTOOrder();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("Invalid option, please try again.");
                    break;
            }
        }
    }
}
