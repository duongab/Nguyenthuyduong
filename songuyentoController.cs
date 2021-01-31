using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyMVCApplication.Controllers
{
    public class songuyentoController : Controller
    {
        // GET: songuyento
        public ActionResult songuyento()
        {
            using System;

namespace VietJackCsharp
    {
        class TestCsharp
        {
            public static void Main()
            {

                int num, i, ctr, bat_dau, ket_thuc;
                bat_dau = Convert.ToInt32();
                
              ket_thuc = Convert.ToInt32();
               

                for (num = bat_dau; num <= ket_thuc; num++)
                {
                    ctr = 0;

                    for (i = 2; i <= num / 2; i++)
                    {
                        if (num % i == 0)
                        {
                            ctr++;
                            break;
                        }
                    }

                    if (ctr == 0 && num != 1)
                        
                }
               

            }

            @ViewBag.message = " Số nguyên tố là :" ;
            return View();
        }
    }
}