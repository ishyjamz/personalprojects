/*===========================================================================*\ 
Description: 
Deletes existing company 

Parameters: 
@CompanyId

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Company_Delete
@CompanyId INT

AS
BEGIN
DELETE 
FROM   dbo.Company
WHERE  CompanyId = @CompanyId

END
GO