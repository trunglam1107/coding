--Câu 2 : Thêm vào thuộc tính GHICHU có kiểu dữ liệu varchar(20) cho quan hệ SANPHAM.
ALTER TABLE SANPHAM ADD GHICHU VARCHAR(20) 

SELECT * FROM SANPHAM

--Câu 3 : Thêm vào thuộc tính LOAIKH có kiểu dữ liệu là tinyint cho quan hệ KHACHHANG.

ALTER TABLE KHACHHANG ADD LOAIKH TINYINT

SELECT * FROM KHACHHANG AS k

--Câu 4 : Cập nhật tên “Nguyễn Văn B” cho dữ liệu Khách Hàng có mã là KH01

SELECT * FROM KHACHHANG AS k WHERE k.MAKH = 'KH01'

UPDATE KHACHHANG
SET
	HOTEN ='Nguyen Van B'
	
WHERE MAKH = 'KH01'

SELECT * FROM KHACHHANG AS k WHERE k.MAKH = 'KH01'

--Câu 5 : Cập nhật tên “Nguyễn Văn Hoan” cho dữ liệu Khách Hàng có mã là KH09 và năm đăng ký là 2007

SELECT * FROM KHACHHANG AS k WHERE k.MAKH='KH09' AND YEAR(k.NGDK) = 2007

UPDATE KHACHHANG
SET
	HOTEN ='Nguyen Van Hoan'
	
WHERE MAKH='KH09' AND YEAR(NGDK) = 2007

SELECT * FROM KHACHHANG AS k WHERE k.MAKH='KH09' AND YEAR(k.NGDK) = 2007

--Câu 6 : Sửa kiểu dữ liệu của thuộc tính GHICHU trong quan hệ SANPHAM thành varchar(100).

ALTER TABLE SANPHAM ALTER COLUMN GHICHU VARCHAR(100) 

--Câu 7 : Xóa thuộc tính GHICHU trong quan hệ SANPHAM.

ALTER TABLE SANPHAM DROP COLUMN GHICHU

--Câu 8 : Xoá tất cả dữ liệu khách hàng có năm sinh 1971

SELECT * FROM KHACHHANG AS k WHERE YEAR(k.NGSINH) = 1971 AND YEAR (k.NGDK) = 2006

DELETE FROM KHACHHANG WHERE YEAR(NGSINH) = 1971