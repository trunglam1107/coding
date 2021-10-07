using System;

namespace CS004_Logical_if_switch
{
    class Program
    {
        static void Main(string[] args)
        {
            // int a = 5;
            // int b = 6;
            // var c = (a > b);

            // int number;
            // string sinput;

            // Console.Write("Vui lòng nhap 1 so : ");
            // sinput = Console.ReadLine();
            // number = Convert.ToInt32(sinput);

            // if ((number % 2) == 0)
            // {
            //     Console.WriteLine($"{number} là so chan");
            // }
            // else
            // {
            //     Console.WriteLine($"{number} là so le");
            // }


            // int age = 18;
            // var mgs = (age >= 18) ? "Đủ điều kiện" : "Không đủ điều kiện";
            // Console.WriteLine(mgs);

            // var a = 2;
            // var b = 3.5;
            // var c = 2;
            // var max = a >= b ? a >= c ? a : c : b >= c ? b : c;
            // // Viết tường minh hơn
            // // max = (a >= b) ?  (a >= c ? a : c) : (b >=c ? b : c);
            // Console.WriteLine(max);

            //Bài tập tìm số lớn nhất trong 3 số : 
            double a,b,c;
            string sinput;
            Console.Write("Nhập số a : ");
            sinput = Console.ReadLine();
            a = Convert.ToDouble(sinput);

            Console.Write("Nhập số b : ");
            sinput = Console.ReadLine();
            b = Convert.ToDouble(sinput);

            Console.Write("Nhập số c : ");
            sinput = Console.ReadLine();
            c = Convert.ToDouble(sinput); 

            var max = a >= b ? a >= c ? a : c : b >= c ? b : c;
            Console.WriteLine($"So lon nhat la {max}");
        }
    }
}
