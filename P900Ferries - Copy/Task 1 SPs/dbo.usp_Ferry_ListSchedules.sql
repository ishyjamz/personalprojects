/*===========================================================================*\ 
Description: 
Lists all the schedules for one ferry
Parameters: 
@FerryId INT

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Ferry_ListSchedules') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Ferry_ListSchedules
END
GO
CREATE PROCEDURE dbo.usp_Ferry_ListSchedules
@FerryId INT

AS 
BEGIN
SELECT ScheduleId, Description, CostPerPerson, CostPerVehicle
FROM   dbo.Schedule
WHERE  FerryId = @FerryId
END
GO
