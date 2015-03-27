using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoArray
{
    class Program
    {
        // Sorted List Example
        public static void EXSRT()
        {
            SortedList st = new SortedList();
            st.Add(5, "Vinh");
            st.Add(1, "Thuy");
            st.Add(2, "Minh");
            st.Add(3, "Truyen");
            Console.WriteLine("- Key\tValue\t");
            for (int i = 0; i < st.Count; i++)
            {
                Console.WriteLine(st.GetKey(i) + "\t" + st.GetByIndex(i));

            }
        }
        public static int KthSmallest(int[] a, int k)
        {
            SortedList list = new SortedList();
            int m = a.Length - k + 1;
            //Console.WriteLine("Gia tri cua m: {0}", m);
            for (int i = 0; i < m; i++)
                list.Add(a[i], null); // list sẽ add các key là 
            //for (int i = 0; i < list.Count; i++ )
            //{
            //    Console.WriteLine(list.GetKey(i) + "\t" + list.GetByIndex(i));
            //}
                for (int i = m; i < a.Length; i++)
                {
                    if ((int)list.GetKey(0) < a[i])
                    {
                        list.RemoveAt(0);
                        list.Add(a[i], null);
                    }
                }
            return (int)list.GetKey(0);
        }
        /// <summary>
        /// Given an unsorted array and N, find two elements in the array with sum N
        /// </summary>
        /// <param name="a"></param>
        /// <param name="n"></param>
        /// <returns></returns>
        /// 
        public static int num1;
        public static int num2;
        public static bool timTong2sobangN(int[] a, int n)
        {
            if (a.Length < 2)
                return false;
            Array.Sort(a);
            int p1 = 0; 
            int p2 = a.Length - 1;
            while(a[p1] + a[p2]!= n)
            {
                if ((a[p1] + a[p2] < n) && ((p1 + 1) < p2)) 
                    p1++;
                else if ((a[p1] + a[p2] > n) && ((p1 + 1) < p2))
                    p2--;
                else
                    return false;
            }
            // found it
            num1 = a[p1];
            num2 = a[p2];
            return true;
        }

        public static void testTimTong2SobangN()
        {
            int[] a = { 2, 4, 7, 11, 15 };
            num1 = num2 = 0;
            bool result = timTong2sobangN(a, 22);
            Console.WriteLine(result);
            Console.WriteLine(num1 + " " + num2);
        }
        static void Main(string[] args)
        {
            //int[] a = { 1,2,13,4,15,3,7,8,9,10};
            //Console.WriteLine("Mang A Ban dau : ");
            //for (int i = 0; i < a.Length; i++ )
            //{
            //    Console.Write("{0}  ", a[i]);
            //}
            //Console.WriteLine("\nSo phan tu cua mang A ban dau : {0}", a.Length);
            //Console.WriteLine(KthSmallest(a, 5));
            //EXSRT();

            //TimTong2So
            testTimTong2SobangN();
        }
    }
}
