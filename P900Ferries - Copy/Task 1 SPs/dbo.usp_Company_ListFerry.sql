/*===========================================================================*\ 
Description: 
Lists all the ferries for one company
Parameters: 
@CompanyId INT

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Company_ListFerry') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Company_ListFerry
END
GO
CREATE PROCEDURE dbo.usp_Company_ListFerry
@CompanyId INT

AS 
BEGIN
SELECT FerryId, Name, CompanyId
FROM   dbo.Ferry
WHERE  CompanyId = @CompanyId
END
GO
