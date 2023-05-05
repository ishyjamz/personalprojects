/*===========================================================================*\ 
Description: 
Creates new schedule in database

Parameters: 
@Name       NVARCHAR(256),
@CompanyId  INT,
@FerryId    INT OUTPUT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_ScheduleStop_Insert
@ScheduleId      INT,
@DepartureDay    TINYINT,
@ArrivalDay      TINYINT,
@DepartureTime   TIME(7),
@ArrivalTime     TIME(7),
@LocationId      INT

AS 
INSERT dbo.ScheduleStop(
ScheduleId,
DepartureDay,
ArrivalDay,
DepartureTime,
ArrivalTime,
LocationId)

VALUES (
@ScheduleId,
@DepartureDay,
@ArrivalDay,    
@DepartureTime,
@ArrivalTime,
@LocationId      
)

GO
