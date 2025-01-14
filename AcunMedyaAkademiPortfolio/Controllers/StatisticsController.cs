using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class StatisticsController : Controller
    {
        DbPortfolioEntities2 db = new DbPortfolioEntities2();   
        // GET: Statistics
        public ActionResult Index()
        {
            ViewBag.categoryCount = db.TblCategory.Count();
            ViewBag.projectCount = db.TblProject.Count();
            ViewBag.skillCount = db.TblSkill.Count();
            ViewBag.skillValueAvg = db.TblSkill.Average(x => x.Value);
            ViewBag.mvcProjectCount = db.TblProject.Where(x => x.ProjectCategory == 1).Count();
            return View();
        }
    }
}