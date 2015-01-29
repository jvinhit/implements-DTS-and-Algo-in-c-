using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace StackImp
{
    class iStack
    {

        public Node top;
        private int count;
        public iStack()
        {
            top = null;
            count = 0;
        }
        public int size()
        {
            return count;
        }
        public bool isEmpty()
        {
            return top == null;
        }
        public  void push(Object data)
        {
            Node newNode = new Node(data);
            newNode.Next = top;
            top = newNode;
            count++;
        }
        public object pop()
        {
            if (top == null) // stack rong
                return null;
            Object value = top.Data;
            top = top.Next;
            count--;
            return value;
        }
        public object peek()
        {
            return top.Data;
        }
        public void print(Node top)
        {
            Console.WriteLine("Stack is");
            while(top!= null)
            {
                Console.WriteLine("| {0,2} |",top.Data);
                top = top.Next;
            }
        }
    }
}
