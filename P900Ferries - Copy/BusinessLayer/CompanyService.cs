using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessModels.Models.CompanyModels;
using DataAccessModels.Models.FerryModels;
using Models.Models.CompanyModels;
using Models.Models.FerryModels;
using Models.Models.ScheduleModels;

namespace DataAccess
{
    public class CompanyService
    {
        public CompanyDataAccess _CompanyData = new CompanyDataAccess();

        public CompanyViewModel UpdateCompany(CompanyViewModel company)
        {
            CompanyDataModel dataCompany = _CompanyData.UpdateDataCompany(ConvertToDataCompany(company));
            CompanyViewModel presCompany = ConvertToPresentationCompany(dataCompany);
            return presCompany;
        }
        public CompanyViewModel GetCompanyById(int id)
        {
            var dataCompany = _CompanyData.GetDataCompanyById(id);
            var presentationCompany = ConvertToPresentationCompany(dataCompany);
            return presentationCompany;
        }
        public List<CompanyViewModel> GetCompanyList()
        {
            var list = _CompanyData.GetCompanyList();
            var preslist = new List<CompanyViewModel>();    
            foreach(var model in list)
            {
                preslist.Add(ConvertToPresentationCompany(model));    
            }
            return preslist;    
        }
        private static CompanyViewModel ConvertToPresentationCompany(CompanyDataModel companyData)
        {
            return new CompanyViewModel()
            {
                CompanyId = companyData.CompanyId,
                Name = companyData.Name,
                RowVersion = companyData.RowVersion
            };
        }
        public void AddCompany(CompanyViewModel company)
        {
            _CompanyData.AddCompanyToDatabase(ConvertToDataCompany(company));
        }
        public CompanyDataModel ConvertToDataCompany(CompanyViewModel company)
        {
            return new CompanyDataModel()
            {
                Name = company.Name,
                RowVersion = company.RowVersion,
                CompanyId= company.CompanyId,
            };
        }
        public List<FerryModelForGrid> ListFerriesByCompanyId(int companyId)
        {

            var list = _CompanyData.ListFerriesForGrid(companyId);
            var presentationList = new List<FerryModelForGrid>();
            foreach (var model in list)
            {
                presentationList.Add(ConvertToPresentationFerry(model));
            }
            return presentationList;
        }
        private static FerryModelForGrid ConvertToPresentationFerry(FerryDataForGrid ferryData)
        {
            return new FerryModelForGrid()
            {
                FerryId = ferryData.FerryId,
                FerryName = ferryData.FerryName,
                CompanyId= ferryData.CompanyId,
                RowVersion= ferryData.RowVersion,
            };
        }
        public void DeleteCompany(int id)
        {
            _CompanyData.DeleteDataCompany(id);
        }
        public List<CompanyViewModel> ListSearch(string companyName)
        {

            var list = _CompanyData.ListCompanies(companyName);
            var presentationList = new List<CompanyViewModel>();
            foreach (var subModel in list)
            {
                presentationList.Add(ConvertToPresentationCompany(subModel));
            }
            return presentationList;
        }
    }
}
