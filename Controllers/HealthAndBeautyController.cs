using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartBookingApp.Controllers
{
    
    public class HealthAndBeautyController : Controller
    {
        private Manager m = new Manager();
        // GET: HealthAndBeauty
        public ActionResult Index()
        {
            return View();
        }

        // GET: HealthAndBeauty/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: HealthAndBeauty/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: HealthAndBeauty/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HealthAndBeauty/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: HealthAndBeauty/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: HealthAndBeauty/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: HealthAndBeauty/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
