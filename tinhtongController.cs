using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{

    public class tinhtongController : Controller
    {

        // GET: tinhtong
        public ActionResult tinhtong(string msN)
        {
            int n;
            double S = 0;
            string ketqua = "";
            ketqua = " Tính tổng dãy số :";
            ketqua = "Nhập số phần tử :";
            n = Convert.ToInt32(msN);
            for (double i = 1; i <= n; i++)
            {

                S += 1 / i;
            }
          
                ViewBag.message = "tổng của dãy phần tử :" + S;
            return View();
        }
    }
}