using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using tnteachershousing.Models;
using tnteachershousing.ViewModel;
using AutoMapper;
using System.Net;
using System.Data.Entity;
using CrystalDecisions.CrystalReports.Engine;
using System.IO;
using CrystalDecisions.Shared;
using Microsoft.AspNet.Identity;
using System.Configuration;
using PagedList;


namespace tnteachershousing.Controllers
{

    [Authorize(Roles = "Administrator")]
    public class AdminController : Controller
    {
        private techearDBContext db = new techearDBContext();
        // GET: Admin
        public ActionResult Index()
        {   
            if(Request.IsAuthenticated)
            {     
            ViewBag.FromController = "Administration Home";
            return View();
            }
            
            return RedirectToAction("Login", "Account", new { @returnUrl = "/Admin/Index" });
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
        [ValidateAntiForgeryToken]
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

        [HttpGet]
        public ActionResult EditProject(string projectid)
        {
            if (projectid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project projectmodel = db.Projects.Find(Convert.ToInt32(projectid));
            if (projectmodel == null)
            {
                return HttpNotFound();
            }

            ProjectViewModel projectviewmodel = Mapper.Map<ProjectViewModel>(projectmodel);
            ViewBag.ProjectTypeRefID = new SelectList(db.ProjectTypes.AsNoTracking().Select(c => new { c.ProjectTypeID, c.ProjectTypeName }), "ProjectTypeID", "ProjectTypeName", projectviewmodel.ProjectTypeRefID);
            return View(projectviewmodel);

        }

        [HttpPost]
        public ActionResult EditProject(ProjectViewModel projectviewmodel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Project projectmodel = Mapper.Map<Project>(projectviewmodel);
                    db.Entry(projectmodel).State = EntityState.Modified;
                    db.SaveChanges();
                    return RedirectToAction("ProjectIndex");
                }
                else
                {
                    ViewBag.ProjectTypeRefID = new SelectList(db.ProjectTypes.AsNoTracking().Select(c => new { c.ProjectTypeID, c.ProjectTypeName }), "ProjectTypeID", "ProjectTypeName", projectviewmodel.ProjectTypeRefID);
                    return View(projectviewmodel);

                }

            }
            catch(Exception e)
            {
                ViewBag.ProjectTypeRefID = new SelectList(db.ProjectTypes.AsNoTracking().Select(c => new { c.ProjectTypeID, c.ProjectTypeName }), "ProjectTypeID", "ProjectTypeName", projectviewmodel.ProjectTypeRefID);
                return View(projectviewmodel);
            }
        }
        
        public ActionResult CustomerIndex()
        {
            var customerindex = db.CustomerIndexes.AsNoTracking().OrderByDescending(a => a.CreationDate);
            return View(customerindex);
        }

        public ActionResult ViewApplication(string applicationid)
        {
            ReportDocument appreport = new ReportDocument();

            appreport.Load(Server.MapPath("~/Reports/ApplicationForm.rpt"));
            appreport.PrintOptions.PaperSize = PaperSize.PaperA4;

            long appid = Convert.ToInt64(applicationid);
            List<CustApplicationReport> appmodel = new List<CustApplicationReport>();
            var customer = db.CustApplicationReports.AsNoTracking().Where(a => a.ApplicationID == appid).FirstOrDefault();
            appmodel.Add(customer);
            appreport.SetDataSource(appmodel);

            Stream stream = appreport.ExportToStream(ExportFormatType.PortableDocFormat);
            appreport.Dispose();
            return File(stream, "application/pdf");

        }

        public ActionResult CustListReceipts(int? page)
        {
            int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["pageSize"]);
            var pageNumber = page ?? 1;
            var AppList = db.ReceiptsAppLists.AsNoTracking().OrderByDescending(c => c.CreationDate);
            return View(AppList.ToPagedList(pageNumber, pageSize));
        }

        [HttpGet]
        public ActionResult CreateReceipts(string applicationid)
        {
            ReceiptsViewModel receiptsviewmodel = new ReceiptsViewModel();
            receiptsviewmodel.CustomerRefID = applicationid;
            receiptsviewmodel.ChequeDate = DateTime.Now;
            receiptsviewmodel.CreationDate = DateTime.Now;
            return View(receiptsviewmodel);
        }

        [HttpPost]
        public ActionResult CreateReceipts(ReceiptsViewModel receiptsviewmodel)
        {
            return View();
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
