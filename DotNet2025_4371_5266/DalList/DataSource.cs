using DO;
namespace DO;

/// <summary>
/// מקור נתונים פנימי.
/// </summary>
internal static class DataSource
{
    internal static List<Product?> Products = new List<Product?>();
    internal static List<Customer?> Customers = new List<Customer?>();
    internal static List<Sale?> Sales = new List<Sale?>();

    internal static class Config
    {
        internal const int ProductMinCode = 100;
        internal const int SaleMinCode = 200;

        private static int ProductIndex = ProductMinCode;
        private static int SaleIndex = SaleMinCode;

        /// <summary>
        /// קוד המוצר הבא
        /// </summary>
        public static int ProductCode
        {
            get
            {
                return ProductIndex++;
            }
        }

        /// <summary>
        /// קוד המבצע הבא
        /// </summary>
        public static int SaleCode
        {
            get
            {
                return SaleIndex++;
            }
        }
    }
}


