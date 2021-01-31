using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class PTBac2Controller : Controller
    {
        // GET: PTBac2

        public ActionResult PTBac2(string hesoA, string hesoB, string hesoC , string dapan)
        {

            int a, b, c;
            double d, x1, x2;
            string dapan = "";
        a = Convert.ToInt32(hesoA);
            b = Convert.ToInt32(hesoB);
               c = Convert.ToInt32(hesoC);

            d = b * b - 4 * a * c;
            if (d == 0)
            {
                ViewBag.dapan = "Phuong trinh co mot nghiem duy nhat";
                x1 = -b / (2.0 * a);
                x2 = x1;
                ViewBag.dapan ="Nghiem duy nhat cua phuong trinh la = {0}\n" + x1;
            }
            else if (d > 0)
            {
                ViewBag.dapan = "Phuong trinh co hai nghiem thuc phan biet";

                x1 = (-b + Math.Sqrt(d)) / (2 * a);
                x2 = (-b - Math.Sqrt(d)) / (2 * a);

                ViewBag.dapan = "Nghiem thu nhat: x1 = {0}"+ x1;
                ViewBag.dapan = "Nghiem thu nhat: x2 = {0}" + x2;
            }
           
            else
                ViewBag.dapan = "Phuong trinh vo nghiem (hay khong co nghiem thuc nao)";

            ViewBag.dapan = dapan;
            return View();
        }
        }
    }

