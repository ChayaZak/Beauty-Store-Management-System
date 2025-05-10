using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public static class Tools
    {
        public static string? ToStringProperty<T>(this T obj)
        {
            if (obj == null)
                return null;
            StringBuilder? sb = new StringBuilder();
            foreach (var property in obj.GetType().GetProperties())
            {
                sb.Append($"{property.Name} {property.GetValue(obj)}        ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// המרת לקוח מהשכבה הלוגית (BO) לשכבת הנתונים (DO)
        /// </summary>
        /// <param name="c">אוביקט לקוח להמרה מהשכבה הלוגית</param>
        /// <returns>לקוח מסוג שכבת הנתונים</returns>
        public static DO.Customer ConvertCustomerToDO(BO.Customer c) => c == null ? throw new Bl_ObjectIsNull("The customer object is null") : new DO.Customer(c.Id, c.Name, c.Address, c.Phone);

        /// <summary>
        /// המרת לקוח משכבת הנתונים (DO) לשכבה הלוגית (BO)
        /// </summary>
        /// <param name="c">אוביקט לקוח להמרה משכבת הנתונים</param>
        /// <returns>לקוח מסוכ השכבה הלוגית</returns>
        public static BO.Customer ConvertCustomerToBO(DO.Customer c) => c == null ? throw new Bl_ObjectIsNull("The customer object is null") : new BO.Customer(c.Id, c.Name, c.Address, c.Phone);


        /// <summary>
        /// המרת מוצר מהשכבה הלוגית (BO) לשכבת הנתונים (DO)
        /// </summary>
        /// <param name="c">אוביקט מוצר להמרה מהשכבה הלוגית</param>
        /// <returns>מוצר מסוג שכבת הנתונים</returns>
        public static DO.Product ConvertProductToDO(BO.Product p) => p == null ? throw new Bl_ObjectIsNull("The product object is null") : new DO.Product(p.Id, p.ProductName, (DO.Category)p.Category ,p.Price, p.QuantityInStock);

        /// <summary>
        /// המרת מוצר משכבת הנתונים (DO) לשכבה הלוגית (BO)
        /// </summary>
        /// <param name="c">אוביקט מוצר להמרה משכבת הנתונים</param>
        /// <returns>מוצר מסוג השכבה הלוגית</returns>
        public static BO.Product ConvertProductToBO(DO.Product p) => p == null ? throw new Bl_ObjectIsNull("The product object is null") : new BO.Product(p.Id, p.ProductName, (BO.Category)p.Category, p.Price, p.QuantityInStock);

        /// <summary>
        /// המרת מבצע מהשכבה הלוגית (BO) לשכבת הנתונים (DO)
        /// </summary>
        /// <param name="c">אוביקט מבצע להמרה מהשכבה הלוגית</param>
        /// <returns>מבצע מסוג שכבת הנתונים</returns>
        public static DO.Sale ConvertSaleToDO(BO.Sale s) => s == null ? throw new Bl_ObjectIsNull("The sale object is null") : new DO.Sale(s.Code, s.ProductId, s.MinQuantity, s.Price, s.InClab, s.BeginSale, s.EndSale);

        /// <summary>
        /// המרת מבצע משכבת הנתונים (DO) לשכבה הלוגית (BO)
        /// </summary>
        /// <param name="c">אוביקט מבצע להמרה משכבת הנתונים</param>
        /// <returns>מבצע מסוג השכבה הלוגית</returns>
        public static BO.Sale ConvertSaleToBO(DO.Sale s) => s == null ? throw new Bl_ObjectIsNull("The sale object is null") : new BO.Sale(s.Code, s.ProductId, s.MinQuantity, s.Price, s.InClab, s.BeginSale, s.EndSale);


        /// <summary>
        /// המרת פילטר מהשכבה הלוגית (BO) לפילטר בשכבת הנתונים (DO)
        /// </summary>
        /// <param name="boFilter">פילטר להמרה מהשכבה הלוגית</param>
        /// <returns>פילטר מסוג שכבת הנתונים</returns>
        public static Func<DO.Customer, bool> ConvertFilterCustomerBOtoDO(Func<BO.Customer, bool> boFilter)
        {
            return doCustomer => boFilter(BO.Tools.ConvertCustomerToBO(doCustomer));
        }

        /// <summary>
        /// המרת פילטר מהשכבה הלוגית (BO) לפילטר בשכבת הנתונים (DO)
        /// </summary>
        /// <param name="boFilter">פילטר להמרה מהשכבה הלוגית</param>
        /// <returns>פילטר מסוג שכבת הנתונים</returns>
        public static Func<DO.Product, bool> ConvertFilterProductBOtoDO(Func<BO.Product, bool> boFilter)
        {
            return doProduct => boFilter(BO.Tools.ConvertProductToBO(doProduct));
        }

        /// <summary>
        /// המרת פילטר מהשכבה הלוגית (BO) לפילטר בשכבת הנתונים (DO)
        /// </summary>
        /// <param name="boFilter">פילטר להמרה מהשכבה הלוגית</param>
        /// <returns>פילטר מסוג שכבת הנתונים</returns>
        public static Func<DO.Sale, bool> ConvertFilterSaleBOtoDO(Func<BO.Sale, bool> boFilter)
        {
            return doSale => boFilter(BO.Tools.ConvertSaleToBO(doSale));
        }


    }
}
