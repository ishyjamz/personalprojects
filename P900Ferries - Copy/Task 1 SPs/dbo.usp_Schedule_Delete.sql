/*===========================================================================*\ 
Description: 
Deletes existing schedule

Parameters: 
@ScheduleId INT

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Schedule_Delete') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Schedule_Delete
END
GO
CREATE PROCEDURE dbo.usp_Schedule_Delete
@ScheduleId INT

AS
BEGIN
DELETE 
FROM   dbo.Schedule
WHERE  ScheduleId = @ScheduleId
END
GO