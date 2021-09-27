using System;

namespace CS002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title = "Day la vi du";

            //Console.BackgroundColor = ConsoleColor.Yellow;
            //Console.ForegroundColor = ConsoleColor.DarkMagenta;

            //Console.WriteLine("Duoc set mau");

            //Console.ResetColor();

            //Console.WriteLine();
            //Console.WriteLine();

            //Console.WriteLine("Reset color");

            //string hoVaTen;
            //Console.Write("Ho va ten cua ban : ");
            //hoVaTen = Console.ReadLine();

            //Console.WriteLine("Xin chao {0}",hoVaTen);

            float a, b;
            string sinput;
            Console.Write("Hay nhap so a : ");
            sinput = Console.ReadLine();
            a = float.Parse(sinput);

            Console.Write("Hay nhap so b : ");
            sinput = Console.ReadLine();
            b = Convert.ToSingle(sinput);

            Console.WriteLine("So a = {0} , So b = {1}", a, b);

        }
    }
}
