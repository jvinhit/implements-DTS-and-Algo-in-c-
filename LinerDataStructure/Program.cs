using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinerDataStructure
{
    class Program
    {
        static List<int> GetPrimes(int start , int end)
        {
            List<int> primeList = new List<int>();
            for(int  num= start;  num <= end; num++)
            {
                bool prime = true;
                for(int  div  = 2 ; div <= Math.Sqrt(num) ; div++)
                {
                    if (num % div == 0)
                    {
                        prime = false;
                        break;
                    }
                }
                if(prime)
                {
                    primeList.Add(num);
                }
            }
            return primeList;

        }
        static void Main(string[] args)
        {
            List<int> listSNT = GetPrimes(2, 2000);
            foreach (var n in listSNT)
            {
                Console.WriteLine("SNT: {0}", n);
            }
            Console.WriteLine(Math.Sqrt(10));
        }
    }
}
