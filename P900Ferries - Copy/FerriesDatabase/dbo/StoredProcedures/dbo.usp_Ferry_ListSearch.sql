/*===========================================================================*\ 
Description: 
Lists all the ferries in a database
Parameters:
@FerryName NVARCHAR(256) NULL,
@CompanyName NVARCHAR(256) NULL
Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Ferry_ListSearch
@FerryName NVARCHAR(256) = NULL,
@CompanyName NVARCHAR(256) = NULL

AS 
BEGIN
SELECT FerryId, f.[Name] AS FerryName, c.[Name] AS CompanyName
FROM dbo.Ferry f
INNER JOIN dbo.Company c
ON f.CompanyId = c.CompanyId
WHERE (f.[Name] LIKE '%' + @FerryName + '%' OR @FerryName IS NULL) AND (c.[Name] LIKE '%'+@CompanyName + '%' OR @CompanyName IS NULL) 
END
