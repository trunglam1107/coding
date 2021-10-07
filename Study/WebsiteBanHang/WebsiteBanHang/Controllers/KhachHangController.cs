using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebsiteBanHang.Models;

namespace WebsiteBanHang.Controllers
{
    public class KhachHangController : Controller
    {
        QuanLyBanHangEntities db = new QuanLyBanHangEntities();
        // GET: KhachHang
        public ActionResult Index()
        {
            //Truy vấn dữ liệu thông qua câu lệnh
            //var listKH = from kh in db.KhachHang select kh;
            var listKH = db.KhachHang.ToList();
            return View(listKH);
        }

        public ActionResult Index1()
        {
            var listKH = from kh in db.KhachHang select kh;
            return View(listKH);
        }

        public ActionResult TruyVanDoiTuong()
        {
            var listKH = from kh in db.KhachHang select kh;

            KhachHang khachHang = listKH.FirstOrDefault();
            //lấy đối tượng khách hàng dựa trên phương thức hỗ trợ 

            KhachHang khachHang2 = db.KhachHang.Single(n => n.MaKH == 2);

            return View(khachHang2);
        }

        public ActionResult SortDuLieu()
        {
            List<KhachHang> listKH = db.KhachHang.OrderBy(x => x.TenKH).ToList();
            return View(listKH);
        }

        public ActionResult GroupDuLieu()
        {
            List<ThanhVien> listKH = db.ThanhVien.OrderByDescending(x => x.TaiKhoan).ToList();
            return View(listKH);
        }
    }
}