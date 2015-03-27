using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResizeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new[] { 1, 2, 3, 4, 5 };
            int[] temp = new int[array.Length + 1];
            //for (int i = 0; i < array.Length;i++ )
            //{
            //    temp[i] = array[i];
            //}
            //array = temp;
            
            /// OR Array.Resize
            /// 
            //Array.Copy(array, temp, array.Length);
            Array.Resize(ref array, 6);
            array[5] = 6;
        }
    }
}
