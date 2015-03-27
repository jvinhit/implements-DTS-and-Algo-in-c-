using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Giải thuật tìm kiếm tuyến tính : 
/*Đánh giá : 
 * Tốt nhất : phan tử đầu mảng  =1 
 * Xấu nhất : x = phần tử cuối mảng
 * Trung bình : Phần tử giữa mảng
 * Độ phức tạp : t(n) = O(n)
 * 
*/
namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            char ch;
            Console.WriteLine("Nhap so phan tu cua mang: ");
            n = int.Parse(Console.ReadLine());
            int[] a = new int[n];
            nhapmang(a, n);
            xuatMang(a);

            do
            {

                int x;
                Console.WriteLine("Nhap phan tu can tim kiem: ");
                x = int.Parse(Console.ReadLine());
                if (LinearSearch(a, x) != -1)
                {
                    Console.WriteLine("Tim thay x o {0}", LinearSearch(a, x));
                }
                else
                    Console.WriteLine("Khong tim thay");
                Console.WriteLine("Muon tim tiep khong ? (y/n):");
                ch = char.Parse(Console.ReadLine());

            }
            while (ch == 'y' || ch == 'Y');


        }

        static void nhapmang(int[] a, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("Phan tu a[{0}]= ", i);
                a[i] = Convert.ToInt32(Console.ReadLine());
            }
        }
        static void xuatMang(int[] a)
        {
            foreach (int i in a)
            {
                Console.Write("{0}  ", i);
            }
            Console.WriteLine();
        }
        static int LinearSearch(int[] a, int x)
        {
            int i = 0;
            while (a[i] != x && i < a.Length)
            {
                i++;
            }
            if (i == a.Length)
                return -1;
            else
                return i;
            // end cach 1 ( trong vong lap While se phai dung 2 phep so sanh => chuong trinh se chay cham hon)
            // Cach 2 : su dung phan tu linh canh: 
            //int i = 0;
            //a[a.Length] = x;

            //while(a[i] != x)
            //{
            //    i++;
            //}
            //if (i == a.Length)
            //{
            //    return
            //        -1;
            //}
            //else
            //    return i;
        }
    }

}
