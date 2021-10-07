using System;

namespace CS002_VariablesConstantsIO
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khai báo biến và gán ngay giá trị lưu vào biến
            // string address = "Hà Nội, Việt Nam";

            // Khai báo biến, sau đó trước khi sử dụng gán giá trị cho biến
            // int studentAge;
            // studentAge = 22;

            // int seconds = 60;                    //khai báo biến số nguyên
            // double so_pi = 3.14;                 //khai báo biến số thực
            // bool deltaIsSezo = true;             //Khai báo biến logic
            // char chooseAction = 'S';            //Khai báo biến kiểu ký tự
            // string msgResult = "Kết quả giải:"; // khai báo biến chuỗi

            // Console.WriteLine();                                                //Xuống dòng
            // Console.WriteLine();                                                //Xuống dòng

            // Console.ForegroundColor = ConsoleColor.DarkMagenta;                 //Đặt màu chữ
            // Console.WriteLine("XIN CHÀO - CHƯƠNG TRÌNH NHẬP XUẤT DỮ LIỆU");     //In dòng chữ
            // Console.ResetColor();                                               //Reset màu

            // Console.Write("Giá trị biến so_pi là : ");                          //In dòng chữ
            // Console.WriteLine(so_pi);                                           //In giá trị biến
            // Console.WriteLine();                                                //Xuống dòng

            // int a = 123;
            // double b = 567.123;

            // Console.WriteLine("Biến a = {0}, biến b = {1}", a, b);

            //Xuất ra: Biến a = 123, biến b = 567.123

            string userLogin;
            Console.Write("Nhập username : ");
            userLogin = Console.ReadLine();
            Console.WriteLine($"Tên nhập vào là: {userLogin}");
            Console.Write("Nhập một số thức : ");
            // Nhập chuỗi - chuyển ngay chuỗi đó thành số thực
            double dinput = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Số đã nhập là: {dinput}");

            // var bien1 = 3.14;                                           // biến sẽ có kiểu double
            // var bien2 = 3;                                              // biến sẽ có kiểu int
            // var bien3 = "Biến khai báo với var phải khởi tạo ngay";     // string
            // var bien4 = (5 < 4);                                        // bool

            const string MON = "THỨ HAI";
            Console.WriteLine(MON);
        }
    }
}
