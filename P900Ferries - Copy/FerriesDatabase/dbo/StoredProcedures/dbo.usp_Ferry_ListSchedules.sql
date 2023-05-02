/*===========================================================================*\ 
Description: 
Lists all the schedules for one ferry
Parameters: 
@FerryId INT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Ferry_ListSchedules
@FerryId INT

AS 
BEGIN
SELECT ScheduleId, Description, CostPerPerson, CostPerVehicle
FROM   dbo.Schedule
WHERE  FerryId = @FerryId
END
GO
