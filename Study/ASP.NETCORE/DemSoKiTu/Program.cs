using System;

namespace DemSoKiTu
{
    class Program
    {
        static void Main(string[] args)
        {
            string chuoi = "";
            while (chuoi.Length >= 0)
            {
                Console.Write("Vui lòng nhap chuoi : ");
                chuoi = Console.ReadLine();
                int demKiTu = chuoi.Length;
                Console.WriteLine($"{chuoi} co {demKiTu} ki tu");
                Console.ReadKey();
            }

        }
    }
}
