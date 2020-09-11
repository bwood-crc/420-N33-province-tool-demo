using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProvinceLibrary
{
    public class ProvinceTool
    {
        static Dictionary<string, string> provinces = new Dictionary<string, string>();

        private static void initialize()
        {
            provinces.Add("QC", "Québec");
            provinces.Add("ON", "Ontario");
            provinces.Add("BC", "British Columbia");
            provinces.Add("AB", "Alberta");
        }

        public static string getProvinceName(string provinceCode)
        {
            if (provinces.Count == 0)
            {
                initialize();
            }

            return provinces[provinceCode.Trim().ToUpper()];
        }

        public static bool validProvinceCode(string provinceCode)
        {
            if (provinces.Count == 0)
            {
                initialize();
            }

            return provinces.ContainsKey(provinceCode.Trim().ToUpper());
        }
    }
}
