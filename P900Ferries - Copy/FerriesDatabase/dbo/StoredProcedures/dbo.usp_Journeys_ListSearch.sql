/*===========================================================================*\ 
Description: 
Lists all the ferries in a database
Parameters:
@LocationFrom INT,
@LocationTo INT,
@DateFrom DATE,
@DepartingTime TIME
Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Journeys_ListSearch
@LocationFrom INT,
@LocationTo INT,
@DateFrom TINYINT,
@DepartingTime TIME

AS 
BEGIN
SELECT c.[Name] AS CompanyName, f.[Name] AS FerryName, s.ScheduleId AS ScheduleId, l2.ArrivalDay AS ArrivalDay, l2.ArrivalTime AS ArrivalTime, l1.DepartureTime AS DepartureTime
FROM
(SELECT ss.ScheduleId, ss.DepartureDay, ss.DepartureTime
FROM dbo.ScheduleStop ss 
WHERE LocationId = @LocationFrom) l1
INNER JOIN 
(SELECT  ss.ScheduleId, ss.ArrivalDay, ss.ArrivalTime
FROM dbo.ScheduleStop ss 
WHERE LocationId = @LocationTo) l2
ON l1.ScheduleId = l2.ScheduleId
INNER JOIN dbo.Schedule s
ON l1.ScheduleId = s.ScheduleId
INNER JOIN dbo.Ferry f
ON s.FerryId = f.FerryId
INNER JOIN dbo.Company c
ON f.CompanyId = c.CompanyId
WHERE l1.DepartureDay >= @DateFrom AND l1.DepartureTime >= @DepartingTime
END
GO
