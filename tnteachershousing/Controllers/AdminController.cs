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
using CrystalDecisions.ReportAppServer.DataDefModel;
using System.Threading.Tasks;
using tnteachershousing.ActionFilters;

namespace tnteachershousing.Controllers
{

    [RequireHttps]
    public class AdminController : Controller
    {
        private techearDBContext db = new techearDBContext();
        // GET: Admin
        [AuthorizeRedirect(Roles ="Browser , Administrator")]
        public ActionResult Index()
        {   
            if(Request.IsAuthenticated)
            {     
            ViewBag.FromController = "Administration Home";
            return View();
            }
            
            return RedirectToAction("Login", "Account", new { @returnUrl = "/Admin/Index" });
        }
        [AuthorizeRedirect(Roles = "Browser, Administrator")]
        public ActionResult ProjectIndex(int? page)
        {
            int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["pageSize"]);
            var pageNumber = page ?? 1;

            var projectlist = db.ProjectIndexes.AsNoTracking().OrderBy(p => p.ProjectID);
            return View(projectlist.ToPagedList(pageNumber,pageSize));
        }

        [AuthorizeRedirect(Roles = "Administrator")]
        [HttpGet]
        public ActionResult CreateProject()
        {
            ViewBag.ProjectTypeRefID = new SelectList(db.ProjectTypes.AsNoTracking().Select(c => new { c.ProjectTypeID, c.ProjectTypeName }), "ProjectTypeID", "ProjectTypeName");
            return View();
        }
        [AuthorizeRedirect(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateProject(ProjectViewModel projectviewmodel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    projectviewmodel.CreationDate = DateTime.Now;
                    Project projectmodel = Mapper.Map<Project>(projectviewmodel);
                    db.Projects.Add(projectmodel);
                    await db.SaveChangesAsync();
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
                ModelState.AddModelError("", e.Message);
                return View();
            }
        }

        
        [AuthorizeRedirect(Roles = "Administrator")]
        [HttpGet]
        public ActionResult EditProject(int? applicationid)
        {
            if (applicationid == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Project projectmodel = db.Projects.Find(Convert.ToInt32(applicationid));
            if (projectmodel == null)
            {
                return HttpNotFound();
            }

            ProjectViewModel projectviewmodel = Mapper.Map<ProjectViewModel>(projectmodel);
            ViewBag.ProjectTypeRefID = new SelectList(db.ProjectTypes.AsNoTracking().Select(c => new { c.ProjectTypeID, c.ProjectTypeName }), "ProjectTypeID", "ProjectTypeName", projectviewmodel.ProjectTypeRefID);
            return View(projectviewmodel);

        }

        [AuthorizeRedirect(Roles = "Administrator")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditProject(ProjectViewModel projectviewmodel)
        {
            try
            {
                if(ModelState.IsValid)
                {
                    Project projectmodel = Mapper.Map<Project>(projectviewmodel);
                    db.Entry(projectmodel).State = EntityState.Modified;
                    await db.SaveChangesAsync();
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
                ModelState.AddModelError("", e.Message);
                return View(projectviewmodel);
            }
        }

        [AuthorizeRedirect(Roles = "Browser, Administrator")]
        public ActionResult CustomerIndex(int? page)
        {
            int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["pageSize"]);
            var pageNumber = page ?? 1;

            var customerindex = db.CustomerIndexes.AsNoTracking().OrderByDescending(a => a.CreationDate);
            return View(customerindex.ToPagedList(pageNumber,pageSize));
        }

        [AuthorizeRedirect(Roles = "Browser, Administrator")]
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

        [AuthorizeRedirect(Roles = "Browser, Administrator")]
        public ActionResult CustListReceipts(int? page)
        {
            int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["pageSize"]);
            var pageNumber = page ?? 1;
            var AppList = db.ReceiptsAppLists.AsNoTracking().OrderByDescending(c => c.CreationDate);
            return View(AppList.ToPagedList(pageNumber, pageSize));
        }

        [AuthorizeRedirect(Roles = "Administrator")]
        [HttpGet]
        public ActionResult CreateReceipts(string applicationid)
        {
            ReceiptsViewModel receiptsviewmodel = new ReceiptsViewModel();
            DateTime utcTime = DateTime.UtcNow;

            string zoneID = "India Standard Time";

            TimeZoneInfo myZone = TimeZoneInfo.FindSystemTimeZoneById(zoneID);
            DateTime custDateTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, myZone);

            receiptsviewmodel.CustomerRefID = applicationid;
            //receiptsviewmodel.ChequeDate = custDateTime;
            receiptsviewmodel.CreationDate = custDateTime;
            return View(receiptsviewmodel);
        }
        [NoCache]
        [AllowAnonymous]
        [HttpGet]
        public ActionResult CustomerReceipts()
        {
            ReceiptsViewModel receiptsviewmodel = new ReceiptsViewModel();
            DateTime utcTime = DateTime.UtcNow;

            string zoneID = "India Standard Time";

            TimeZoneInfo myZone = TimeZoneInfo.FindSystemTimeZoneById(zoneID);
            DateTime custDateTime = TimeZoneInfo.ConvertTimeFromUtc(utcTime, myZone);

            //receiptsviewmodel.ChequeDate = custDateTime;
            receiptsviewmodel.CreationDate = custDateTime;
            return View(receiptsviewmodel);
       }
        [AllowAnonymous]
        public JsonResult GetCustomerInfo(string applicationid)
        {
            
            var customer = db.CustomerApplicationForms.Where(s => s.CustomerID == applicationid).Select(c => new { Name = c.NameOfapplicant, Relatedto = c.SonOfWifeOfGuardian, Address = c.DoorFlatNo + "  " + c.Street, City = c.City, State = c.StatePinCode }).ToList();
            return Json(customer, JsonRequestBehavior.AllowGet);
        }
        [AllowAnonymous]
        [HttpPost]
        public ActionResult CustomerReceipts(ReceiptsViewModel receiptsviewmodel)
        {
            try
            {
                long appid = db.CustomerApplicationForms.AsNoTracking().Where(c => c.CustomerID == receiptsviewmodel.CustomerRefID).Select(a => a.ApplicationID).SingleOrDefault();
                if(appid == 0)
                {
                    ModelState.AddModelError("", "Invalid Customer ID");

                }
 
                if (ModelState.IsValid)
                {
                    Receipts receipts = Mapper.Map<Receipts>(receiptsviewmodel);
                    receipts.ApplicationRefID = appid;
                    db.Receipts.Add(receipts);
                    db.SaveChanges();

                    return RedirectToAction("ShowReceipts", "Admin", new { applicationid = receipts.ReceiptID });

                }
                else
                {
                    return View();
                }

            }
            catch (Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }

        }

        [AuthorizeRedirect(Roles = "Administrator")]
        [HttpPost]
        public ActionResult CreateReceipts(ReceiptsViewModel receiptsviewmodel)
        {   
            try
            {
                if(ModelState.IsValid)
                {
                    var appid = db.CustomerApplicationForms.AsNoTracking().Where(c => c.CustomerID == receiptsviewmodel.CustomerRefID).Select(a => a.ApplicationID).FirstOrDefault();
                    
                    Receipts receipts = Mapper.Map<Receipts>(receiptsviewmodel);
                    receipts.ApplicationRefID = appid;
                    db.Receipts.Add(receipts);
                    db.SaveChanges();

                    return RedirectToAction("ShowReceipts", "Admin", new { applicationid = receipts.ReceiptID});
                    
                }
                else
                {
                    return View();
                }

            }
            catch(Exception e)
            {
                ModelState.AddModelError("", e.Message);
                return View();
            }
            
        }
        [AuthorizeRedirect(Roles = "Browser, Administrator")]
        public ActionResult ReceiptsIndex(int? page)
        {
            int pageSize = Convert.ToInt32(ConfigurationManager.AppSettings["pageSize"]);
            var pageNumber = page ?? 1;
            var receipts = db.Receipts.AsNoTracking().OrderByDescending(d => d.CreationDate);
            IEnumerable<ReceiptsViewModel> receiptsviewmodel = Mapper.DynamicMap<IEnumerable<ReceiptsViewModel>>(receipts);
            return View(receiptsviewmodel.ToPagedList(pageNumber,pageSize));
        }

        [AllowAnonymous]
        public ActionResult ShowReceipts(long applicationid)
        {
            ReportDocument receiptreport = new ReportDocument();
            var httpctx = System.Web.HttpContext.Current;
            receiptreport.Load(httpctx.Server.MapPath("~/Reports/Receipt.rpt"));

            receiptreport.PrintOptions.PaperSize = PaperSize.PaperA4;
            receiptreport.SetParameterValue("ReceiptID", applicationid);

            return File(genericReportSetting(receiptreport, httpctx), "application/pdf");


        }

        private Stream genericReportSetting(ReportDocument report, HttpContext httpctx)
        {   
           
            PropertyBag connectionAttributes = new PropertyBag();
            connectionAttributes.Add("Auto Translate", "-1");
            connectionAttributes.Add("Connect Timeout", "15");
            connectionAttributes.Add("Data Source", ConfigurationManager.AppSettings["Server"]);
            connectionAttributes.Add("General Timeout", "0");
            connectionAttributes.Add("Initial Catalog", ConfigurationManager.AppSettings["Database"]);
            connectionAttributes.Add("Integrated Security", false);
            connectionAttributes.Add("Locale Identifier", "1040");
            connectionAttributes.Add("OLE DB Services", "-5");
            connectionAttributes.Add("Provider", "SQLOLEDB");
            connectionAttributes.Add("Tag with column collation when possible", "0");
            connectionAttributes.Add("Use DSN Default Properties", false);
            connectionAttributes.Add("Use Encryption for Data", "0");
            
            PropertyBag attributes = new PropertyBag();
            attributes.Add("Database DLL", "crdb_ado.dll");
            attributes.Add("QE_DatabaseName", ConfigurationManager.AppSettings["Database"]);
            attributes.Add("QE_DatabaseType", "OLE DB (ADO)");
            attributes.Add("QE_LogonProperties", connectionAttributes);
            attributes.Add("QE_ServerDescription", httpctx.Server);
            attributes.Add("QESQLDB", true);
            attributes.Add("SSO Enabled", false);

            CrystalDecisions.ReportAppServer.DataDefModel.ConnectionInfo ci = new CrystalDecisions.ReportAppServer.DataDefModel.ConnectionInfo();
            ci.Attributes = attributes;
            ci.Kind = CrConnectionInfoKindEnum.crConnectionInfoKindCRQE;
            ci.UserName = ConfigurationManager.AppSettings["UserID"];
            ci.Password = ConfigurationManager.AppSettings["Password"];

            foreach (CrystalDecisions.ReportAppServer.DataDefModel.Table table in report.ReportClientDocument.DatabaseController.Database.Tables)
            {
                CrystalDecisions.ReportAppServer.DataDefModel.Procedure newTable = new CrystalDecisions.ReportAppServer.DataDefModel.Procedure();

                newTable.ConnectionInfo = ci;
                newTable.Name = table.Name;
                newTable.Alias = table.Alias;
                newTable.QualifiedName = ConfigurationManager.AppSettings["Database"] + ".dbo." + table.Name;
                report.ReportClientDocument.DatabaseController.SetTableLocation(table, newTable);
            }


            Stream stream = report.ExportToStream(ExportFormatType.PortableDocFormat);
            report.Dispose();
            return stream;
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
