/*===========================================================================*\ 
Description: 
Retrieves schedule details for specified schedule

Parameters: 
@ScheduleId  INT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Schedule_Get (
@ScheduleId INT)

AS 
BEGIN 
SELECT  FerryId, Description, CostPerPerson, CostPerVehicle, RowVersion
FROM    dbo.Schedule
WHERE   ScheduleId = @ScheduleId
END 
GO 