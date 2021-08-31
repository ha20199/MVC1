using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC1.Models;

namespace MVC1.Controllers
{
    public class GPTB1Controller : Controller
    {
        // GET: GPTB1
        public ActionResult Index()
        {
            return View();
        }
        GiaiPtb1 gpt = new GiaiPtb1();
        // GET: BaiTapGPTB1

       
        [HttpPost]
        public ActionResult GiaiPTB1(double HeSoA, double HeSoB)
        {
            double x = gpt.GiaiPTB1(HeSoA, HeSoB);
            ViewBag.NghiemPhuongTrinh = x;
            return View();
        }
        public ActionResult NghiemPt()
        {
            return View();
        }

    }
}