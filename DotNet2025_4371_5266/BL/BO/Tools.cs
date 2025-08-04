using System;
using System.Linq;
using System.Text;

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


        public static DO.Customer ConvertCustomerToDO(BO.Customer c) => c == null ? throw new Bl_ObjectIsNull("The customer object is null") : new DO.Customer(c.Id, c.Name, c.Address, c.Phone);


        public static BO.Customer ConvertCustomerToBO(DO.Customer c) => c == null ? throw new Bl_ObjectIsNull("The customer object is null") : new BO.Customer(c.Id, c.Name, c.Address, c.Phone);


        public static DO.Product ConvertProductToDO(BO.Product p) => p == null ? throw new Bl_ObjectIsNull("The product object is null") : new DO.Product(p.Id, p.ProductName, (DO.Category)p.Category, p.Price, p.QuantityInStock);


        public static BO.Product ConvertProductToBO(DO.Product p) => p == null ? throw new Bl_ObjectIsNull("The product object is null") : new BO.Product(p.Id, p.ProductName, (BO.Category)p.Category, p.Price, p.QuantityInStock);


        public static DO.Sale ConvertSaleToDO(BO.Sale s) => s == null ? throw new Bl_ObjectIsNull("The sale object is null") : new DO.Sale(s.Code, s.ProductId, s.MinQuantity, s.Price, s.InClab, s.BeginSale, s.EndSale);


        public static BO.Sale ConvertSaleToBO(DO.Sale s) => s == null ? throw new Bl_ObjectIsNull("The sale object is null") : new BO.Sale(s.Code, s.ProductId, s.MinQuantity, s.Price, s.InClab, s.BeginSale, s.EndSale);



        public static Func<DO.Customer, bool> ConvertFilterCustomerBOtoDO(Func<BO.Customer, bool> boFilter)
        {
            return doCustomer => boFilter(BO.Tools.ConvertCustomerToBO(doCustomer));
        }


        public static Func<DO.Product, bool> ConvertFilterProductBOtoDO(Func<BO.Product, bool> boFilter)
        {
            return doProduct => boFilter(BO.Tools.ConvertProductToBO(doProduct));
        }


        public static Func<DO.Sale, bool> ConvertFilterSaleBOtoDO(Func<BO.Sale, bool> boFilter)
        {
            return doSale => boFilter(BO.Tools.ConvertSaleToBO(doSale));
        }


    }
}
