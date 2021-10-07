using System;

namespace CS003_ArithmeticAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 28;
            // int b = 10;
            // //Phép cộng
            // Console.WriteLine(a + b);  // In ra: 38
            // Console.WriteLine(a - b);  // In ra: 18

            // //Phép nhân
            // float c = 1.2f;
            // int d = 3;
            // Console.WriteLine(c * d);  // In ra 3.6

            // //Phép chia
            // float e = 1.2f;
            // int f = 3;
            // Console.WriteLine(e / f);  // In ra 0.4

            // int g = 10;
            // int h = 3;
            // Console.WriteLine(g / h);          // In ra 3

            // // Chuyển số chia thành số thực
            // Console.WriteLine(g / (float)h);   // In ra 3.333333

            // //Chia lấy dư %
            // int x = 8;
            // int s = 3;
            // Console.WriteLine(x % s);  // In ra 2

            // Console.WriteLine(5 + 3 * 2);         // 11
            // Console.WriteLine(6 / 2 + 3 * 2);     // 9
            // Console.WriteLine(6 / (2 + 3) * 2);   // 2

            int a = 5;
            int b = 2 * a++;  // b = 10; a = 6

            int a = 5;
            int b = 2 * ++a;  // b = 12; a = 6
        }
    }
}
