using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseString
{
    /*Requirement: 
     input : nguyen van
     output: nav neyugn*/
    class ReverseString
    {
        static void Reversestring (char[] str)
        {
            // dap mgipc cjipo 
            int start = 0 ;
            int end = str.Length -1;
            char tmp; 
            while(start <= end)
            {
                tmp = str[start];
                str[start++] = str[end];
                str[end--] = tmp;
                
            }


        }
        static void Main(string[] args)
        {
            string s = "I love you";
            char[] dantri = s.ToCharArray();
            Reversestring(dantri);
            Console.WriteLine(dantri);
            foreach(char s1 in dantri)
            {
                Console.WriteLine(s1);
            }
            string s2 = new string (dantri); // Convert char array to string
            Console.WriteLine(s2 is string);
            Console.WriteLine(s2);
            string s3 = String.Concat(s2, "Vinh");
            Console.WriteLine(s3);

            int separte = 15;
            for ( int i = 0; i < separte ; i++)
            {
                Console.Write("-");

            }

            Console.WriteLine();

            string source1 = "  Nguyen hoang mai thao   ";
            string source2 = "Duong thi xuan thuy";
            string source3 = "Nguyen Vann";
            Console.WriteLine("String Source: -" + source1);
            Console.WriteLine("ToUpper: -" + source1.ToUpper());
            Console.WriteLine("ToLower: -" + source1.ToLower());
            Console.WriteLine("Compare source1 and source2:  ");
            int kq = String.Compare(source1, source3);
            Console.WriteLine(kq);
            Console.WriteLine(source3.Length.CompareTo(source1.Length));
            // Dem so ki tu a
            Console.WriteLine(source1.Count(s22 => s22 == 'a'));
            // Dung indexof de tim kiem chuoi hay char roi tra ve vi tri
            //
            Console.WriteLine("Tim thay n o vi tri  "+ source3.IndexOf('n',0));
            // Split de cat string ra thanh mang string theo para truyen vao
            string sourcetrim = source1.Trim();
            string[] mangstring = sourcetrim.Split(new char[] { ' ' });
            string vinh = string.Empty;
            foreach(string scc in mangstring)
            {
                vinh += scc;
            }
            Console.WriteLine(mangstring.Length);
            Console.WriteLine(vinh);
            

            /// Su dung StartWith : 
            /// 
            Console.WriteLine(source3.StartsWith("NG",StringComparison.OrdinalIgnoreCase));
            // Endwith
            Console.WriteLine(source3.EndsWith("n", StringComparison.OrdinalIgnoreCase));
            // Su dung join 2 mang string theo ki tu
            Console.WriteLine(String.Join("_ConCAC_", source3.Split(' ')));
            Console.WriteLine(source3.GetTypeCode());



        }
    }
}
