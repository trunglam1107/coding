using System;

namespace HeartConsole
{
    class Program
    {
        static void Main(string[] args)
        {


            for (int i = 1; i < 7; i++)
            {
                for (int j = 1; j <= 7; j++)
                {
                    if (!((i == 1 || (j == 1 || j == 1 || j == 1))
                            || (i == 4 || (j == 1 || j == 7))
                            || (i == 5 || (j <= 2 || j >= 6))
                            || (i == 6 || (j <= 3 || j >= 5))
                        ))
                    {
                        Console.WriteLine(" * ");
                    }
                    else
                    {
                        Console.WriteLine("  ");
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
