using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    the number of bits required convert numberA to numberB.
 */
namespace bitSwapRequired
{
    class bitSwaprequired
    {
        public static int bitSwap(int a,int b)
        {
            int count= 0 ;
            
            for(int c= a^b; c!=0;c&= c-1)
            {
                count++;
            }
            return count;

        }
        public static void Main()
        {
            Console.WriteLine("Bit Swap: ");
            Console.WriteLine(bitSwap(0, 20));
        }
    }
}
