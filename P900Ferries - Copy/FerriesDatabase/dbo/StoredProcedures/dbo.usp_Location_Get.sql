/*===========================================================================*\ 
Description: 
Retrieves location details for specified location

Parameters: 
@LocationId INT
Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Location_Get (
@LocationId INT)

AS 
BEGIN 
SELECT  [Name]
FROM    dbo.Location
WHERE   LocationId = @LocationId
END 
GO 