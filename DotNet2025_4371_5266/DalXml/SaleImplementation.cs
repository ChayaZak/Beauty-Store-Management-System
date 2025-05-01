using DalApi;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{
    internal class SaleImplementation : ISale
    {
        private const string PATH_SALE = "../xml/sales.xml";

        XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        public int Create(Sale item)
        {
            List<Sale?> Sales = new List<Sale?>();
            Sales = ReadAll();

            if (Sales.Any(s => s?.Code == item.Code))
            {
                throw new dal_idExist("The Sale already exists");
            }

            item = item with { Code = Config.SaleCode };

            Sales.Add(item);
            using (FileStream XmlWrite = new FileStream(PATH_SALE, FileMode.Open, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, Sales);
            }
            return item.Code;
        }

        public void Delete(int id)
        {
            Sale? Sale = Read(id);
            if (Sale == null)
                throw new dal_idNotFound("id not found");
            List<Sale?> Sales = ReadAll();
            Sales.Remove(Sale);
            using (FileStream XmlWrite = new FileStream(PATH_SALE, FileMode.Open, FileAccess.Write))
            {
                serializer.Serialize(XmlWrite, Sales);
            }
        }

        public Sale? Read(int Id)
        {
            return ReadAll(p => p.Code == Id).FirstOrDefault();
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            return ReadAll(filter).FirstOrDefault();
        }

        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
        {
            try
            {
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

        public void Update(Sale item)
        {
            Delete(item.Code);
            Create(item);
        }
    }
}
