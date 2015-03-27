using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleLinkedListImple
{
    
    // Node preresent Node in Linked List. This class contains the data member  and next node
    class Node
    {
        public int rollNumber;
        public string name;
        public Node next; // NextNode 
    }
    class List
    {
        Node START;
        public List()
        {
            START = null;
        }
        // add Node in the list
        public void addNode()
        {
            int rollNo;
            string nm;
            Console.WriteLine("\nEnter the roll No of student: ");
            rollNo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nEnter the Name of student: ");
            nm = Console.ReadLine();
            Node newnode = new Node();
            newnode.rollNumber = rollNo;
            newnode.name = nm;
            // if node to be inserted is the first node:
            if(START == null || rollNo <= START.rollNumber)
            {
                if(START != null && rollNo == START.rollNumber)
                {
                    Console.WriteLine("\nDuplicate roll numbers not allowed");
                    return;
                }
                newnode.next = START;
                START = newnode;
                return;
            }
            /*Locate the position of the new node in the list*/
            Node previous, current;
            previous = START;
            current = START;
            while(current!= null && rollNo>= current.rollNumber)
            {

            }
           
        }
    }
}
