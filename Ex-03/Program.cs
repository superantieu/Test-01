using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            long giaiThua = 1;
            long tongGiaiThua = 0;
            for (int i = 1; i <= n; i++)
            {
                giaiThua *= i;
                tongGiaiThua += giaiThua;
            }
            Console.WriteLine("Tong giai thua tu 1 den {0} la: {1}", n, tongGiaiThua);
            Console.ReadKey();



        }
    }
}
