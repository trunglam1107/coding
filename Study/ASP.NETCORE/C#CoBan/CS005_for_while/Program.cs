using System;

namespace CS005_for_while
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vòng lặp for
            // for (int i = 8; i <= 10; i++)
            // {
            //     Console.WriteLine("Số i = " + i);
            // }
            // // Số i = 8
            // // Số i = 9
            // // Số i = 10

            // int j = 10;
            // for (; j <= 20;)
            // {
            //     Console.WriteLine("Số j = " + j);
            //     j += 2;
            // }
            // Số j = 10
            // Số j = 12
            // Số j = 14
            // Số j = 16
            // Số j = 18
            // Số j = 20

            //Vòng lặp while

            int i = 8;
            while (i <= 10)
            {
                Console.WriteLine("Số i = " + i);
                i++;
            }
        }
    }
}
