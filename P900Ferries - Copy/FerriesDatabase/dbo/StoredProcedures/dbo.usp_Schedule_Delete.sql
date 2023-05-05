/*===========================================================================*\ 
Description: 
Deletes existing schedule

Parameters: 
@ScheduleId INT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Schedule_Delete
@ScheduleId INT

AS

DELETE ss
FROM   dbo.ScheduleStop ss
INNER JOIN dbo.Schedule s
ON ss.ScheduleId = s.ScheduleId
WHERE  s.ScheduleId = @ScheduleId

DELETE 
FROM dbo.Schedule
WHERE ScheduleId = @ScheduleId

GO