using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("nhap vao so nguyen: ");
            int soNguyen = int.Parse(Console.ReadLine());
            string x = "so khong chia het cho 3";
            if (soNguyen % 3 == 0)
            { x = "so chia het cho 3"; }
            Console.WriteLine("so ban vua nhap la {0}", x);
            Console.ReadKey();
        }
    }
}
