using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dal
{
    internal static class Config
    {
        private const string? data_config = "data-config";

		public static int ProductCode=>int.Parse(XmlTools.GetValueByName("ProductMinCode"))+1;

        public static int SaleCode => int.Parse(XmlTools.GetValueByName("SaleMinCode"))+1;


        public static string? DataConfig
        {
            get
            {
                return data_config;
            }
        }
    }
}
