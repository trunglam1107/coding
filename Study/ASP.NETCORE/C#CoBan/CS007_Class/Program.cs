using System;

namespace CS007_Class
{
    class Program
    {
        static void Main(string[] args)
        {
            // var sungluc = new VuKhi();              // Khai báo và khởi tạo
            // sungluc.name = "SÚNG LỤC";              // Truy cập và gán thuộc tính
            // sungluc.SetDoSatThuong(5);             // Truy cập (gọi) phương thức

            // VuKhi sungtruong = new VuKhi();
            // sungtruong.name = "SÚNG TRƯỜNG";
            // sungtruong.SetDoSatThuong(20);

            // sungluc.TanCong();                      // Gọi phương thức
            // sungtruong.TanCong();                   // Gọi phương thức

            double a = 1;
            double b = 2;
            var c = OverloadingExample.Sum(a, b); // c = 3 có kiểu double
            Console.WriteLine(c);
            int d = 1;
            int e = 2;
            var f = OverloadingExample.Sum(d, e); // c = 3 nhưng có kiểu int
            Console.WriteLine(f);
        }
    }
}
