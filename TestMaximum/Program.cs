using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("======Test Maximum numbers======");

            Console.WriteLine("Integer Tests");
            TestCase.IntTest();

            Console.WriteLine("Float tests");
            TestCase.FloatTest();

            Console.ReadKey();


        }
    }
}
