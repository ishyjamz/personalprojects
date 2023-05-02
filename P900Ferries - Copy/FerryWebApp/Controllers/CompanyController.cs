using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using DataAccess;
using Models.Models;
using Models.Models.CompanyModels;
using Models.Models.FerryModels;

namespace FerryWebApp.Controllers
{
    [Authorize(Roles = "Employee")]
    public class CompanyController : Controller
    {
        public CompanyService _Company = new CompanyService();
        public FerriesService _Ferry = new FerriesService();

        [HttpPost]
        public ActionResult SaveEditCompany(CompanyViewModel company)
        {
            _Company.UpdateCompany(company);
            return RedirectToAction("Delete", new {id = company.CompanyId});
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var company = _Company.GetCompanyById(id);
            return View("Edit", company);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PopulateGrid(CompanyViewModel company)
        {

            company.CompanyGrid = _Company.ListSearch(company.Name);
            return View("List", company);
        }

        [HttpGet]
        [Route("Company/Delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            var company = _Company.GetCompanyById(id);
            company.FerryGrid = _Company.ListFerriesByCompanyId(id);
            return View("Delete", company);
        }
        [HttpPost]
        public ActionResult DeleteCompany(CompanyViewModel company)
        {
            if (company.FerryGrid== null)
            {
                _Company.DeleteCompany(company.CompanyId);
            }
            return RedirectToAction("List");

        }
        public ActionResult List(CompanyViewModel company)
        {
            if (company == null)
            {
                return View("List", new CompanyViewModel());
            }
            else
            {

                return View("List", company);
            }
        }
        public ActionResult Create()
        {
            return View("Create");
        }
        public ActionResult AddCompany(CompanyViewModel company) 
        {
            if (ModelState.IsValid)
            {
                _Company.AddCompany(company);
                return RedirectToAction("Delete", new {id = company.CompanyId});
            }
            else
            {
                return View("Create", company);
            }    
        }
        public ActionResult Edit()
        {
            return View("Edit");
        }
        public ActionResult OpenEditPage()
        {
            return View("Edit");
        }
        public ActionResult OpenAddPage()
        {
            return View("Create");
        }
        public ActionResult Delete()
        {
            return View("Delete");
        }
        public ActionResult Cancel()
        {
            return View("Create");
        }
    }
}
