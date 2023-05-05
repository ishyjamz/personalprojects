using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using Entity_Library;
using Model_Library;

namespace BusinessLayer
{
    public class CameraRepository
    {
        /// <summary>
        /// Populates camera data grid with cameras based on filters
        /// </summary>
        /// <param name="roadName"></param>
        /// <param name="roadNumber"></param>
        /// <param name="longitudeFrom"></param>
        /// <param name="longitudeTo"></param>
        /// <param name="latitudeFrom"></param>
        /// <param name="latitudeTo"></param>
        /// <returns></returns>
        public List<CameraPresentation> CameraSearch(string roadName, string roadNumber,
            decimal? longitudeFrom, decimal? longitudeTo, 
            decimal? latitudeFrom, 
            decimal? latitudeTo)
        {
            using (var context = new DVLAEntities1())
            {
                var cameraList = context.Cameras.Select(c =>
                new CameraPresentation
                {
                    CameraId = c.CameraId,
                    RoadName = c.RoadName,
                    RoadNumber = c.RoadNumber,
                    Longitude = c.Longitude,
                    Latitude = c.Latitude,
                    AddressId = c.AddressId,
                    SpeedThreshold = c.SpeedCamera.SpeedMphLimit,
                    TimeThreshold = c.TrafficLightCamera.SecondsAfterRedLightThreshold,
                    Line1 = c.Address.Line1
                });
                if (!String.IsNullOrWhiteSpace(roadName))
                {
                    cameraList = cameraList.Where(c => c.RoadName == roadName);
                }
                if (!String.IsNullOrWhiteSpace(roadNumber))
                {
                    cameraList = cameraList.Where(c => c.RoadNumber == roadNumber);
                }
                if (longitudeTo != null || longitudeFrom != null)
                {
                    cameraList = cameraList.Where(c => c.Longitude > longitudeFrom)
                        .Where(c => c.Longitude < longitudeTo);
                }
                if (latitudeTo != null || latitudeFrom != null)
                {
                    cameraList = cameraList.Where(c => c.Latitude > latitudeFrom)
                        .Where(c => c.Latitude < latitudeTo);
                }
                return cameraList.OrderBy(c => c.RoadName).ToList();
            }
        }
        /// <summary>
        /// updates camera details to database
        /// </summary>
        /// <param name="cameraModel"></param>
        /// <returns></returns>
        public Camera UpdateCameraDetails(CameraPresentation cameraModel)
        {
            using (var context = new DVLAEntities1())
            {
                Camera camera = new Camera();
                camera = context.Cameras.Find(cameraModel.CameraId);
                camera.RoadName = cameraModel.RoadName;
                camera.RoadNumber = cameraModel.RoadNumber;
                camera.AddressId = cameraModel.AddressId;
                camera.Longitude = cameraModel.Longitude;
                camera.Latitude = cameraModel.Latitude;
                if (cameraModel.CameraType == "Speed Camera")
                {
                    SpeedCamera speedCam = context.SpeedCameras.Find(cameraModel.CameraId);
                    speedCam.SpeedMphLimit = (byte)cameraModel.SpeedThreshold;
                }
                else if (cameraModel.CameraType == "Traffic Light Camera")
                {
                    TrafficLightCamera trafficLightCam = context.TrafficLightCameras.Find(cameraModel.CameraId);
                    trafficLightCam.SecondsAfterRedLightThreshold = (byte)cameraModel.TimeThreshold;
                }
                context.SaveChanges();
                return camera;
            }
        }
        /// <summary>
        /// Adds new camera to database
        /// </summary>
        /// <param name="cameraModel"></param>
        /// <returns></returns>
        public Camera AddNewCamera(CameraPresentation cameraModel)
        {
            using (var context = new DVLAEntities1())
            {
                Camera camera = new Camera();
                camera.AddressId = cameraModel.AddressId;
                camera.RoadName = cameraModel.RoadName;
                camera.RoadNumber = cameraModel.RoadNumber;
                camera.Longitude = cameraModel.Longitude;
                camera.Latitude = cameraModel.Latitude;
                if (cameraModel.CameraType == "Speed Camera" && cameraModel.SpeedThreshold != null)
                {
                    camera.SpeedCamera = new SpeedCamera();
                    camera.SpeedCamera.SpeedMphLimit = (byte)cameraModel.SpeedThreshold;
                    context.Cameras.Add(camera);
                    context.SaveChanges();
                }
                else if (cameraModel.CameraType == "Traffic Light Camera" && cameraModel.TimeThreshold != null)
                {
                    camera.TrafficLightCamera = new TrafficLightCamera();
                    camera.TrafficLightCamera.SecondsAfterRedLightThreshold = 
                        (byte)cameraModel.TimeThreshold;
                    context.Cameras.Add(camera);
                    context.SaveChanges();
                }
                else if (cameraModel.CameraType == "ANPR Camera")
                {
                    context.Cameras.Add(camera);
                    context.SaveChanges();
                }
  
                return camera;
            }
        }
    }
}
