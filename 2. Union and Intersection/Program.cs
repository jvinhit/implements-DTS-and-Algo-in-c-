using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.Union_and_Intersection
{
    class Program
    {
        static int[] Union (int[] firstArray, int[] secondArray)
        {
            List<int> union = new List<int>();
            // Thêm tất cả các phần tử của mảng thứ nhất vào list
            union.AddRange(firstArray);
            foreach(int item in secondArray)
            {
                // Nếu có phần tử nào trong mảng thứ 2 chưa có trong list union thì thêm phần tử đó vào list
                if(!union.Contains(item))
                {
                    union.Add(item);
                }
            }
            return union.ToArray();
        }

        static int[] Intersect (int[] firstArray, int[] secondArray)
        {
            List<int> intersect = new List<int>();
            foreach(int item in firstArray)
            {
                if(Array.IndexOf(secondArray,item) != -1)
                {
                    intersect.Add(item);
                }
            }
            return intersect.ToArray();
        }
        static void PrintArray(int[] array)
        {
            Console.Write("{");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
                if (i < array.Length - 1)
                {
                    Console.Write(", ");
                }
            }
            Console.WriteLine("}");
        }
        static void Main(string[] args)
        {

            int[] firstArray = { 1, 2, 3, 4, 5 };
            Console.Write("First Array = ");
            PrintArray(firstArray);

            int[] secondArray = { 2, 4, 6 };
            Console.Write("Second Array = ");
            PrintArray(secondArray);

            int[] unionArray = Union(firstArray, secondArray);
            Console.Write("Union = ");
            PrintArray(unionArray);

            int[] intersectArray = Intersect(firstArray, secondArray);
            Console.Write("Intersect = ");
            PrintArray(intersectArray);
        }
    }
}
