using System;

namespace CS003
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            string sinput;
            


            Console.Write("Nhap so a : ");
            sinput = Console.ReadLine();
            a = int.Parse(sinput);

            Console.Write("Nhap so b : ");
            sinput = Console.ReadLine();
            b = Convert.ToInt32(sinput);

            Console.WriteLine("{0} + {1} = {2}", a , b , a + b);

            Console.WriteLine("{0} - {1} = {2}", a, b , a - b);

            Console.WriteLine("{0} * {1} = {2}", a, b, a * b);

            if (b == 0)
            {
                Console.WriteLine("Loi chia Zero");
            }
            else
            {
                Console.WriteLine("{0} / {1} = {2}", a , b , a / b);
            }

            if (b == 0)
            {
                Console.WriteLine("Loi chia Zero");
            }
            else
            {
                Console.WriteLine("{0} % {1} = {2}", a, b, a % b);
            }

        }
    }
}
