using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using DataAccessModels.Models.FerryModels;
using DataAccessModels.Models.ScheduleModels;
using Models.Models.FerryModels;
using Models.Models.ScheduleModels;

namespace BusinessLayer
{
    public class ScheduleService
    {
        private ScheduleDataAccess _ScheduleData = new ScheduleDataAccess();

        public ScheduleViewModel ConvertToPresSchedule(ScheduleDataModel scheduleData)
        {
            var schedule = new ScheduleViewModel
            {
                ScheduleId = scheduleData.ScheduleId,
                FerryId = scheduleData.FerryId,
                Description = scheduleData.Description,
                CostPerPerson = scheduleData.CostPerPerson,
                CostPerVehicle = scheduleData.CostPerVehicle

            };
            return schedule;
        }
        public ScheduleViewModel ConvertToPresViewSchedule(ScheduleDataModel scheduleData)
        {
            var schedule = new ScheduleViewModel
            {
                ScheduleId = scheduleData.ScheduleId,
                FerryId = scheduleData.FerryId,
                Description = scheduleData.Description,
                CostPerPerson = scheduleData.CostPerPerson,
                CostPerVehicle = scheduleData.CostPerVehicle,
                RowVersion = scheduleData.RowVersion,
            };
            return schedule;
        }
        public string ConvertDayIdToDay(int dayId)
        {
            string[] days = new string[] {"Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "Sunday"};
            return days[dayId];

        }
        public ScheduleStop ConvertToPresScheduleStop(ScheduleStopData scheduleStopData)
        {
            var scheduleStop = new ScheduleStop
            {
                ScheduleStopId = scheduleStopData.ScheduleStopId,
                DepartureDay = new DayOfTheWeek
                {
                    DayId = scheduleStopData.DepartureDay,
                    DayName = ConvertDayIdToDay(scheduleStopData.DepartureDay)
                },
                DepartureTime = scheduleStopData.DepartureTime,
                ArrivalDay = new DayOfTheWeek
                {
                    DayId = scheduleStopData.ArrivalDay,
                    DayName = ConvertDayIdToDay(scheduleStopData.ArrivalDay)
                },
                ArrivalTime = scheduleStopData.ArrivalTime,
                Location = new Location()
                {
                    LocationId = scheduleStopData.Location.LocationId,
                    Name = scheduleStopData.Location.Name,
                }
            };
            return scheduleStop;
        }
        public ScheduleStop ConvertToPresentationScheduleStop(ScheduleStopData scheduleStopData)
        {
            var scheduleStop = new ScheduleStop
            {
                ScheduleStopId = scheduleStopData.ScheduleStopId,
                DepartureDay = new DayOfTheWeek
                {
                    DayId = scheduleStopData.DepartureDay,
                    DayName = ConvertDayIdToDay(scheduleStopData.DepartureDay)
                },
                DepartureTime = scheduleStopData.DepartureTime,
                ArrivalDay = new DayOfTheWeek
                {
                    DayId = scheduleStopData.ArrivalDay,
                    DayName = ConvertDayIdToDay(scheduleStopData.ArrivalDay)
                },
                ArrivalTime = scheduleStopData.ArrivalTime,
                LocationId = scheduleStopData.LocationId
            };
            return scheduleStop;
        }
        public ScheduleStopData ConvertToDataScheduleStop(ScheduleStop scheduleStop)
        {
            var scheduleStopData = new ScheduleStopData
            {
                ScheduleStopId = scheduleStop.ScheduleStopId,
                ScheduleId = scheduleStop.ScheduleId,
                DepartureDay = scheduleStop.DepartureDay.DayId,
                DepartureTime = scheduleStop.DepartureTime,
                ArrivalDay = scheduleStop.ArrivalDay.DayId,
                ArrivalTime = scheduleStop.ArrivalTime,
                Location = new LocationData()
                {
                    LocationId = scheduleStop.Location.LocationId,
                    Name = scheduleStop.Location.Name,
                }
            };
            return scheduleStopData;
        }
        public void AddNewSchedule(string description, decimal costPerPerson,
            decimal costPerVehicle, int ferryId)
        {
            _ScheduleData.AddScheduleToDatabase(description, costPerPerson,
                costPerVehicle, ferryId);
        }
        public void AddNewScheduleStop(ScheduleStop schedule)
        {
            _ScheduleData.AddScheduleStop(ConvertToDataScheduleStop(schedule));
        }
        public List<ScheduleViewModel> ListSchedules(int ferryId)
        {

            var list = _ScheduleData.ListSchedules(ferryId);
            var presentationList = new List<ScheduleViewModel>();
            foreach (var model in list)
            {
                presentationList.Add(ConvertToPresSchedule(model));
            }
            return presentationList;
        }
        public List<ScheduleStop> ListScheduleStops(int scheduleId)
        {

            var list = _ScheduleData.ListScheduleStops(scheduleId);
            var presentationList = new List<ScheduleStop>();
            foreach (var model in list)
            {
                presentationList.Add(ConvertToPresScheduleStop(model));
            }
            return presentationList;
        }
        public ScheduleViewModel GetScheduleById(int id)
        {
            var dataSchedule = _ScheduleData.GetDataScheduleById(id);
            var presentationSchedule = ConvertToPresViewSchedule(dataSchedule);
            return presentationSchedule;
        }
        private static ScheduleDataModel ConvertToDataSchedule(ScheduleViewModel schedule)
        {
            return new ScheduleDataModel()
            {
                ScheduleId = schedule.ScheduleId,
                FerryId = schedule.FerryId,
                Description = schedule.Description,
                CostPerPerson = schedule.CostPerPerson,
                CostPerVehicle = schedule.CostPerVehicle,
                RowVersion = schedule.RowVersion
            };
        }
        public ScheduleViewModel UpdateSchedule(ScheduleViewModel schedule)
        {
            var dataSchedule = _ScheduleData.UpdateDataSchedule(ConvertToDataSchedule(schedule));
            var presSchedule = ConvertToPresViewSchedule(dataSchedule);
            return presSchedule;
        }
        public void DeleteSchedule(int id)
        {
            _ScheduleData.DeleteDataSchedule(id);
        }
        public List<Location> GetLocationList()
        {
            var list = _ScheduleData.ListLocations();
            var preslist = new List<Location>();
            foreach (var model in list)
            {
                preslist.Add(ConvertToPresentationLocation(model));
            }
            return preslist;
        }
        public void DeleteScheduleStop(int id)
        {
            _ScheduleData.DeleteDataScheduleStop(id);
        }

        private static Location ConvertToPresentationLocation(LocationData locationData)
        {
            return new Location()
            {
                LocationId = locationData.LocationId,
                Name = locationData.Name
            };
        }
    }
}
