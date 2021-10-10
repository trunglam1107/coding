//Khai báo biến
// var fullName = 'Lam Tien Trung';
// var age = 26;

// alert(fullName);
// alert(age);

/*
Giới thiệu 1 số hàm built-in
    1.Alert
    2.Console
    3.Confirm
    4.Prompt
    5.Set timeout
    6.Set interval
*/

/*

Bài tập
1.Tạo biến fullName có giá trị là tên của bạn
2.Sử dụng hàm alert để hiển thị giá trị của biến fullName
3.Tạo thêm các biến sau:
    -message có giá trị 'Học về built-in functions trong JS'
    -warnMessage có giá trị 'Đây là message cảnh báo'
    -errorMessage có giá trị 'Đây là message lỗi'
4.Sử dụng console.log để in giá trị biến message ra tab console
5.Sử dụng console.warn để in giá trị biến warnMessage ra tab console
6.Sử dụng console.error để in giá trị biến errorMessage ra tab console


*/

// Làm bài tập tại đây
// var fullName = 'Nguyen Van Anh';
// alert(fullName);
// var message = 'Học về built-in functions trong JS';
// var warnMessage = 'Đây là message cảnh báo';
// var errorMessage = 'Đây là message lỗi';
// console.log(message);
// console.warn(warnMessage);
// console.error(errorMessage);


/**

Giới thiệu về toán tử trong Javascript
1.Toán tử số học - Arithmetic
2.Toán tử gán - Assignment
3.Toán tử so sánh - Comperison
4.Toán tử logic - Logical

 */

/**
    Cho tam giác có cạnh đáy là a và chiều cao là h. Hãy tính diện tích tam giác này và gán cho biến s.

    Ví dụ: Cho a = 10, h = 20. Kết quả sẽ là 100
 */

// function run(a, h) {
//     var s = (a*h)/2;
    
//     return s;
// }

// var a = 10;
// var h = 20;

// console.log( 'Diện tích của tam giác là : ' + run(a,h));


/**
 Cho biến sum là tổng của a và b, different là hiệu của a và b. Hãy tìm a và b.

    Ví dụ: Cho sum = 10, different = 2. Kết quả sẽ là 6 4


 */


// function run(sum, different) {
//     var a = sum - b;
//     var b = a - different;
        
//     return 'a is ' + a + ' and b is ' + b;
// }

// var sum = 10;
// var different  = 2;

// console.log(run(sum, different));

/**
    Cho biến minutes có giá trị là số phút. 
    Hãy tính ra số giây và gán cho biến seconds.

    Ví dụ: cho minutes = 2. Kết quả sẽ là seconds = 120
 */


// function run(minutes) {
//     var seconds = minutes * 60;

//     return seconds;
// }

// var minutes = 2;

// console.log(run(minutes));

var a = 5 + '5';

console.log(a);