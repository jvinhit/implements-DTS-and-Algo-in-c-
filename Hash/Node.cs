using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public class Node
    {
        private int key;
        private string values;
        public Node(int key, string value)
        {
            this.key = key;
            this.values = value;
        }
        public int Key
        {
            get
            {
                return key;
            }
            set
            {
                key = value;
            }

        }
        public string Value 
        { 
            get
            {
                return values;

            }
            set
            {
                values = value;
            }
        }

    }
}
