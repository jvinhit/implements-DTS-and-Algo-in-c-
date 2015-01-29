using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseWord
{
    class Program
    {
        public static void ReverseWord(char[] source)
        {
            int tokenRead = source.Length - 1;
            int wordRead, wordEnd;
            int writePos = 0;
            char[] buffer = new char[source.Length];

            while (tokenRead >= 0)
            {

                if (source[tokenRead] == ' ')
                {
                    buffer[writePos] = source[tokenRead];
                    writePos++;
                    tokenRead--;
                }
                else
                {
                    wordEnd = tokenRead;
                    // if want reverse character in word using :
                    // if (tokenRead >= 0 && source[tokenRead] != ' ')
                    // and don't want reverse character using while as below
                    while (tokenRead >= 0 && source[tokenRead] != ' ')
                    {
                        tokenRead--;

                    }
                    wordRead = tokenRead + 1;
                    while (wordRead <= wordEnd)
                    {
                        buffer[writePos] = source[wordRead];
                        writePos++;
                        wordRead++;
                    }

                }
            }
            Array.Copy(buffer, 0, source, 0, source.Length);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("input string : ");

            string source = Console.ReadLine() ;
            char[] sourcearray = source.ToCharArray();
            ReverseWord(sourcearray);
            Console.WriteLine("output: ");
            Console.WriteLine(sourcearray);
        }
    }
}
