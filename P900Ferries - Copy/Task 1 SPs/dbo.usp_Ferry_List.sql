/*===========================================================================*\ 
Description: 
Lists all the ferries in a database
Parameters:
@FerryName NVARCHAR(256) NULL,
@CompanyName NVARCHAR(256) NULL
Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Ferry_ListSearch
@FerryName NVARCHAR(256) NULL,
@CompanyName NVARCHAR(256) NULL

AS 
BEGIN
SELECT f.Name, c.Name
FROM dbo.Ferry f
INNER JOIN dbo.Company c
ON f.CompanyId = c.CompanyId
WHERE (@FerryName = f.Name OR @FerryName IS NULL) AND (@CompanyName = c.Name OR @CompanyName IS NULL) 
END
GO
