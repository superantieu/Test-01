using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("nhap vao thang ban muon hien thi: ");
            int soThang = int.Parse(Console.ReadLine());
            switch (soThang)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:

                    Console.WriteLine("Thang {0} gom co cac ngay nhu sau:", soThang);
                    for (int i = 1; i <= 31; i++)
                        Console.Write("{0} ", i);
                    break;
                case 2:
                    Console.WriteLine("Thang {0} gom co cac ngay nhu sau:", soThang);
                    for (int i = 1; i <= 28; i++)
                        Console.Write("{0} ", i);
                    break;
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("Thang {0} gom co cac ngay nhu sau:", soThang);
                    for (int i = 1; i <= 30; i++)
                        Console.Write("{0} ", i);
                    break;
                default:
                    Console.WriteLine("Thang ban nhap khong hop le");
                    break;

            }
            Console.ReadKey();
        }
    }
}
