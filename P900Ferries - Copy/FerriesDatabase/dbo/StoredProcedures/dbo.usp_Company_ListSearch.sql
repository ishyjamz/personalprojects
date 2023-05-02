/*===========================================================================*\ 
Description: 
Lists all the ferries in a database
Parameters:
@CompanyName NVARCHAR(256) = NULL
Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Company_ListSearch
@CompanyName NVARCHAR(256) = NULL

AS 
BEGIN
SELECT [Name] AS CompanyName, CompanyId
FROM dbo.Company
WHERE ([Name] LIKE '%' + @CompanyName + '%' OR @CompanyName IS NULL)
END
