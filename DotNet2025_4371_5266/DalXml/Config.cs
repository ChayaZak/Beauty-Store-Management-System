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
        private const string? data_config = "C:\\Users\\user1\\Documents\\שנה ב\\C#\\my project\\project_c-\\DotNet2025_4371_5266\\xml\\data-config.xml";


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
