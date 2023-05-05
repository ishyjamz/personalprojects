using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;
using Models.Models.FerryModels;
using Models.Models.ScheduleModels;

namespace FerryWebApp.Controllers
{
    public class ScheduleController : Controller
    {
        public ScheduleService _Schedule = new ScheduleService();
        // GET: Schedule

        [Route("Schedule/Create/{ferryId:int}")]
        [HttpGet]
        public ActionResult Create(int ferryId)
        {
            ScheduleViewModel schedule = new ScheduleViewModel
            {
                FerryId = ferryId,
            };
            return View("Create", schedule);
        }
        [HttpPost]
        public ActionResult AddSchedule(ScheduleViewModel schedule)
        {
            _Schedule.AddNewSchedule(schedule.Description, schedule.CostPerPerson,
                schedule.CostPerVehicle, schedule.FerryId);
            return RedirectToAction("Delete", "Ferry", new { id = schedule.FerryId });
        }
        public ActionResult Edit(int id)
        {
            var schedule = _Schedule.GetScheduleById(id);
            return View("Edit", schedule);
        }
        [HttpGet]
        public ActionResult Delete(int id)
        {
            var schedule = _Schedule.GetScheduleById(id);
            schedule.Stops = new ScheduleStop();
            schedule.Stops.ScheduleId = id;
            var list = new List<DayOfTheWeek>
            {
                new DayOfTheWeek { DayId = 0, DayName = "Monday" },
                new DayOfTheWeek { DayId = 1, DayName = "Tuesday" },
                new DayOfTheWeek { DayId = 2, DayName = "Wednesday" },
                new DayOfTheWeek { DayId = 3, DayName = "Thursday" },
                new DayOfTheWeek { DayId = 4, DayName = "Friday" },
                new DayOfTheWeek { DayId = 5, DayName = "Saturday" },
                new DayOfTheWeek { DayId = 6, DayName = "Sunday" }
            };
            schedule.Stops.ArrivalDayList = list;
            schedule.Stops.DepartureDayList = list;
            schedule.Stops.LocationList = _Schedule.GetLocationList();
            schedule.StopsGrid = _Schedule.ListScheduleStops(id);
            return View("Delete", schedule);
        }
        [HttpPost]
        public ActionResult SaveEdit(ScheduleViewModel schedule)
        {
            _Schedule.UpdateSchedule(schedule);
            return RedirectToAction("Delete", "Ferry", new { id = schedule.FerryId });
        }
        public ActionResult Cancel(int ferryId)
        {
            return RedirectToAction("Delete", "Ferry", new { id = ferryId });
        }
        [HttpPost]
        public ActionResult DeleteSchedule(ScheduleViewModel schedule)
        {
            _Schedule.DeleteSchedule(schedule.ScheduleId);
            return RedirectToAction("Delete", "Ferry", new { id = schedule.FerryId });
        }
        [HttpGet]
        public ActionResult DeleteScheduleStop(int scheduleId, int scheduleStopId)
        {
            _Schedule.DeleteScheduleStop(scheduleStopId);
            return RedirectToAction("Delete", "Schedule", new { id = scheduleId });
        }

        public string ConvertDayIdToDay(int dayId)
        {
            string[] days = new string[] {"Monday", "Tuesday", "Wednesday",
                "Thursday", "Friday", "Saturday", "Sunday"};
            return days[dayId];

        }
        public ActionResult OpenModal(ScheduleStop stop)
        {
            
            return PartialView("_AddStop", stop);
        }

        [HttpPost]
        public ActionResult AddStop(ScheduleStop stop)
        {
            if (ModelState.IsValid)
            {
                _Schedule.AddNewScheduleStop(stop);
                return RedirectToAction("Delete", "Schedule", new { id = stop.ScheduleId });
            }
            else
            {
                return RedirectToAction("Delete", "Schedule", new { id = stop.ScheduleId });
            }
        }
    }
}
