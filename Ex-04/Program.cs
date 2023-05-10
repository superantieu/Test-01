using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao so nguyen n: ");
            int n = int.Parse(Console.ReadLine());
            string x = "khong phai so chinh phuong";
           
            if (Math.Sqrt(n) - (int)Math.Sqrt(n) == 0)
            { x = "la so chinh phuong"; }
            Console.WriteLine("so ban vua nhap {0}", x);
            Console.ReadKey();

        }
    }
}
