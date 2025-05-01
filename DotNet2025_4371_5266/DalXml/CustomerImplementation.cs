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

        private const string pathSale = "../xml/customers.xml";


        public int Create(Customer item)
        {
            try
            {
                XElement customersRoot = XElement.Load(pathSale); // טוען את קובץ ה-XML
                if (customersRoot.Elements("Customer").Any(c => (int)c.Element("Id") == item.Id))
                {
                    throw new DO.dal_idExist($"The customer {item.Id} already exists");
                }

                //XElement newCustomer = new XElement("Customer",
                //    new XElement("Id", item.Id),
                //    new XElement("Name", item.Name),
                //    new XElement("Address", item.Address),
                //    new XElement("Phone", item.Phone)
                //);

                XElement newCustomer = XmlTools.GetObject(item);

                customersRoot.Add(newCustomer);
                customersRoot.Save(pathSale);
                return item.Id;
            }

            catch (Exception ex)
            {
                throw new DO.dal_XmlFileLoad($"Error loading XML file: {ex.Message}");
            }

        }


        public void Delete(int id)
        {
            XElement customersRoot = XElement.Load(pathSale); // טוען את קובץ ה-XML
            Customer customer = Read(id);
            if (customer == null)
            {
                throw new dal_idNotFound("id not found");
            }
            XElement customerToDelete = XmlTools.GetObject(customer);
            customersRoot.Element(customer).Remove();
            customerToDelete.Remove();
            customersRoot.Save(pathSale);

        }

        public Customer? Read(int Id)
        {
            XElement customersRoot = XElement.Load(pathSale);

            XElement customerElement = customersRoot.Elements("Customer").FirstOrDefault(c => (int)c.Element("Id") == Id);
            if (customerElement != null)
            {
                return new Customer
                {
                    Id = (int)customerElement.Element("Id"),
                    Name = (string)customerElement.Element("Name"),
                    Address = (string)customerElement.Element("Address"),
                    Phone = (int)customerElement.Element("Phone")
                };
            }
            throw new dal_idNotFound("id not found");

        }

        public Customer? Read(Func<Customer, bool> filter)
        {
            XElement customersRoot = XElement.Load(pathSale);

            XElement customerElement = customersRoot.Elements("Customer").FirstOrDefault(filter);
            if (customerElement != null)
            {
                return new Customer
                {
                    Id = (int)customerElement.Element("Id"),
                    Name = (string)customerElement.Element("Name"),
                    Address = (string)customerElement.Element("Address"),
                    Phone = (int)customerElement.Element("Phone")
                };
            }
            throw new dal_objcectNotFound("Not found");
        }

        public List<Customer?> ReadAll(Func<Customer, bool>? filter = null)
        {
            XElement customersRoot = XElement.Load(pathSale);
            List<XElement> customerElements = customersRoot.Elements("Customer").ToList();
            List<Customer?> customers = new List<Customer?>();
            foreach (var item in customerElements)
            {
                Customer customer = new Customer
                {
                    Id = (int)item.Element("Id"),
                    Name = (string)item.Element("Name"),
                    Address = (string)item.Element("Address"),
                    Phone = (int)item.Element("Phone")
                };
                customers.Add(customer);
            }
            return customers;
        }

        public void Update(Customer item)
        {
            throw new NotImplementedException();
        }
    }
}
