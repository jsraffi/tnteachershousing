using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tnteachershousing.Models;
using tnteachershousing.ViewModel;
using AutoMapper;


namespace tnteachershousing.Controllers
{
    public class AdminController : Controller
    {
        private techearDBContext db = new techearDBContext();
        // GET: Admin
        public ActionResult Index()
        {
            ViewBag.FromController = "Administration Home";
            return View();
        }
        public ActionResult ProjectIndex()
        {
            var projectlist = db.ProjectIndexes.AsNoTracking().OrderBy(p => p.ProjectID);
            return View(projectlist);
        }

        [HttpGet]
        public ActionResult CreateProject()
        {
            ViewBag.ProjectTypeRefID = new SelectList(db.ProjectTypes.AsNoTracking().Select(c => new { c.ProjectTypeID, c.ProjectTypeName }), "ProjectTypeID", "ProjectTypeName");
            return View();
        }
        [HttpPost]
        public ActionResult CreateProject(ProjectViewModel projectviewmodel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    projectviewmodel.CreationDate = DateTime.Now;
                    Project projectmodel = Mapper.Map<Project>(projectviewmodel);
                    db.Projects.Add(projectmodel);
                    db.SaveChanges();
                    return RedirectToAction("ProjectIndex");
                }
                else
                {
                    ViewBag.ProjectTypeRefID = new SelectList(db.ProjectTypes.AsNoTracking().Select(c => new { c.ProjectTypeID, c.ProjectTypeName }), "ProjectTypeID", "ProjectTypeName", projectviewmodel.ProjectTypeRefID);
                    return View();
                }

            }
            catch (Exception e)
            {
                ViewBag.ProjectTypeRefID = new SelectList(db.ProjectTypes.AsNoTracking().Select(c => new { c.ProjectTypeID, c.ProjectTypeName }), "ProjectTypeID", "ProjectTypeName",projectviewmodel.ProjectTypeRefID);
                return View();
            }
        }
        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
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

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
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

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
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
