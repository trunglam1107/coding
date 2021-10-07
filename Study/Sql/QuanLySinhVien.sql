SELECT * FROM SinhVien     WHERE SinhVien_ID = '002'
GO

SELECT * FROM Lop
GO

SELECT * FROM Khoa

/*Câu hỏi 1*/
SELECT COUNT(*) AS SoHocSinh FROM SinhVien AS sv
OUTER APPLY (SELECT * FROM Lop AS l WHERE sv.ID_Lop = l.Lop_ID) AS tblLop
OUTER APPLY (SELECT * FROM Khoa AS k WHERE tblLop.ID_Khoa = k.Khoa_ID) AS tblKhoa 
WHERE tblLop.TenLop = 'D2_CNTT' AND tblKhoa.TenKhoa = 'Cong Nghe Thong Tin'

SELECT COUNT(*) AS SoHocSinh FROM SinhVien AS sv
INNER JOIN Lop AS l
          ON l.Lop_ID = sv.ID_Lop 
         INNER JOIN Khoa AS k
                   ON k.Khoa_ID = l.ID_Khoa
WHERE l.TenLop='D2_CNTT' AND k.Khoa_ID='k1'

/*
Câu 2 : 
 */
 
INSERT INTO SinhVien(SinhVien_ID,TenSinhVien, GioiTinh, NgaySinh, NoiSinh, NoiOHienTai,
            KhoaHoc, LyLich, ID_Lop, HinhAnh) VALUES ('052', N'Nguyễn Thị Thanh Hoa',0,'1989-11-10','Ha Noi','Ha Noi','2009-2013','Tot','l1','betrai.jpg')
            INSERT INTO SinhVien(SinhVien_ID,TenSinhVien, GioiTinh, NgaySinh, NoiSinh, NoiOHienTai,
            KhoaHoc, LyLich, ID_Lop, HinhAnh) VALUES ('053',N'Trần Quốc Tuấn',0,'1989-11-11','Thanh Hoa','Ha Noi','2009-2013','Tot','l1','betrai.jpg')
            INSERT INTO SinhVien(SinhVien_ID,TenSinhVien, GioiTinh, NgaySinh, NoiSinh, NoiOHienTai,
            KhoaHoc, LyLich, ID_Lop, HinhAnh) VALUES ('054',N'Nguyễn Tuấn Tú',0,'1989-11-12','Vinh Long','Can Tho','2009-2013','Tot','l1','betrai.jpg')
            INSERT INTO SinhVien(SinhVien_ID,TenSinhVien, GioiTinh, NgaySinh, NoiSinh, NoiOHienTai,
            KhoaHoc, LyLich, ID_Lop, HinhAnh) VALUES ('055',N'Cao Thanh Thủy',0,'1989-11-14','Nghe An','Ha Noi','2009-2013','Tot','l1','betrai.jpg')
            INSERT INTO SinhVien(SinhVien_ID,TenSinhVien, GioiTinh, NgaySinh, NoiSinh, NoiOHienTai,
            KhoaHoc, LyLich, ID_Lop, HinhAnh) VALUES ('056',N'Trần Văn Đại',0,'1989-11-21','Bac Ninh','Ha Noi','2009-2013','Tot','l1','betrai.jpg')
            
        /*
         * Câu 3 
         */
         
         UPDATE SinhVien
         SET
         	
         	TenSinhVien = N'Trần Văn Bình'
         	
         WHERE SinhVien_ID = '002'
         
         /*
          * Câu 4 
          */
          
          DELETE FROM SinhVien WHERE SinhVien_ID = '051'
          
          /*
           * Câu 5
           */
           
SELECT * FROM SinhVien AS sv
INNER JOIN Lop AS l
          ON l.Lop_ID = sv.ID_Lop 
INNER JOIN Khoa AS k
                   ON k.Khoa_ID = l.ID_Khoa          
WHERE l.Lop_ID = 'l1' AND l.ID_Khoa='k1' AND YEAR(sv.NgaySinh) > 1989

/*
 * Câu 7
 */
 DELETE FROM Lop WHERE TenLop='le quang hoa'
 
/*
 * Câu 8
 */
 
 SELECT * FROM SinhVien WHERE SinhVien_ID IN ('005', '006', '007')
 
 SELECT * FROM Lop AS l WHERE l.Lop_ID='l1'
 
 SELECT * FROM Khoa WHERE Khoa_ID='k1'
 
 UPDATE Lop SET ID_Khoa = 'k2' WHERE Lop_ID='l1'
 
 SELECT * FROM SinhVien AS sv
INNER JOIN Lop AS l
          ON l.Lop_ID = sv.ID_Lop 
INNER JOIN Khoa AS k
                   ON k.Khoa_ID = l.ID_Khoa
 WHERE sv.SinhVien_ID IN ('005', '006', '007')
 
 /*
  * Câu 07
  */
 
 SELECT * FROM MonHoc
 
 SELECT MAX(DiemTongKet) AS DiemCaoNhat  FROM KetQua AS kq WHERE kq.ID_MonHoc='m2'
 
  SELECT MAX(DiemThi) AS DiemCaoNhat  FROM KetQua AS kq WHERE kq.ID_MonHoc='m2'
 
 /*
  * Câu 08
  */
   SELECT MAX(DiemTongKet) FROM KetQua AS kq WHERE kq.ID_MonHoc='m1' AND DiemTongKet < 
   (SELECT MAX(DiemTongKet)  FROM KetQua AS kq WHERE kq.ID_MonHoc='m1')
   
   SELECT MAX(DiemThi) FROM KetQua AS kq WHERE kq.ID_MonHoc='m1' AND DiemThi < 
   (SELECT MAX(DiemThi)  FROM KetQua AS kq WHERE kq.ID_MonHoc='m1')
 
 /*
  * 
  */
  
  SELECT GETDATE()
  
  SELECT * FROM KetQua ORDER BY DiemTongKet ASC 
  
  SELECT COUNT(*) FROM SinhVien AS sv
  
  SELECT COUNT (DISTINCT TenSinhVien)  FROM SinhVien
  
  SELECT COUNT(*) AS SoLop FROM Lop AS l INNER JOIN Khoa AS k
                                   ON k.Khoa_ID = l.ID_Khoa WHERE k.Khoa_ID='k1'
  
  SELECT * FROM SinhVien AS sv WHERE sv.SinhVien_ID='011'
  
  SELECT SUM(DiemTongKet) AS DiemTongKet  FROM KetQua AS kq WHERE kq.ID_SinhVien='011' AND kq.ID_MonHoc='m1' 
  
  SELECT sv.TenSinhVien,kq.DiemThi FROM KetQua AS kq 
  INNER JOIN MonHoc AS mh ON mh.MonHoc_ID = kq.ID_MonHoc
  INNER JOIN SinhVien AS sv ON sv.SinhVien_ID = kq.ID_SinhVien 
  WHERE kq.ID_MonHoc = 'm2'  AND  DiemThi >= ALL(SELECT DiemThi FROM KetQua WHERE ID_MonHoc = 'm2' )                  
                               