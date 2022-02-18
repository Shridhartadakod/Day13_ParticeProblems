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

            Console.WriteLine("Integer test");
            TestCase.IntTest();

            Console.WriteLine("Float test");
            TestCase.FloatTest();

            Console.WriteLine("String test");
            TestCase.StringTest();

            Console.ReadKey();


        }
    }
}
