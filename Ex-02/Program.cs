using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Nhap vao so nguyen n: (n > 1 va n < 10)");
            int n = int.Parse(Console.ReadLine());
           
            for (int i = 2; i <= n; i++)
            {
                Console.WriteLine("Bang cuu chuong {0} la: ", i);
                for (int j = 1; j < 10; j++)
                {
                    
                    Console.WriteLine("{0} x {1} = {2}", i, j, i * j);
                }    
            }
            
            Console.ReadKey();


        }
    }
}
