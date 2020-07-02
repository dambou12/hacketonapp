using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmartBookingApp.Controllers
{
    public class MusicAndEntertainmentController : Controller
    {
        //Reference to object
        private Manager m = new Manager();

        // GET: MusicAndEntertainment
        public ActionResult Index()
        {
            return View(m.MusicAndEntertainmentGetAll());
        }

        // GET: MusicAndEntertainment/Details/5
        public ActionResult Details(int ? id)
        {
            var obj = m.HealthAndBeautyGetById(id.GetValueOrDefault());

            if (obj == null)
            {
                return HttpNotFound();
            }
            else
            {
                return View(obj);
            }
        }

        // GET: MusicAndEntertainment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: MusicAndEntertainment/Create
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

        // GET: MusicAndEntertainment/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: MusicAndEntertainment/Edit/5
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

        // GET: MusicAndEntertainment/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: MusicAndEntertainment/Delete/5
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
