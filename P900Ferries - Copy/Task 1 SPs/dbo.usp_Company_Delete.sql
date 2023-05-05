/*===========================================================================*\ 
Description: 
Deletes existing company 

Parameters: 
@CompanyId

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Company_Delete') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Company_Delete
END
GO
CREATE PROCEDURE dbo.usp_Company_Delete
@CompanyId INT

AS
BEGIN
DELETE 
FROM   dbo.Company
WHERE  CompanyId = @CompanyId

END
GO