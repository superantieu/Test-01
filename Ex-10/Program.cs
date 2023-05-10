using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            int no1 = 0;
            int no2 = 1;
            Console.WriteLine("Day Fibonaci cua {0} so nguyen dau tien la:", n);
            if (n == 1) 
            {
                Console.Write(no1);
            }
            else if (n == 2)
            {
                Console.Write("{0}, {1}", no1, no2);
            }
            else
            {
                Console.Write("0   1   ");
                for (int i = 3; i <= n; i++)
                {
                    int noFi = no1 + no2;
                    no1 = no2;
                    no2 = noFi;
                    Console.Write("{0}   ",noFi);
                }
            }


            Console.ReadKey();
        }
    }
}
