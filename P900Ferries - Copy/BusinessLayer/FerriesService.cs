using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using Models.Models.FerryModels;
using System.Runtime.ConstrainedExecution;
using DataAccessModels.Models.FerryModels;
using DataAccess;

namespace BusinessLayer
{
    public class FerriesService
    {
        public FerryDataAccess _FerryData = new FerryDataAccess();

        public List<FerrySubModel> ListSearch(string ferryName, string companyName)
        {
            
            var list = _FerryData.ListFerries(ferryName, companyName);
            var presentationList = new List<FerrySubModel>();   
            foreach (var subModel in list)
            {
                presentationList.Add(ConvertToPresentationFerry(subModel));
            }
            return presentationList;
        }
        private static FerrySubModel ConvertToPresentationFerry(ScheduleSubDataModel ferryData)
        {
            return new FerrySubModel()
            {
                FerryId = ferryData.FerryId,
                FerryName = ferryData.FerryName,
                CompanyName = ferryData.CompanyName
            };
        }
        private static FerryViewModel ConvertToPresViewFerry(FerryDataModel ferryData)
        {
            return new FerryViewModel()
            {
                FerryId = ferryData.FerryId,
                Name = ferryData.Name,
                CompanyId = ferryData.CompanyId,
                RowVersion= ferryData.RowVersion
            };
        }
        private static FerryDataModel ConvertToDataFerry(FerryViewModel ferryView)
        {
            return new FerryDataModel()
            {
                FerryId = ferryView.FerryId,
                Name = ferryView.Name,
                CompanyId = ferryView.CompanyId,
                RowVersion = ferryView.RowVersion
            };
        }
        public FerrySubModel GetFerryById(int id)
        {
            var dataFerry = _FerryData.GetFerryById(id);
            var presentationFerry = ConvertToPresentationFerry(dataFerry);
            return presentationFerry;
        }
        public FerryViewModel GetFerryViewById(int id)
        {
            var dataFerry = _FerryData.GetDataFerryById(id);
            var presentationFerry = ConvertToPresViewFerry(dataFerry);
            return presentationFerry;
        }
        public void AddNewFerry(string ferryName, int companyId)
        {
            _FerryData.AddFerryToDatabase(ferryName, companyId);
        }
        public FerryViewModel UpdateFerry(FerryViewModel ferry)
        {
            FerryDataModel dataFerry = _FerryData.UpdateDataFerry(ConvertToDataFerry(ferry));
            FerryViewModel presFerry = ConvertToPresViewFerry(dataFerry);
            return presFerry;
        }
        public void DeleteFerry(int id)
        {
            _FerryData.DeleteDataFerry(id);
        }
    }
}
