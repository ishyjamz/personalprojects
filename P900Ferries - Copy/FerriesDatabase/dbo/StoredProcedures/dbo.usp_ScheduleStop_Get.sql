/*===========================================================================*\ 
Description: 
Retrieves schedule details for specified schedule

Parameters: 
@ScheduleId  INT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_ScheduleStop_Get (
@ScheduleId INT)

AS 
BEGIN 
SELECT   l.Name, l.LocationId, DepartureDay, DepartureTime, ArrivalDay, 
         ArrivalTime, ss.ScheduleId, ScheduleStopId
        
FROM dbo.ScheduleStop ss
INNER JOIN dbo.Location l
ON ss.LocationId = l.LocationId
WHERE   ss.ScheduleId = @ScheduleId
END 
GO 