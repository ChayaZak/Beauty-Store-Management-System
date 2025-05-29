using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Tools;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        private const string PATH_PRODUCT = @"..\..\..\..\xml\products.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        string projectName = MethodBase.GetCurrentMethod().DeclaringType.FullName;

        /// <summary>
        /// הוספת מוצר
        /// </summary>
        /// <param name="item">פריט המוצר להוספה</param>
        /// <returns>מזהה המוצר שנוסף</returns>
        /// <exception cref="dal_idExist"></exception>
        public int Create(Product item)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Creating product with ID: {item.Id}");
            List<Product?> products = new List<Product?>();
            products = ReadAll();
            var isExist = products.FirstOrDefault(p => p.Id == item.Id);
            if (isExist != null)
            {
                throw new dal_idExist("The product already exists");
            }
            else
            {
                item = item with { Id = Config.ProductCode };
                products.Add(item);
                using (FileStream XmlWrite = new FileStream(PATH_PRODUCT, FileMode.Create, FileAccess.Write))
                {
                    serializer.Serialize(XmlWrite, products);
                }
            }
            LogManager.Log(projectName, funcName, $"Product created with ID: {item.Id}");
            return item.Id;
        }

        /// <summary>
        /// מחיקת מוצר
        /// </summary>
        /// <param name="id">מזהה המוצר למחיקה</param>
        /// <exception cref="dal_idNotFound"></exception>
        public void Delete(int id)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Deleting product with ID: {id}");
            Product? product = Read(id);
            if (product == null)
                throw new dal_idNotFound("id not found");
            List<Product?> products = ReadAll();
            products.Remove(product);
            using (FileStream XmlWrite = new FileStream(PATH_PRODUCT, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, products);
            }
            LogManager.Log(projectName, funcName, $"Product deleted with ID: {id}");
        }

        /// <summary>
        /// קבלת מוצר לפי מזהה מוצר
        /// </summary>
        /// <param name="Id">מזהה מוצר</param>
        /// <returns>מוצר שהתקבל לפי המזהה</returns>
        /// <exception cref="dal_idNotFound"></exception>
        public Product? Read(int Id)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Reading product with ID: {Id}");
            Product? product = ReadAll(p => p.Id == Id).FirstOrDefault();
            if (product != null)
            {
                LogManager.Log(projectName, funcName, $"Product found with ID: {Id}");
                return product;
            }
            throw new dal_idNotFound("id not found");
        }

        /// <summary>
        /// קבלת מוצר לפי תנאי סינון
        /// </summary>
        /// <param name="filter">תנאי לסינון</param>
        /// <returns>מוצר המתאים לתנאי הסינון</returns>
        /// <exception cref="dal_objcectNotFound"></exception>
        public Product? Read(Func<Product, bool> filter)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Reading product with filter");
            Product? product = ReadAll(filter).FirstOrDefault();
            if (product != null)
            {
                LogManager.Log(projectName, funcName, $"Product found with filter");
                return product;
            }
            throw new dal_objcectNotFound("Not found");
        }

        /// <summary>
        /// קבלת כל המוצרים העומדים בתנאי הסינון
        /// </summary>
        /// <param name="filter">תנאי לסינון</param>
        /// <returns>רשימת מוצרים העומדים בתנאי הסינון</returns>
        /// <exception cref="NotImplementedException"></exception>
        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Reading all products");
            try
            {
                List<Product?> products = new List<Product?>();
                using (FileStream XmlReader = new FileStream(PATH_PRODUCT, FileMode.Open, FileAccess.Read))
                {
                    products = serializer.Deserialize(XmlReader) as List<Product?>;
                }
                return filter != null ? products.Where(filter).Cast<Product?>().ToList() : products.Cast<Product?>().ToList();
            }
            catch (Exception ex)
            {
                throw new NotImplementedException("שגיאה בקריאת המוצרים מקובץ xml");
            }
        }

        /// <summary>
        /// עדכון מוצר
        /// </summary>
        /// <param name="item">מוצר לעדכון</param>
        public void Update(Product item)
        {
            string funcName = MethodBase.GetCurrentMethod().Name;
            LogManager.Log(projectName, funcName, $"Updating product with ID: {item.Id}");
            Delete(item.Id);
            //Create(item);
            List<Product?> products = new List<Product?>();
            products = ReadAll();
            //item = item with { Id = Config.ProductCode };
            products.Add(item);
            using (FileStream XmlWrite = new FileStream(PATH_PRODUCT, FileMode.Create, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, products);
            }
            LogManager.Log(projectName, funcName, $"Product updated with ID: {item.Id}");

        }
    }
}
