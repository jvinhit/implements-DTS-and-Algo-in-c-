using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hash
{
    public interface HasHTable
    {
        // put key/value pair into the table
        public void put(int key, string value);
        //get value pair with key , return null if hash don't contains key
        public string get(int key);
        // remove key from table ( dis moe tat nhien la remove ca value) 
        public void delete(int key);
        // Tra ve true neu ton tai key, va false neu otherwise
        public bool contains(int key);
        // return size of table
        public int size();

        // return int collistion in table
        public int collisions();
        // All key in table
        IEnumerable<int> keys();
    }

}
