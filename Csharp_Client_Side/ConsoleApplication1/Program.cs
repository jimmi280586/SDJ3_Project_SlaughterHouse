using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Client_one;
using System.Runtime.Serialization.Formatters.Soap;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            IJSimpCalcWebService web = new IJSimpCalcWebService();
            Console.Write(web.addition());
            Console.ReadKey();
        }
    }
}
