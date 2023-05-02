/*===========================================================================*\ 
Description: 
Retrieves schedule details for specified schedule

Parameters: 
@ScheduleId  INT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Location_List 

AS 
BEGIN 
SELECT   Name, LocationId

FROM  dbo.Location 
END 
GO 