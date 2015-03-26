using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Thuật toán tìm kiếm nhị phận : ( *** Chỉ áp dụng cho những dãy đã sắp xếp)
 * Độ phức tạp của thuật toán là T(n) = O(log 2 (n)) Tiết kiếm thời gian tìm kiếm hơn nhưng tn thời gian sắp xếp dãy nếu dẫy chưa đc xếp
 */
namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {

        }
        static void nhapmang(int [] a, int n)
        {
            for ( int i =0 ; i< n; i++)
            {
                
            }
        }
        // Recursion : đệ quy : 
        // Bài toán tháp hà Nội: 
        /*
         * Bài toán Tháp Hà Nội là bài toán giả sử có 3 chồng đĩa A B C . ở chồng đĩa A gồm nhiều đĩa. Đĩa nhỏ ở trên và đĩa to ở dưới
         * Yêu cầu của bài toán là chuyển các đĩa từ a>c sao cho đúng quy định đĩa nhỏ ở trên và đĩa to ở dưới. 
         * Dùng chồng đĩa B làm chồng đãi trung gian. Ta sẽ làm như sau: 
         *  Chuyển N - 1 đĩa từ A -> B 
         *  Sau đó chuyển đĩa to nhất dưới cùng ( đĩa duy nhất còn lại từ A ) sang C
         *  Sau đó chuyển N -1 đĩa từ B sang C. Bài toán hoàn thành. 
         *  Vậy Đệ quy cc gì ở đây: 
         *      
         */
        static void ThapHaNoi(int n, char cotA, char cotC, char cotB)
        {
            if(n==1) // STOP
            {
                // Chuyen truc tiep 1 dia do tu A → C 
                Console.WriteLine("\nChuyen dia 1 tu cot: {0} den cot - {1}", cotA, cotC);
                return;
            }
            ThapHaNoi(n - 1, cotA, cotB, cotC); // chuyen n  -1 dia tu cot A sang cot B


         
        }

        static int BinarySearch(int[] a, int x)
        {
            int left, right, middle;
            do
            {
                right = 0;
                left = a.Length - 1;
                middle = (left + right) / 2;
                if (a[middle] == x) // tim thay x tai middle ngay
                    return middle;
                else
                {
                    if (x > a[middle])
                        right = middle - 1;
                    else
                        left = middle + 1;
                }
            } while (left <= right);
            return -1;
        }
    }

}
