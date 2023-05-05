/*===========================================================================*\ 
Description: 
Retrieves company details which correspond to inputted company ID

Parameters: 
@CompanyId

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Company_Get (
@CompanyId INT)

AS 
BEGIN 
SELECT  CompanyId, Name, RowVersion
FROM    dbo.Company
WHERE   CompanyId = @CompanyId
END 
GO