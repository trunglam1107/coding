using System;

namespace CS001_HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =10;
            int b = 10;
            Console.WriteLine("Tổng 2 số : " + TongHaiSo(a,b));
        }

        /// <summary>
        /// Tính tổng hai số nguyên
        /// </summary>
        /// <param name="a">số thứ nhất</param>
        /// <param name="b">số thứ hai</param>
        /// <returns>giá trị a + b</returns>
        static int TongHaiSo(int a, int b)
        {
            return a + b;
        }
    }
}
