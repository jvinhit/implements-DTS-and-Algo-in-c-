using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackImp
{
    // Cấu trúc 1 node trong stack: Thông tin node đó gồm 
    // * Thành phần dữ liệu
    // * Nút tiếp theo
    public class Node
    {

        private Node next;
        private Object data;

        public Node(Object o)
        {
            data = o;
            next = null;
        }

        public Node Next
        {
            get { return this.next; }
            set { this.next = value; }
        }
        public Object Data
        {
            get { return this.data; }
            set { this.data = value; }
        }
    }
}
