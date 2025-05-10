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

            // טוען את קובץ ה-XML
            XElement dataConfig = XElement.Load(Config.DataConfig) ??
                throw new DalConfigException("data config is missing");

            // מוצא את האלמנט לפי השם
            XElement? element = dataConfig.Element(name) ??
                throw new DalConfigException($"<{name}> element is missing");

            // מעלה את הערך ב-1
            int val = int.Parse(element.Value) + 1;

            // מעדכן את הערך ב-XML
            element.Value = val.ToString();

            // שומר את הקובץ
            dataConfig.Save(Config.DataConfig);

            // מחזיר את הערך החדש
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
