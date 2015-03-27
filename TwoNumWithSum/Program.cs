using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoNumWithSum
{
    public class TwoNumSum
    {
        public static int num1;
        public static int num2;
        // find two numbers with given sum in the array
        // return ture if there are found, otherwise false

        public static bool FindTwoNumWithSum(int[] a, int N)
        {
            if (a.Length < 2) return false;
            Array.Sort(a); // 1. sort the array
            int p1 = 0;
            int p2 = a.Length - 1;
            while (a[p1] + a[p2] != N)
            {
                if (a[p1] + a[p2] < N && p1 + 1 < p2) p1++;
                else if (a[p1] + a[p2] > N && p1 + 1 < p2) p2--;
                else return false; // not found
            }
            // found it!
            num1 = a[p1];
            num2 = a[p2];
            Console.WriteLine(num1 +" " + num2);
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 11 };
            Console.WriteLine(TwoNumSum.FindTwoNumWithSum(a, a.Length));
        }
    }
}
