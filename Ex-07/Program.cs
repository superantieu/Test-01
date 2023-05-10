using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
           int S = 0;
            for (int i = 1; i <= n; i += 2) 
            {
                S += i;
            }
            Console.WriteLine("Tong so le tu 1 den {0} la : {1}", n, S);
            Console.ReadKey();
        }
    }
}
