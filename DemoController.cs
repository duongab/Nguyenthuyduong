using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index(string Hoten, string ngaysinh )
        {
            ViewBag.thongbao = "Welcome " + Hoten;
            ViewBag.ngaysinh = ngaysinh;
            return View();
        }
    }
}