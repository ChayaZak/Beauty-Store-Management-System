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

        /// <summary>
        /// מחזיר את ערך האלמנט לפי שם האלמנט
        /// </summary>
        /// <param name="name">שם האלמנט</param>
        /// <returns>ערך האלמנט</returns>
        /// <exception cref="DalConfigException"></exception>
        public static string GetValueByName(string name)
        {
            XElement dataConfig = XElement.Load(Config.DataConfig) ??
            throw new DalConfigException("data-config.xml file is not found");
            return dataConfig.Element(name)?.Value ?? throw new DalConfigException("<dal> element is missing");
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
