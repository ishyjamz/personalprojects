/*===========================================================================*\ 
Description: 
Updates details for existing schedule

Parameters: 
 @ScheduleId     INT,
 @FerryId        INT,
 @Description    NVARCHAR(256),
 @CostPerPerson  DECIMAL(9,2),
 @CostPerVehicle DECIMAL(9,2),
 @RowVersion     ROWVERSION

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Schedule_Update
(@ScheduleId     INT,
 @FerryId        INT,
 @Description    NVARCHAR(256),
 @CostPerPerson  DECIMAL(9,2),
 @CostPerVehicle DECIMAL(9,2),
 @RowVersion     ROWVERSION)

AS 
BEGIN 
UPDATE dbo.Schedule
SET    FerryId = @FerryId, Description = @Description, CostPerPerson = @CostPerPerson, 
CostPerVehicle = @CostPerVehicle
WHERE  (ScheduleId = @ScheduleId) AND (RowVersion = @RowVersion)
END
GO