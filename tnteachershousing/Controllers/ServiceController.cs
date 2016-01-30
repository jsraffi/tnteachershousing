using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tnteachershousing.Controllers
{
    public class ServiceController : Controller
    {
        // GET: Service
        public ActionResult JointVenture()
        {
            return View();
        }

        public ActionResult ValueAdded()
        {
            return View();
        }
        public ActionResult Land_Survey_and_Feasibility()
        {
            return View();
        }
        public ActionResult Land_Survey_and_Feasibility_enquiry()
        {
            return View();

        }
        public ActionResult loan_support()
        {
            return View();

        }
        public ActionResult loan_support_enquiry()
        {
            return View();

        }

        public ActionResult architectural_design()
        {
            return View();
        }

        public ActionResult architectural_design_enquiry()
        {
            return View();
        }

        public ActionResult construction_support()
        {
            return View();
        }

        public ActionResult construction_support_enquiry()
        {
            return View();
        }

        public ActionResult resell_property()
        {
            return View();
        }

        public ActionResult resell_property_enquiry()
        {
            return View();
        }
        public ActionResult NRI_services()
        {
            return View();
        }

        public ActionResult NRI_services_enquiry()
        {
            return View();
        }



        // GET: Service/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Service/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Service/Create
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

        // GET: Service/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Service/Edit/5
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

        // GET: Service/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Service/Delete/5
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
