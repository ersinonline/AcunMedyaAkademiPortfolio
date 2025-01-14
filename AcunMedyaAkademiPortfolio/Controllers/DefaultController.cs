using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AcunMedyaAkademiPortfolio.Models;

namespace AcunMedyaAkademiPortfolio.Controllers
{
    public class DefaultController : Controller
    {
        DbPortfolioEntities2 db = new DbPortfolioEntities2();
        
        public ActionResult Index()
        {
            return View();
        }
        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialFeature()
        {
            var values = db.TblFeature.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAbout()
        {
            var values = db.TblAbout.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkills()
        {
            var values = db.TblSkill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialServices()
        {
            var values = db.TblService.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialProjects()
        {
            var values = db.TblProject.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialTestimonials()
        {
            var values = db.TblTestimonial.ToList();
            return PartialView(values);
        }
    }
}