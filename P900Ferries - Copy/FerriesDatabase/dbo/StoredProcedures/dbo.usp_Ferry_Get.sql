/*===========================================================================*\ 
Description: 
Retrieves ferry details for specified ferry

Parameters: 
@FerryId  INT

Created:    February 2023
\*===========================================================================*/

CREATE PROCEDURE dbo.usp_Ferry_Get (
@FerryId INT)

AS 
BEGIN 
SELECT  FerryId, c.CompanyId, f.[Name] AS FerryName, c.[Name] AS CompanyName, f.RowVersion
FROM    dbo.Ferry f
INNER JOIN dbo.Company c
ON f.CompanyId = c.CompanyId
WHERE   FerryId = @FerryId
END 
GO