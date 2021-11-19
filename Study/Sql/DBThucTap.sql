--Link : https://nguyenvanhieu.vn/bai-tap-sql-co-ban/
--I.Phần 1 : 
--1.Đưa ra thông tin gồm mã số, họ tênvà tên khoa của tất cả các giảng viên
SELECT tv.Magv, tv.Hotengv,t.Tenkhoa FROM TBLGiangVien AS tv 
INNER JOIN TBLKhoa AS t ON t.Makhoa = tv.Makhoa
--2.Đưa ra thông tin gồm mã số, họ tênvà tên khoa của các giảng viên của khoa ‘DIA LY va QLTN’
SELECT tv.Magv, tv.Hotengv,t.Tenkhoa FROM TBLGiangVien AS tv 
INNER JOIN TBLKhoa AS t ON t.Makhoa = tv.Makhoa WHERE t.Tenkhoa='Dia ly va QLTN'
--3.Cho biết số sinh viên của khoa ‘CONG NGHE SINH HOC’
SELECT COUNT(*) AS SoSVCNSH FROM TBLSinhVien AS tsv INNER JOIN 
TBLKhoa AS t ON t.Makhoa = tsv.Makhoa
WHERE t.Tenkhoa='Cong nghe Sinh hoc'
--4.Đưa ra danh sách gồm mã số, họ tênvà tuổi của các sinh viên khoa ‘TOAN’
SELECT tsv.Masv, tsv.Hotensv, (YEAR(GETDATE()) - tsv.Namsinh ) AS SoTuoi , t.Tenkhoa
  FROM TBLSinhVien AS tsv INNER JOIN 
TBLKhoa AS t ON t.Makhoa = tsv.Makhoa
WHERE t.Tenkhoa='TOAN'
--5.Cho biết số giảng viên của khoa ‘CONG NGHE SINH HOC’
SELECT COUNT(*) AS SoGVCNSH FROM TBLGiangVien AS tv 
INNER JOIN TBLKhoa AS t ON t.Makhoa = tv.Makhoa
WHERE t.Tenkhoa='Cong nghe Sinh hoc'
--6.Cho biết thông tin về sinh viên không tham gia thực tập
SELECT tv.* FROM TBLSinhVien AS tv WHERE EXISTS (SELECT * FROM TBLHuongDan AS td WHERE tv.Masv = td.Masv)
SELECT tv.* FROM TBLSinhVien AS tv WHERE NOT EXISTS (SELECT * FROM TBLHuongDan AS td WHERE tv.Masv = td.Masv)
--7.Đưa ra mã khoa, tên khoa và số giảng viên của mỗi khoa
SELECT t.Makhoa, t.Tenkhoa , COUNT(t.Makhoa) AS SoGiangVien
 FROM TBLKhoa AS t INNER JOIN TBLGiangVien AS tv ON tv.Makhoa = t.Makhoa
GROUP BY  t.Makhoa, t.Tenkhoa
--8.Cho biết số điện thoại của khoa mà sinh viên có tên ‘Le van son’ đang theo học
SELECT t.Dienthoai FROM TBLKhoa AS t 
JOIN TBLSinhVien AS tv
ON tv.Makhoa = t.Makhoa
WHERE tv.Hotensv = 'Le van son'
--II.Phần 2:
--1.Cho biết mã số và tên của các đề tài do giảng viên ‘Tran son’ hướng dẫn
SELECT tt.Madt, tt.Tendt FROM TBLHuongDan AS td 
JOIN TBLDeTai AS tt  ON tt.Madt = td.Madt 
JOIN TBLGiangVien AS tv ON tv.Magv = td.Magv
WHERE tv.Hotengv='Tran son'
--2.Cho biết tên đề tài không có sinh viên nào thực tập
SELECT tt.Tendt AS TenDeTai
FROM TBLDeTai AS tt 
WHERE NOT EXISTS (SELECT * FROM TBLHuongDan AS td WHERE tt.Madt = td.Madt)
--3.Cho biết mã số, họ tên, tên khoa của các giảng viên hướng dẫn từ 3 sinh viên trở lên 
SELECT GV.Magv,GV.Hotengv,K.Tenkhoa
FROM TBLGiangVien GV JOIN TBLKhoa K
ON GV.Makhoa = K.Makhoa
WHERE GV.Magv IN (
SELECT HD.Magv
FROM TBLHuongDan HD
GROUP BY HD.Magv
HAVING COUNT(HD.MaSV)>3)
--4.Cho biết mã số, tên đề tài của đề tài có kinh phí cao nhất
SELECT DT.Madt,DT.Tendt,dt.Kinhphi
FROM TBLDeTai DT 
WHERE DT.Kinhphi = (
SELECT MAX(DT.Kinhphi)
FROM TBLDeTai DT)                                   
