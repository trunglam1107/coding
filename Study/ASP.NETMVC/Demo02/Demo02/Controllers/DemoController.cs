using Demo02.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Demo02.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            HocSinh hs = new HocSinh();
            hs.MaHS = int.Parse(f["txtMaHS"].ToString());
            hs.TenHS = f["txtHoTen"].ToString();

            return View(hs);
        }
    }
}