using System;

namespace CS007_Class
{

    public class OverloadingExample
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }

        public static double Sum(double a, double b)
        {
            return a + b;
        }
    }
}