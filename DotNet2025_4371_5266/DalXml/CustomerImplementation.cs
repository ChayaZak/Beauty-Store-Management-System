using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using Tools;

namespace Dal
{
    internal class CustomerImplementation : ICustomer

    {
        //Initialization.Initialize();
        //XElement customer = XElement.Load(Config.DataConfig);
        private const string CUSTOMER = "Customer";
        private const string ID = "Id";
        private const string NAME = "Name";
        private const string ADDRESS = "Address";
        private const string PHONE = "Phone";

        private const string PATH_CUSTOMER = "C:\\Users\\user1\\Documents\\שנה ב\\C#\\my project\\project_c-\\DotNet2025_4371_5266\\xml\\customers.xml";

        private string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;

        /// <summary>
        /// הוספת לקוח
        /// </summary>
        /// <param name="item">אוביקט לקוח להוספה</param>
        /// <returns>מזהה הלקוח שנוסף</returns>
        /// <exception cref="DO.dal_XmlFileLoad"></exception>
        /// <exception cref="DO.dal_idExist"></exception>
        public int Create(Customer item)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Creating customer with ID: {item.Id}");
            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            XElement? customerElement = customersRoot.Elements().FirstOrDefault(c => int.Parse(c.Element(ID).Value) == item.Id);
            if (customerElement != null)
            {
                throw new DO.dal_idExist($"The customer {item.Id} already exists");
            }
            XElement newCustomer = XmlTools.GetObject(item);
            customersRoot.Add(newCustomer);
            customersRoot.Save(PATH_CUSTOMER);
            LogManager.Log(projectName, funcName, $"Customer created with ID: {item.Id}");
            return item.Id;
        }


        /// <summary>
        /// מחיקת לקוח
        /// </summary>
        /// <param name="id">מזהה הלקוח למחיקה</param>
        /// <exception cref="DO.dal_XmlFileLoad"></exception>
        /// <exception cref="DO.dal_idNotFound"></exception>
        public void Delete(int id)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Deleting customer with ID: {id}");
            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            Customer? customer = Read(id);

            XElement customerToDelete = customersRoot.Elements().FirstOrDefault(c => int.Parse(c.Element(ID).Value) == id);
            if (customerToDelete == null)
                throw new DO.dal_idNotFound($"The customer {id} does not exist");
            customerToDelete.Remove();
            customersRoot.Save(PATH_CUSTOMER);
            LogManager.Log(projectName, funcName, $"Customer deleted with ID: {id}");
        }

        /// <summary>
        /// קבלת לקוח לפי מזהה
        /// </summary>
        /// <param name="Id">מזהה לקוח</param>
        /// <returns>לקוח לפי המזהה שהתקבל</returns>
        /// <exception cref="DO.dal_XmlFileLoad"></exception>
        /// <exception cref="dal_idNotFound"></exception>
        public Customer? Read(int Id)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Reading customer with ID: {Id}");
            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            XElement? customerElement = customersRoot.Elements().FirstOrDefault(c => int.Parse(c.Element(ID).Value) == Id);
            if (customerElement != null)
            {
                LogManager.Log(projectName, funcName, $"Customer found with ID: {Id}");
                return new Customer
                {
                    Id = int.Parse(customerElement.Element(ID).Value),
                    Name = customerElement.Element(NAME).Value,
                    Address = customerElement.Element(ADDRESS).Value,
                    Phone = int.Parse(customerElement.Element(PHONE).Value)
                };
            }
            throw new dal_idNotFound("id not found");

        }

        /// <summary>
        /// קבלת לקח לפי פרמטר סינון
        /// </summary>
        /// <param name="filter">תנאי סינון</param>
        /// <returns>לקוח המתאים לתנאי הסינון</returns>
        /// <exception cref="DO.dal_XmlFileLoad"></exception>
        /// <exception cref="dal_objcectNotFound"></exception>
        public Customer? Read(Func<Customer, bool> filter)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Reading customer with filter");
            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            Customer? customer = customersRoot.Elements(CUSTOMER)
            .Select(c => new Customer
            {
                Id = int.Parse(c.Element(ID).Value),
                Name = c.Element(NAME).Value,
                Address = c.Element(ADDRESS).Value,
                Phone = int.Parse(c.Element(PHONE).Value)
            })
            .FirstOrDefault(filter);
            if (customer != null)
            {
                LogManager.Log(projectName, funcName, $"Customer found with filter");
                return customer;
            }
            throw new dal_objcectNotFound("Not found");
        }

        /// <summary>
        /// קבלת כל הלקוחות העומדים בתנאי הסינון
        /// </summary>
        /// <param name="filter">תנאי לסינון</param>
        /// <returns>רשימת לקוחות העומדים בתנאי הסינון</returns>
        /// <exception cref="DO.dal_XmlFileLoad"></exception>
        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Reading all customers");
            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            List<Customer> customers = customersRoot.Elements(CUSTOMER).Select(c => new Customer
            {
                Id = int.Parse(c.Element(ID).Value),
                Name = c.Element(NAME).Value,
                Address = c.Element(ADDRESS).Value,
                Phone = int.Parse(c.Element(PHONE).Value)
            }).ToList();

            return filter != null ? customers.Where(filter).ToList() : customers;
        }

        /// <summary>
        /// עדכון לקוח
        /// </summary>
        /// <param name="item">אוביקט לקוח לעדכון</param>
        /// <exception cref="DO.dal_XmlFileLoad"></exception>
        public void Update(Customer item)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Updating customer with ID: {item.Id}");
            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            Delete(item.Id);
            customersRoot.Add(new XElement(CUSTOMER,
                new XElement(ID, item.Id),
                new XElement(NAME, item.Name),
                new XElement(ADDRESS, item.Address),
                new XElement(PHONE, item.Phone)
            ));
            customersRoot.Save(PATH_CUSTOMER);
            LogManager.Log(projectName, funcName, $"Customer updated with ID: {item.Id}");
        }
    }
}