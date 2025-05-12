using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;

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


        public int Create(Customer item)
        {

            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            //if (customersRoot.Element(CUSTOMER).Elements().Any(c => int.Parse(c.Element(ID).Value) == item.Id))
            //{
            //    throw new DO.dal_idExist($"The customer {item.Id} already exists");
            //}

        

            XElement newCustomer = XmlTools.GetObject(item);

            customersRoot.Add(newCustomer);
            customersRoot.Save(PATH_CUSTOMER);
            return item.Id;



        }


        public void Delete(int id)
        {
            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            //Customer? customer = Read(id);

            //XElement customerToDelete = XmlTools.GetObject(customer);
            XElement customerToDelete = customersRoot.Elements().FirstOrDefault(c => int.Parse(c.Element(ID).Value) == id);
            if (customerToDelete == null)
                throw new DO.dal_idNotFound($"The customer {id} does not exist");
            customerToDelete.Remove();
            customersRoot.Save(PATH_CUSTOMER);
        }

        public Customer? Read(int Id)
        {
            XElement? customersRoot = XElement.Load(PATH_CUSTOMER);
            if (customersRoot == null)
                throw new DO.dal_XmlFileLoad("Error loading customer xml file");
            XElement? customerElement = customersRoot.Elements().FirstOrDefault(c => int.Parse(c.Element(ID).Value) == Id);
            if (customerElement != null)
            {
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

        public Customer? Read(Func<Customer, bool> filter)
        {
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
                return customer;
            throw new dal_objcectNotFound("Not found");
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {

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

        public void Update(Customer item)
        {
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
        }
    }
}
