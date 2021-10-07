using DemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DemoMVC.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection f)
        {
            return View();
        }


        [HttpGet]
        public ActionResult Demo()
        {
            //Tạo 1 list tỉnh thành phố
            List<TinhThanhPho> listTTP = new List<TinhThanhPho>();

            TinhThanhPho ttp;
            ttp = new TinhThanhPho();
            ttp.MaTinhThanhPho = 1;
            ttp.TenTinhThanhPho = "TPHCM";
            listTTP.Add(ttp);
            ttp = new TinhThanhPho();
            ttp.MaTinhThanhPho = 2;
            ttp.TenTinhThanhPho = "Hà Nội";
            listTTP.Add(ttp);

            ViewBag.TinhThanhPho = new SelectList(listTTP,"MaTinhThanhPho","TenTinhThanhPho");

            return View();
        }

        [HttpPost]
        public ActionResult Demo(FormCollection collection)
        {
            string sValue = collection["TheThao"].ToString();
            return View();
        }
    }
}