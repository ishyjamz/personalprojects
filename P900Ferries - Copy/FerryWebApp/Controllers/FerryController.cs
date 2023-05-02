using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataAccess;
using Models.Models;
using Models.Models.FerryModels;

namespace FerryWebApp.Controllers
{
    [Authorize(Roles = "Employee")]
    public class FerryController : Controller
    {
        public FerryViewModel _FerryModel = new FerryViewModel();   
        public FerriesService _Ferry = new FerriesService();
        public CompanyService _Company = new CompanyService();
        public ScheduleService _Schedule = new ScheduleService();
        private string _ConnectionString = ConfigurationManager
             .ConnectionStrings["DefaultConnection"].ConnectionString;
        // GET: Ferry
        public ActionResult List(FerryViewModel ferry)
        {
            if (ferry == null)
            {
                return View(new FerryViewModel());
            }
            else
            {

                return View(ferry);
            }
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PopulateGrid(FerryViewModel ferry)
        {
           
            ferry.FerryGrid = _Ferry.ListSearch(ferry.Name, ferry.Company.Name);
            return View("List", ferry);
        }

        [HttpGet]
        public ActionResult PopulateTextboxes(int id)
        {
            var ferry = _Ferry.GetFerryById(id);
            return RedirectToAction("Delete", ferry);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var ferry = _Ferry.GetFerryViewById(id);
            ferry.Companies = _Company.GetCompanyList();
            return View("Edit", ferry);
        }

        [HttpGet]
        public ActionResult OpenAddPage()
        {
            return RedirectToAction("Create", "Ferry");
        }

        [HttpGet]
        public ActionResult Create()
        {
            var ferryModel = new FerryViewModel();
            ferryModel.Companies = _Company.GetCompanyList();
            return View("Create", ferryModel);
        }

        [HttpPost]
        public ActionResult AddFerry(FerryViewModel ferry)
        {
            if (ModelState.IsValid)
            {
                _Ferry.AddNewFerry(ferry.Name, ferry.CompanyId);
                return RedirectToAction("List");
            }
            else
            {
                ferry.Companies = _Company.GetCompanyList();
                return View("Create", ferry);
            }
        }

        [HttpPost]
        public ActionResult SaveEditFerry(FerryViewModel ferry)
        {
            _Ferry.UpdateFerry(ferry);
            return RedirectToAction("Delete", new {id = ferry.FerryId});
        }
        [HttpGet]
        [Route("Ferry/Delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            var ferry = _Ferry.GetFerryViewById(id);
            ferry.ScheduleGrid = _Schedule.ListSchedules(id);
            ferry.Companies = _Company.GetCompanyList();

            return View("Delete", ferry);
        }
        [HttpPost]
        public ActionResult DeleteFerry(FerryViewModel ferry)
        {
            _Ferry.DeleteFerry(ferry.FerryId);
            return RedirectToAction("List");
        }
    }
}
