using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Lý thuyết : 
 *  Ván đề đệ quy: 
 *      Vấn đề đệ quy được định nghĩa bằng chính nó.
 *      ~> Vấn đề đệ quy được giải thông qua 2 bước : 
 *          • Bước 1 : Phân tích
 *          • Bước 2 : Thế ngược
 *      ~> Một bài toán đệ quy phải thỏa 2 điều kiện: 
 *          • Có tính đê quy
 *          • Không bị gọi đệ quy bất tận ( loop) [phải có điều kiện dựng STOP!]
 * Giải thuật đệ quy chung như sau: 
 *      1. Nếu vấn đề thỏa điều kiện dựng thì :  // dieu kien dung
 *          Gải ván đề trực tiếp
 *      2. Nếu chưa thỏa điều kiện dừng :  // bước đệ quy
 *          Gọi đệ quy để giải quyết vấn đề bằng bài toán đồng dạng.
 */
namespace SumRe
{
    class Program
    {
        // ex Sum with Recursion S= 1 +2 +3 + .. + n
        /*
            - Bước phân tích : 
                Để tính S(n) ta phải tính S(n - 1)
                Sau đó tính S(n) = S(n - 1)  + n
                ...
                S(n - 2) = S(n -3 ) + (n - 2 )
                ... 
                S(1) = 1
            - Bước thế ngược : 
                Có kết qa la S(1) ta thay vào S(2) = S(1) + 2,  S(3)= S(2) + 3.. S(n)
         */
        public static int sum(int n)
        {
            if (n == 1) // Điều kiện dừng (STOP)
                return 1;
            else        // Bước đệ quy
                return (sum(n - 1) + n);  // Goi de quy de tinh s(n -1 ) sau do tra ve s(n - 1 ) + n
        }

        // ex: x^ n 
        public static long TinhMu(int x, int n)
        {
            if (n == 0)// Dieu kien dung
                return 1;
            else
                return (TinhMu(x, n - 1) * x);
        }
        static void Main(string[] args)
        {


            int tong = sum(10);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(tong);


            // x^n if ( x==0 ) not allow
            Console.WriteLine(TinhMu(10, 5));
        }
    }
}
