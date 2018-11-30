using QLCuocDTMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCuocDTMVC.Controllers
{
    public class SimController : Controller
    {
        QLTinhCuocDTEntities db = new QLTinhCuocDTEntities();
        // GET: Sim
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            ThongTinSIM sim = db.ThongTinSIMs.FirstOrDefault(x => x.IDSIM == id);
            if (sim == null)
                return RedirectToAction("Index");

            List<HoaDonTinhCuoc> Bills = db.HoaDonTinhCuocs.Where(x => x.IDSIM == sim.IDSIM).OrderByDescending(x => x.NgayLapHD).ToList();

            ViewBag.Sim = sim;
            ViewBag.Bills = Bills;
            return View();
        }
    }
}