using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLogic.DriverLogic;
using BusinessLogic.GeneralLogic;
using BusinessLogic.MileBalanceLogic;
using BusinessLogic.PassengerLogic;
using Microsoft.AspNet.Identity;
using PresentationModels.Login;
using PresentationModels.MileBalance;

namespace CarShareApp.Controllers
{
    /// <summary>
    /// Handles the mile balance page
    /// </summary>
    [Authorize]
    public class MileBalanceController : BaseController
    {
        private MileBalanceService _MileBalance = new MileBalanceService();

        /// <summary>
        /// Calculates the miles as driver, miles as passenger, overall balance and
        /// balance with each user and returns a list of all the mileage balances 
        /// </summary>
        /// <returns></returns>
        public ActionResult MileBalance()
        {
            var milebalance = new MileBalance
            {
                MileBalanceGrid = _MileBalance.ListMileBalance(),
            };
            foreach (var item in milebalance.MileBalanceGrid)
            {
                item.DriverStops = _MileBalance.ListJourneyStops(ApplicationUser.UserId, item.User.UserId);
                item.PassengerStops = _MileBalance.ListJourneyStops(item.User.UserId, ApplicationUser.UserId);
                for (int i = 0; i < item.DriverStops.Count; i++)
                {
                    item.MilesAsDriver += item.DriverStops[i].Location.DistanceToWork;
                }
                for (int i = 0; i < item.PassengerStops.Count; i++)
                {
                    item.MilesAsPassenger += item.PassengerStops[i].Location.DistanceToWork;
                }
                item.Total = item.MilesAsDriver - item.MilesAsPassenger;
            }
            for (int i = 0; i < milebalance.MileBalanceGrid.Count; i++)
            {
                milebalance.OverallBalance += milebalance.MileBalanceGrid[i].Total;
            }
            return View(milebalance);
        }
    }
}
