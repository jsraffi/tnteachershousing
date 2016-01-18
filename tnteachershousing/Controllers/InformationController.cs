using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tnteachershousing.Models;
using PagedList;

namespace tnteachershousing.Controllers
{
    public class InformationController : Controller
    {
        private techearDBContext db = new techearDBContext();
        // GET: Information
        public ActionResult Index(int? page)
        {
            int pagesize = 6;
            var pageNumber = page ?? 1;
            var images = db.gallleryImages.AsNoTracking().OrderBy(i => i.imageID);

            return View(images.ToPagedList(pageNumber,pagesize));
        }

        public ActionResult newsEvent()
        {
            return View();
        }

        public ActionResult our_associate()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }

        public ActionResult downloads()
        {
            return View();
        }
        public ActionResult faq()
        {
            return View();
        }

        public ActionResult usefullinks()
        {
            return View();
        }

        public ActionResult feedback()
        {
            return View();
        }
        public ActionResult sitemap()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }
        // GET: Information/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Information/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Information/Create
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

        // GET: Information/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Information/Edit/5
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

        // GET: Information/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Information/Delete/5
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
