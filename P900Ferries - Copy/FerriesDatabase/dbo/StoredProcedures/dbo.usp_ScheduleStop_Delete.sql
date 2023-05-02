/*===========================================================================*\ 
Description: 
Deletes existing schedule

Parameters: 
@ScheduleId INT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_ScheduleStop_Delete
@ScheduleStopId INT

AS

DELETE dbo.ScheduleStop
FROM   dbo.ScheduleStop
WHERE  ScheduleStopId = @ScheduleStopId
