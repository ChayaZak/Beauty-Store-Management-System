using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {

        public int Code { get; set; }


        public int ProductId { get; set; }


        public int MinQuantity { get; set; }


        public double Price { get; set; }


        public bool InClab { get; set; }


        public DateTime BeginSale { get; set; }


        public DateTime EndSale { get; set; } 


        public Sale()
        {
            Code = 0;
            ProductId = 0;
            MinQuantity = 0;
            Price = 0;
            InClab = false;
            BeginSale = DateTime.Now;
            EndSale = DateTime.Now;
        }


        public Sale(int code, int productId, int minQuantity, double price, bool inClab, DateTime beginSale, DateTime endSale)
        {
            Code = code;
            ProductId = productId;
            MinQuantity = minQuantity;
            Price = price;
            InClab = inClab;
            BeginSale = beginSale;
            EndSale = endSale;
        }
        public override string? ToString() => Tools.ToStringProperty(this);
    }
}
