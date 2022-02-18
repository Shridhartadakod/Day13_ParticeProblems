using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    internal class Maximum<T> where T:IComparable
    {
       /* public static void IntMax(int num1,int num2,int num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
                Console.WriteLine("Max value is :{ num1}");
            else if (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) >= 0)
                Console.WriteLine("Max value is :{num2}");
            else
                Console.WriteLine("Max value is:{num3}");
        }


        public static void FloatMax(float num1,float num2,float num3)
        {
            if (num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) >= 0)
                Console.WriteLine("Max value is :{ num1}");
            else if (num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) >= 0)
                Console.WriteLine("Max value is :{num2}");
            else
                Console.WriteLine("Max value is:{num3}");
        }

        public static void StringMax(string str1,string str2,string str3)
        {
            if (str1.CompareTo(str2) >= 0 && str1.CompareTo(str3) >= 0)
                Console.WriteLine("Max value is :{ str1}");
            else if (str2.CompareTo(str1) >= 0 && str2.CompareTo(str3) >= 0)
                Console.WriteLine("Max value is :{str2}");
            else
                Console.WriteLine("Max value is:{str3}");
        }*/

        public static void Max(T var1,T var2,T var3)
        {
            T[] array = new T[] { var1, var2, var3 };
            Array.Sort(array);
            Console.WriteLine("Max value is: {array[2]}");
        }
    }
}
