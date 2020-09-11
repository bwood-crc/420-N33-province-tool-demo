using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProvinceLibrary;

namespace ProvinceToolDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter a province code to get the value of the province >");

                string provinceCode = Console.ReadLine();

                if (ProvinceTool.validProvinceCode(provinceCode))
                {
                    string province = ProvinceTool.getProvinceName(provinceCode);
                    Console.WriteLine(province);
                }
                else
                {
                    Console.WriteLine("Sorry, the province entered was not recognized.");
                }

                Console.WriteLine("***************************************");
            }
        }
    }
}
