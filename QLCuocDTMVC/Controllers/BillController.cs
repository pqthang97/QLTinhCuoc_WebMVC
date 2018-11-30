using QLCuocDTMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCuocDTMVC.Controllers
{
    public class BillController : Controller
    {
        QLTinhCuocDTEntities db = new QLTinhCuocDTEntities();
        // GET: Bill
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Details(string id)
        {
            HoaDonTinhCuoc bill = db.HoaDonTinhCuocs.FirstOrDefault(x => x.MaHDTC == id);
            if (bill == null)
                return RedirectToAction("Index");


            DateTime Date = bill.NgayLapHD.Value;
            DateTime From = new DateTime(Date.Year, Date.Month, 1);
            DateTime To = new DateTime(Date.Year, Date.Month, DateTime.DaysInMonth(Date.Year, Date.Month));
            List<ChiTietSuDung> Useds = db.ChiTietSuDungs.Where(x => x.IDSIM == bill.IDSIM).Where(x => x.TGBD >= From && x.TGBD <= To).ToList();

            ViewBag.Bill = bill;
            ViewBag.Useds = Useds;
            return View();
        }
    }
}