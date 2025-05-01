using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{
    internal class ProductImplementation : IProduct
    {
        private const string PATH_PRODUCT = "../xml/products.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        public int Create(Product item)
        {
            List<Product?> products = new List<Product?>();
            products = ReadAll();
          
            //if (products.Any(p => p?.Id == item.Id))
            //{
            //    throw new dal_idExist("The product already exists");
            //}

            item = item with { Id = Config.ProductCode };

            products.Add(item);
            using (FileStream XmlWrite = new FileStream(PATH_PRODUCT, FileMode.Open, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, products);
            }
            return item.Id;
        }

        public void Delete(int id)
        {
            Product? product = Read(id);
            if (product == null)
                throw new dal_idNotFound("id not found");
            List<Product?> products = ReadAll();
            products.Remove(product);
            using (FileStream XmlWrite = new FileStream(PATH_PRODUCT, FileMode.Open, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, products);
            }
        }

        public Product? Read(int Id)
        {
            return ReadAll(p=>p.Id==Id).FirstOrDefault();
        }

        public Product? Read(Func<Product, bool> filter)
        {
            return ReadAll(filter).FirstOrDefault();
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {
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

        public void Update(Product item)
        {
            Delete(item.Id);
            Create(item);
        }
    }
}
