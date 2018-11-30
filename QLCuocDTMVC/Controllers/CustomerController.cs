using QLCuocDTMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLCuocDTMVC.Controllers
{
    public class CustomerController : Controller
    {
        QLTinhCuocDTEntities db = new QLTinhCuocDTEntities();
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Details(string id)
        {
            KhachHang customer = db.KhachHangs.FirstOrDefault(x => x.MaKH == id);
            if (customer == null)
                return RedirectToAction("Index");

            List<ThongTinSIM> sims = db.ThongTinSIMs.Where(x => x.MaKH == id).ToList();
            ViewBag.Customer = customer;
            ViewBag.Sims = sims;
            return View();
        }
    }
}