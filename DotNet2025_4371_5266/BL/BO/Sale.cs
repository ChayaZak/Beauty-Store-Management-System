using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        /// <summary>
        /// קוד מבצע
        /// </summary>
        public int Code { get; set; }

        /// <summary>
        /// מזהה המוצר
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// כמות מינימלית
        /// </summary>
        public int MinQuantity { get; set; }

        /// <summary>
        /// מחיר המבצע
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// האם המבצע מיועד ללקוחות מועדון בלבד
        /// </summary>
        public bool InClab { get; set; }

        /// <summary>
        /// תאריך התחלת המבצע
        /// </summary>
        public DateTime BeginSale { get; set; }

        /// <summary>
        /// תאריך סיום המבצע
        /// </summary>
        public DateTime EndSale { get; set; } 

        /// <summary>
        /// בנאי ריק
        /// </summary>
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

        /// <summary>
        /// בנאי עם פרמטרים
        /// </summary>
        /// <param name="code">קוד מבצע</param>
        /// <param name="productId">קוד מוצר</param>
        /// <param name="minQuantity">כמות מינימלית</param>
        /// <param name="price">מחיר</param>
        /// <param name="inClab">האם הלקוח הוא לקוח מועדף</param>
        /// <param name="beginSale">תאריך התחלת המצבע</param>
        /// <param name="endSale">תאריך סיום המבצע</param>
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
