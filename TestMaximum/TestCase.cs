using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestMaximum
{
    internal class TestCase
    {
        private static readonly int[] intTestCase1;
        private static readonly int[] intTestCase2;
        private static readonly int[] intTestCase3;
        private static readonly float[] floatTestCase1;
        private static readonly float[] floatTestCase2;
        private static readonly float[] floatTestCase3;

        static TestCase()
        {
            intTestCase1 = new int[] { 1, 2, 3, };
            intTestCase2 = new int[] { 0, 2, 3 };
            intTestCase3 = new int[] { 5, 6, 1 };
            floatTestCase1 = new float[] { 1.1f, 2.2f, 3.3f };
            floatTestCase2 = new float[] { 0.0f, 2.2f, 3.3f };
            floatTestCase3 = new float[] { 5.5f, 6.6f, 1.1f };

        }

        public static int[] IntTestCase1 => intTestCase1;
        public static int[] IntTestCase2 => intTestCase2;
        public static int[] IntTestCase3 => intTestCase3;
        public static float[] FloatTestcase1 => floatTestCase1;
        public static float[] FloatTestcase2 => floatTestCase2;
        public static float[] FloatTestcase3 => floatTestCase3;



        public static string GetString<T>(T[] testcase)
        {
            return "[{testCase[0]},{testCase[1]},{testCase[2]}]";

        }

        public static void IntTest()
        {
            Console.WriteLine("Test case 1: " + GetString(intTestCase1));
            Maximum.IntMax(intTestCase1[0], intTestCase1[1], intTestCase1[2]);
            Console.WriteLine("Test case 2: " + GetString(intTestCase2));
            Maximum.IntMax(intTestCase2[0], intTestCase2[1], intTestCase2[2]);
            Console.WriteLine("Test case 3: " + GetString(intTestCase3));
            Maximum.IntMax(intTestCase3[0], intTestCase3[1], intTestCase3[2]);
        }

        public static void FloatTest()
        {
            Console.WriteLine("Test case 1: " + GetString(floatTestCase1));
            Maximum.FloatMax(floatTestCase1[0], floatTestCase1[1], floatTestCase1[2]);
            Console.WriteLine("Test case 2: " + GetString(floatTestCase2));
            Maximum.FloatMax(floatTestCase2[0], floatTestCase2[1], floatTestCase2[2]);
            Console.WriteLine("Test case 3: " + GetString(floatTestCase3));
            Maximum.FloatMax(floatTestCase3[0], floatTestCase3[1], floatTestCase3[2]);


        }
    }
}
