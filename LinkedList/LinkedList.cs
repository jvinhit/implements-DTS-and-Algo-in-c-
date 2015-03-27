using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        private Node head;
        private int size;
        public LinkedList()
        {
            this.head = null;
            this.size = 0;
        }
        public Node Head
        {
            get
            {
                return this.head;
            }
            set
            {
                this.head = value;
            }
        }
        // insert in front linked list
        public Node insertInFront(Node head, object Data)
        {
            Node newNode = new Node(Data);
            newNode.Next = head;
            this.head = newNode;
            this.size++;
            return head;
        }
        // add newnode in the end of linked list
        public void add(Object data)
        {
            Node newNode = new Node(data);
            if (head == null)
            {
                head = newNode;
                this.size++;
            }
            else
            {
                Node current = head;
                while (current.Next != null)
                {
                    current = current.Next;
                }
                current.Next = newNode;
                this.size++;
            }
        }
        // Insert new node after index
        public void insert(Object data, int index)
        {
            Node newNode = new Node(data);
            if (index <= 0)
                Console.WriteLine("Invalid index");
            else if (index > size)
            {
                this.add(data);
            }
            else
            {
                Node current = head;
                Node temp = null;
                for (int i = 0; i < index && current != null; i++)
                {
                    current = current.Next;
                }
                temp = current;
                current = current.Next;
                temp.Next = newNode;
                newNode.Next = current; this.size++;

            }
        }
        public Object get(int index)
        {

            if (index <= 0 || index > this.size)
            {
                return null;
            }
            Node current = head;
            for (int i = 0; i < index; i++)
            {
                current = current.Next;
            }
            return current.Val;
        }

        public void printter(Node node)
        {
            Console.Write("[ ");
            while(node!=null)
            {
                Console.Write(node.Val + " ");
                node = node.Next;
            }
            Console.Write(" ]");
        }
    }
}
