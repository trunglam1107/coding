using System;

using MyLib;

namespace CS006_Method
{
    class Program
    {
        // /// Tính bình phương của số thực double
        // static double BinhPhuong(double number)
        // {
        //     double ketqua = number * number;
        //     return ketqua;
        // }
        static void Main(string[] args)
        {
            // double bp = BinhPhuong(5); // Gọi hàm
            // Console.WriteLine("Binh phuong cua 5 la : " + bp);

            // CS006.XinChao();
            // CS006.XinChao();
            // CS006.XinChao();

            // Console.WriteLine(CS006.SoLon(1,2));

            // double thetich;

            // thetich = CS006.TheTich(2);              // ~ CS006.TheTich(2,1,1)
            // Console.WriteLine(thetich);             // 2

            // thetich = CS006.TheTich(2, 10);           // ~ CS006.TheTich(2,10,1)
            // Console.WriteLine(thetich);             // 20

            // thetich = CS006.TheTich(1, 2, 3);
            // Console.WriteLine(thetich);             // 6

            string fullname;

            fullname = CS006.FullName("Nguyễn", "A");
            Console.WriteLine(fullname);                        //Nguyễn A

            fullname = CS006.FullName("ĐINH", "NAM", "HOÀNG");
            Console.WriteLine(fullname);                        //ĐINH HOÀNG NAM
        }
    }
}
