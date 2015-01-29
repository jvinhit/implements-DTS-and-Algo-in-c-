using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Random_Number_Listmaker
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter amount of numbers to generate: ");
            //    int amountofNumberGenerate = Convert.ToInt32(Console.ReadLine()); // int.Parse (Console.REadLine);
            //    Console.WriteLine("Enter Maximum value: ");
            //    int maxValue = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine("Enter file path and name: ");
            //    string path = Console.ReadLine();
            //    Random rng = new Random();
            //    try
            //    {
            //        if(path==string.Empty)
            //        {
            //            StreamWriter sw = new StreamWriter(path);
            //            for(int i = 0 ; i <amountofNumberGenerate; i++)
            //            {
            //                sw.WriteLine(rng.Next(maxValue));

            //            }
            //        }
            //        else
            //        {
            //            StreamWriter fileWriter = new StreamWriter("random.txt");
            //            for (int i = 0; i < amountofNumberGenerate; i++)
            //            {
            //                fileWriter.WriteLine(rng.Next(maxValue).ToString());
            //            }
            //        }


            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("An error occured\n" + e);
            //    }
            //}



            //Console.Write("Amount of numbers to be generated: ");
            //int amount = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Max: ");
            //int max = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Min: ");
            //int min = Convert.ToInt32(Console.ReadLine());
            //StreamWriter writer = new StreamWriter("random.txt");
            //Random rng = new Random();
            //for (int i = 0; i < amount; i++)
            //{
            //    int output = rng.Next(min, max);
            //    writer.WriteLine(output.ToString());
            //}
            //writer.Close();


            // Qua troi tam giac
            //int sz = 10;
            //for (int i = 0; i < sz; i++)
            //{
            //    for (int j = 0; j < (sz * 4); j++)
            //    {
            //        if (j <= i || (j >= sz && j <= (sz * 2) - (i + 1))
            //        || (j >= sz * 2 && j >= (sz * 2) + i && j < sz * 3)
            //        || (j >= (sz * 4) - (i + 1))
            //        )
            //        {
            //            Console.Write("*");
            //        }
            //        else { Console.Write(" "); }
            //    }
            //    Console.WriteLine();
            //}
            // dang 1
            
            //int chieucao= Convert.ToInt32(Console.ReadLine());

            //for (int i =1 ; i <= chieucao; i++)
            //{
            //    for(int j=i ; j <= chieucao -1 ;j++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for(int so = 1; so<= i*2 -1; so++)
            //    {

            //        Console.Write("{0,1}",so);
            //    }
            //    Console.WriteLine();

            //}

            // in hinh chu nhat ben trong khong co dau *
            string hoten = "Nguyen Van Vinh";
            string MSSV = "10110139";
            string noisinh = "Bac giang";
            int chieucao = 3;
            int chieurong = hoten.Length +2;
            for (int i = 0; i < chieucao; i++)
            {
                if(i == 0 || i == chieucao-1)
                {
                    for(int j = 0; j < chieurong; j++)
                    {
                        Console.Write("*");
                    }
                    
                }
                   
                else
                {
                    for (int j = 0; j < chieurong; j++)
                    {
                        if (j == 0 || j == chieurong - 1)
                        {
                            Console.Write("*");
                        }
                        else
                            Console.Write("*");
                    }

                }
                Console.WriteLine();

            }

        }
    }
}
