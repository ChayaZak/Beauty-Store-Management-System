using DalApi;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalXml :IDal
    {
        /// <summary>
        /// המופע היחיד של המחלקה (Singleton)
        /// </summary>
        private static readonly DalXml instance = new DalXml();

        /// <summary>
        /// תכונה סטטית להחזרת המופע היחיד של המחלקה
        /// </summary>
        public static DalXml Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// תכונה לניהול מוצרים
        /// </summary>
        public IProduct Product => new ProductImplementation();

        /// <summary>
        /// תכונה לניהול מבצעים
        /// </summary>
        public ISale Sale => new SaleImplementation();

        /// <summary>
        /// תכונה לניהול לקוחות
        /// </summary>
        public ICustomer Customer => new CustomerImplementation();

        /// <summary>
        /// בנאי פרטי למניעת יצירת מופעים נוספים
        /// </summary>
        private DalXml() { }
    }
}
