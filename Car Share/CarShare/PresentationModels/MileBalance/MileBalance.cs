using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationModels.Driver;
using PresentationModels.Login;

namespace PresentationModels.MileBalance
{
    public class MileBalance
    {
        public int UserId { get; set; }
        public int MilesAsDriver { get; set; }
        public int MilesAsPassenger { get; set; }
        public int Total { get; set; }

        public int OverallBalance { get; set; }

        public PresUser User { get; set; }
        public List<MileBalance> MileBalanceGrid { get; set; }
        public List<JourneyStop> DriverStops { get; set; }
        public List<JourneyStop> PassengerStops { get; set; }
    }
}
