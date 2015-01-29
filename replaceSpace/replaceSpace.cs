using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replaceSpace
{
    class replaceSpace
    {
        public static void ssss(char[] str, int length)
        {
            int soKT = 0;
            int newLeght;
            int i;
            for (i = 0; i < length; i++)
            {
                if (str[i] == ' ')
                {
                    soKT++;
                }
            }

            newLeght = length + soKT * 2;
            str[newLeght]='\0';
            for (i = length - 1; i >= 0; i--)
            {
                if (str[i] == ' ')
                {
                    str[newLeght - 1] = '0';
                    str[newLeght - 2] = '2';
                    str[newLeght - 3] = '%';
                    newLeght -=3;
                }
                else
                {
                    str[newLeght] = str[i];
                    newLeght -= 1;
                }

            }
        }
        static void Main(string[] args)
        {

            char[] str = new char[100];
            string s = "I love you   ";
            char[] ss = s.ToCharArray();
            for (int i = 0; i < ss.Length; i++)
            {
                str[i] = ss[i];
            }

            ssss(str, s.Length);
            Console.WriteLine(str);

        }
    }
}
