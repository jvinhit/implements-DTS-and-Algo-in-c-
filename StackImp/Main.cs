using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace StackImp
{
    class Mains
    {

        // Sort stack 
        public static Stack<int> sortstack (Stack<int> stack1)
        {
            Stack<int> stack2 = new Stack<int>();
            while(stack1.Count != 0)
            {
                int temp = stack1.Pop();
                while (stack2.Count != 0 && stack2.Peek() > temp)
                {
                    stack1.Push(stack2.Pop());
                }
                stack2.Push(temp);
            }
            return stack2;
        }
       
        public static void Main()
        {
            iStack test = new iStack();
            //test.push(1);
            //test.push(12);
            //test.push(10);
            //test.push(9);
            //test.push(13);
            //test.push(8);
            //test.push(7);
            //test.push(6);
            //test.push(5);
            //// Stack ban dau :
            //test.print(test.top);

            //Console.WriteLine("Dinh stack la : {0}", test.peek());
            //test.pop();
            //Console.WriteLine("POP");
            //test.print(test.top);
            //Console.WriteLine("Dinh stack la : {0}", test.peek());
            test.doicoso(10000, 2);


        }
    }
}
