using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Node
    {
        Object val;
        Node next;
        public Node(Object val)
        {
            this.val = val;
            next = null;
        }
       
        public Object Val
        {
            get
            {
                return this.val;
            }
            set
            {
                this.val = value;
            }
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }  
    }
}
