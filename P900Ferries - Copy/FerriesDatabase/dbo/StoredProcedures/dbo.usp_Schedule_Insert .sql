/*===========================================================================*\ 
Description: 
Creates new schedule in database

Parameters: 
@Name       NVARCHAR(256),
@CompanyId  INT,
@FerryId    INT OUTPUT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Schedule_Insert
@FerryId        INT,
@Description    NVARCHAR(256),
@CostPerPerson  DECIMAL(9,2),
@CostPerVehicle DECIMAL(9,2)

AS 
INSERT dbo.Schedule(
FerryId,
Description,
CostPerPerson,
CostPerVehicle)

VALUES (
@FerryId,
@Description,
@CostPerPerson,
@CostPerVehicle)

GO
