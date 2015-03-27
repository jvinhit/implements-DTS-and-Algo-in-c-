using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void LinkedList()
        {
            LinkedList test = new LinkedList();
            test.add(1);
            test.add(2);
            test.add(3);
            test.add(4);
            test.add(5);
            test.add(6);
            test.add(7);
            test.add(8);
            //
            Console.WriteLine("Danh sach ban dau:\n");
            test.printter(test.Head);
            //sau khi insert vao sau vi tri index
            Console.WriteLine("\nSau khi chen 10 vao vi tri so 2 :");
            test.insert(10, 2);
            test.printter(test.Head);
            //test.insertInFront(test.Head,10);
            //test.printter(test.Head);
            //Console.WriteLine();
        }
        static void Main(string[] args)
        {
            LinkedList();

        }
    }
}
