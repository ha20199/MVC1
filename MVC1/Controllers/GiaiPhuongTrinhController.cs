using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class GiaiPhuongTrinhController : Controller
    {
        GiaiPTB1 gpt = new GiaiPTB1();
        // GET: BaiTapGPTB1

        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GiaiPTB1(double HeSoA, double HeSoB)
        {
            double x = gpt.GPTB1(HeSoA, HeSoB);
            ViewBag.NghiemPhuongTrinh = x;
            return View();
        }
        public ActionResult NghiemPt()
        {
            return View();
        }
    }
}