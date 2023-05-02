/*===========================================================================*\ 
Description: 
Retrieves schedule details for specified schedule

Parameters: 
@ScheduleId  INT

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Schedule_Get') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Schedule_Get
END
GO
CREATE PROCEDURE dbo.usp_Schedule_Get (
@ScheduleId INT)

AS 
BEGIN 
SELECT  FerryId, Description, CostPerPerson, CostPerVehicle, RowVersion
FROM    dbo.Schedule
WHERE   ScheduleId = @ScheduleId
END 
GO 