using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Library;
using Model_Library;

namespace BusinessLayer
{
    /// <summary>
    /// Contains business logic for finding sightings based on cars and cameras
    /// </summary>
    public class SightingRepository
    {
        /// <summary>
        /// find sightings of each car
        /// </summary>
        /// <param name="carID"></param>
        /// <returns></returns>
        public List<SightingCarPresentation> FindSighting(int carID)
        {
            using (var context = new DVLAEntities1())
            {
                var sightingList = context.Sightings.Select(s =>
                new SightingCarPresentation
                {
                    CarID = s.CarId,
                    RegNumber = s.Car.RegistrationNumber,
                    SightingTime = s.SightingTime,
                    SecondsAfterRedLight = s.SecondsAfterRedLight,
                    Speed = s.SpeedMph,
                    DateIssued = s.Fine.DateIssued,
                    DatePaid = s.Fine.DatePaid
                }).Where(s => s.CarID == carID);
                return sightingList.OrderBy(c => c.SightingTime).ToList();
            }
        }
        /// <summary>
        /// finds sightings made by each camera
        /// </summary>
        /// <param name="cameraID"></param>
        /// <returns></returns>
        public List<SightingCarPresentation> FindCameraSighting(int cameraID)
        {
            using (var context = new DVLAEntities1())
            {
                var sightingList = context.Sightings.Select(s =>
                new SightingCarPresentation
                {
                    CarID = s.CarId,
                    CameraID = s.CameraId,
                    RegNumber = s.Car.RegistrationNumber,
                    SightingTime = s.SightingTime,
                    SecondsAfterRedLight = s.SecondsAfterRedLight,
                    Speed = s.SpeedMph,
                    DateIssued = s.Fine.DateIssued,
                    DatePaid = s.Fine.DatePaid
                }).Where(s => s.CameraID == cameraID);
                return sightingList.OrderBy(c => c.SightingTime).ToList();
            }
        }
    }
}
