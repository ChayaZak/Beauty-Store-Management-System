using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tools;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        private const string PATH_SALE = "C:\\Users\\user1\\Documents\\שנה ב\\C#\\my project\\project_c-\\DotNet2025_4371_5266\\xml\\sales.xml";
        string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;
        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));

        /// <summary>
        /// הוספת מבצע
        /// </summary>
        /// <param name="item">פריט המבצע להוספה</param>
        /// <returns>קוד מבצע</returns>
        /// <exception cref="dal_idExist"></exception>
        public int Create(Sale item)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Creating a new sale");
            List<Sale?> Sales = new List<Sale?>();
            Sales = ReadAll();
            var isExist = Sales.FirstOrDefault(s => s.Code == item.Code);
            Sale s;
            if (isExist != null)
            {
                throw new dal_idExist("The sale already exists");
            }
            s = item with { Code = Config.SaleCode };
            Sales.Add(s);
            using (FileStream XmlWrite = new FileStream(PATH_SALE, FileMode.Open, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, Sales);
            }
            LogManager.Log(projectName, funcName, $"Sale created with ID: {s.Code}");
            return s.Code;
        }


        /// <summary>
        /// מחיקת מבצע
        /// </summary>
        /// <param name="id">קוד המבצע למחיקה</param>
        /// <exception cref="dal_idNotFound"></exception>
        public void Delete(int id)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Deleting sale with ID: {id}");
            Sale? Sale = Read(id);
            if (Sale == null)
                throw new dal_idNotFound("id not found");
            List<Sale?> Sales = ReadAll();
            Sales.Remove(Sale);
            using (FileStream XmlWrite = new FileStream(PATH_SALE, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, Sales);
            }
            LogManager.Log(projectName, funcName, $"Sale deleted with ID: {id}");
        }

        /// <summary>
        /// קבלת מבצע לפי קוד מבצע
        /// </summary>
        /// <param name="Id">קוד מבצע</param>
        /// <returns>מבצע עם הקוד המבוקש</returns>
        /// <exception cref="dal_idNotFound"></exception>
        public Sale? Read(int Id)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Reading sale with ID: {Id}");
            Sale? sale = ReadAll(s => s.Code == Id).FirstOrDefault();
            if (sale != null)
            {
                LogManager.Log(projectName, funcName, $"Sale found with ID: {Id}");
                return sale;
            }
            throw new dal_idNotFound("id not found");
        }

        /// <summary>
        /// קבלת מבצע לפי פרמטר סינון
        /// </summary>
        /// <param name="filter">סינון למבצע</param>
        /// <returns>מבצע לפי תנאי הסינון</returns>
        /// <exception cref="dal_idNotFound"></exception>
        public Sale? Read(Func<Sale, bool> filter)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Reading sale with filter");
            Sale? sale = ReadAll(filter).FirstOrDefault();
            if (sale != null)
            {
                LogManager.Log(projectName, funcName, $"Sale found with ID: {sale.Code}");
                return sale;
            }
            throw new dal_idNotFound("id not found");
        }

        /// <summary>
        /// קבלת כל המבצעים העומדים בסינון
        /// </summary>
        /// <param name="filter">סינון המבצעים</param>
        /// <returns>רשימת מבצעים שעמדה בסינון</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            try
            {
                string funcName = MethodBase.GetCurrentMethod().Name;
                LogManager.Log(projectName, funcName, $"Reading all sales");
                List<Sale?> Sales = new List<Sale?>();
                using (FileStream XmlReader = new FileStream(PATH_SALE, FileMode.Open, FileAccess.Read))
                {
                    Sales = serializer.Deserialize(XmlReader) as List<Sale?>;
                }
                return filter != null ? Sales.Where(filter).Cast<Sale?>().ToList() : Sales.Cast<Sale?>().ToList();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("שגיאה בקריאת המוצרים מקובץ xml");
            }
        }

        /// <summary>
        /// עדכון מבצע
        /// </summary>
        /// <param name="item">מבצע לעדכון</param>
        public void Update(Sale item)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Updating sale with ID: {item.Code}");
            Delete(item.Code);
            List<Sale?> Sales = new List<Sale?>();
            Sales = ReadAll();
            Sales.Add(item);
            using (FileStream XmlWrite = new FileStream(PATH_SALE, FileMode.Open, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, Sales);
            }
            LogManager.Log(projectName, funcName, $"Sale updated with ID: {item.Code}");
        }
    }
}
