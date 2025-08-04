using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    public static class XmlTools
    {


        public static string GetValueByName(string name)
        {

            XElement dataConfig = XElement.Load(Config.DataConfig) ??
                throw new DalConfigException("data config is missing");

            XElement? element = dataConfig.Element(name) ??
                throw new DalConfigException($"<{name}> element is missing");

            int val = int.Parse(element.Value) + 1;

            element.Value = val.ToString();

            dataConfig.Save(Config.DataConfig);

            return val.ToString();

        }


        public static XElement GetObject(Customer customer)
        {
            XElement newCustomer = new XElement("Customer",
                   new XElement("Id", customer.Id),
                   new XElement("Name", customer.Name),
                   new XElement("Address", customer.Address),
                   new XElement("Phone", customer.Phone)
               );
            return newCustomer;
        }
    }
}
