using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;
namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class ProjectController : Controller
    {
        DbPortfolioEntities2 db = new DbPortfolioEntities2();
        public ActionResult Index()
        {
            var values = db.TblProject.ToList();
            return View(values);
        }
        [HttpGet]
        public ActionResult UpdateProject(int id)
        {
            var values = db.TblProject.Find(id);
            return View(values);
        }

        [HttpPost]
        public ActionResult UpdateProject(TblProject p)
        {
            var values = db.TblProject.Find(p.ProjectId);
            values.ProjectName = p.ProjectName;
            values.ProjectImageUrl = p.ProjectImageUrl;
            values.ProjectCategory = p.ProjectCategory;
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult DeleteProject(int id)
        {
            var values = db.TblProject.Find(id);
            db.TblProject.Remove(values);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]

        public ActionResult CreateProject()
        {
            return View();
        }   

        [HttpPost]

        public ActionResult CreateProject(TblProject p)
        {
            db.TblProject.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        

       
    }
}