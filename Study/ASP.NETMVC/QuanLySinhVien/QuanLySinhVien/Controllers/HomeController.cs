using QuanLySinhVien.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLySinhVien.Controllers
{
    public class HomeController : Controller
    {
        private QuanLySinhVienEntities db = new QuanLySinhVienEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }


        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(QuanLyNguoiDung user)
        {
            var checkLogin = db.QuanLyNguoiDung.Where(x=>x.TenDangNhap== user.TenDangNhap && x.MatKhau == user.MatKhau).Count();

            if (checkLogin > 0)
            {
                return RedirectToAction("Index","Khoas");
            }
            else
            {
                return View();
            }
            
        }

    }
}