using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1
{
    class Program
    {
        //Kiểu liệt kê Enumeration
        enum Days { Sun, Mon , Tue , Wed , thu, Fri, Sat };

        static void Main(string[] args)
        {
            //Day 1
            //Console.Write("Hello World");
            //Console.ReadKey();
            //Day 2 : Data Type in c#

            //Int 
            //Int32 num = 30;
            //Console.Write("Kiểu số nguyên Int32 : " + num);
            //Console.ReadKey();

            //Double
            //double num2 = 30.33;
            //Console.Write("Kiểu số thực Double : " + num2);
            //Console.ReadKey();

            //Boolean
            //Boolean status = true;
            //Console.Write("Kiểu Boolean : " + status);
            //Console.ReadKey();

            //String
            //string name = "Nguyen van A";
            //Console.Write("Kiểu chuỗi : " + name);
            //Console.ReadKey();

            //Kiểu liệt kê 
            Console.Write(Days.Sun);
            Console.ReadKey();

        }
    }
}
