using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASMD
{
    class Program
    {
        public static int add(int x, int y)
        {
            int a, b = 0;
            do
            {
                a = x & y;
                b = x ^ y;
                x = a << 1;
                y = b;
            } while (a != 0);
            return b;
        }
        static void Main(string[] args)
        {
            int addbitkq = add(15,20);
            Console.WriteLine(addbitkq);
        }

    }
}
