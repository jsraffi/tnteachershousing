using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace tnteachershousing.Controllers
{
    public class ProjectController : Controller
    {
        // GET: Project
        public ActionResult Index()
        {
            return View();
        }

        // GET: Project/Details/5
        public ActionResult hosur()
        {
            return View();
        }

        // GET: Project/Create
        public ActionResult map_saibaba_colony()
        {
            return View();
        }

        public ActionResult map_edu_city()
        {
            return View();
        }

        public ActionResult map_rajeshwari_farm_plots()
        {
            return View();
        }

        public ActionResult map_rajeshwari_town_ship()
        {
            return View();
        }
        public ActionResult map_chengalpet_teachers_colony()
        {
            return View();
        }

        public ActionResult map_covai_techers_colony_plots()
        {
            return View();
        }

        public ActionResult map_techers_zen_meadow()
        {
            return View();
        }

        public ActionResult map_covai_techers_colony_housing()
        {
            return View();
        }

        public ActionResult apply_for_allotment(string id)
        {
            ViewBag.ProjectId = "";
            ViewBag.ProjectDescription = "";

            if (id == "55")
            {
                ViewBag.ProjectId = "55";
                ViewBag.ProjectDescription = "Teachers EDU CITY Hosur-Kelamangala Road";
                
            }
            else if (id == "54")
            {   
                return View("apply_for_allotment54");
            }
            else if (id == "53")
            {   
                return View("apply_for_allotment53");
            }
            else if (id == "42")
            {
                return View("apply_for_allotment42");
            }
            else if (id == "41")
            {
                return View("apply_for_allotment41");
            }
            else if (id == "40")
            {
                return View("apply_for_allotment40");
            }
            else if (id == "39")
            {
                return View("apply_for_allotment39");
            }
            else if (id == "38")
            {
                return View("apply_for_allotment38");
            }
            return View("apply_for_allotment");
        }
        public ActionResult ongoing(string id)
        {   
            if(id == "54")
            {
                return View("Township-illupur54");
            }
            if (id == "53")
            {
                return View("Township-illupur_flats_villas53");
            }
            if (id == "42")
            {
                return View("chengalpet42");
            }
            if (id == "41")
            {
                return View("covai41");
            }
            if (id == "40")
            {
                return View("covaizen40");
            }
            if (id == "39")
            {
                return View("covaisaibaba39");
            }
            if (id == "38")
            {
                return View("covaihousing38");
            }
            return View("hosur_55");
        }

            
        public ActionResult ProjectListView()
        {
            return View();
        }
        public ActionResult CompletedProject()
        {
            return View();
        }

        public ActionResult ProjectGridView()
        {
            return View();
        }

        public ActionResult AllotmentProcedure()
        {
            return View();
        }



        // POST: Project/Create
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

        // GET: Project/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Project/Edit/5
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

        // GET: Project/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Project/Delete/5
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
