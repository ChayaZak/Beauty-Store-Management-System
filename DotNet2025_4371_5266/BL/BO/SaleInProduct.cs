using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{

    public class SaleInProduct
    {

        public int SaleId { get; set; }
       

        public int QuantityForSale { get; set; }
       

        public double SalePrice { get; set; }


        public bool IsForAllCustomers { get; set; } 


        public SaleInProduct() { }


        public SaleInProduct(int saleId, int quantityForSale, double salePrice, bool isForAllCustomers)
        {
            SaleId = saleId;
            QuantityForSale = quantityForSale;
            SalePrice = salePrice;
            IsForAllCustomers = isForAllCustomers;
        }


        public override string? ToString() => Tools.ToStringProperty(this);
    }
}
