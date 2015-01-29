using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            Tree tree = new Tree();
            Node node = tree.Create();
            Console.WriteLine("In Order");
            tree.PrintInOrder(node);
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Post Order");
            tree.PrintPostOrder(node);
            Console.WriteLine();
            Console.WriteLine();
            
            Console.WriteLine("Pre Order");
            tree.PrintPreOrder(node);

        }
    }
}
