using DalApi;

namespace Dal
{
    /// <summary>
    /// מחלקה לניהול שכבת הנתונים (DAL) באמצעות רשימות
    /// המחלקה מממשת את הממשק IDal ומשתמשת בתבנית Singleton
    /// </summary>
    internal sealed class DalList : IDal
    {
        /// <summary>
        /// המופע היחיד של המחלקה (Singleton)
        /// </summary>
        private static readonly DalList instance = new DalList();

        /// <summary>
        /// תכונה סטטית להחזרת המופע היחיד של המחלקה
        /// </summary>
        public static DalList Instance
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
        private DalList() { }
    }
}
