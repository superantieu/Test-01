using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("So nguyen to tu 1 den {0} la: ", n);
            for (int i = 2; i <= n; i++) 
            {
                int uoc = 0;
                for (int j = 1; j <= i; j++)
                {
                    if(i % j == 0)
                    {
                        uoc++;
                    }

                }
                
                if (uoc == 2)
                {

                Console.Write("{0} ", i);
                }
            }

            Console.ReadKey();

        }
    }
}
