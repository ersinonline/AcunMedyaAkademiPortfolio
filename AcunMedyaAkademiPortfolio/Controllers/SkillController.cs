using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class SkillController : Controller
    {
        DbPortfolioEntities2 db = new DbPortfolioEntities2();
        public ActionResult Index()
        {
           var values =  db.TblSkill.ToList();
            return View(values);
        }

        [HttpGet]
        public ActionResult CreateSkill()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CreateSkill(TblSkill p)
        {
            db.TblSkill.Add(p);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteSkill(int id)
        {

            var value = db.TblSkill.Find(id);
            db.TblSkill.Remove(value);

            db.SaveChanges();
            return RedirectToAction("Index");


        }

        public ActionResult UpdateSkill(int id)
        {
            var value = db.TblSkill.Find(id);
            return View(value);

        
        
        }

    }
}