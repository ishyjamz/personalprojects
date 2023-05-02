/*===========================================================================*\ 
Description: 
Retrieves company details which correspond to inputted company ID

Parameters: 
@CompanyId

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Company_Get') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Company_Get
END
GO
CREATE PROCEDURE dbo.usp_Company_Get (
@CompanyId INT)

AS 
BEGIN 
SELECT  CompanyID, Name, RowVersion
FROM    dbo.Company
WHERE   CompanyId = @CompanyId
END 
GO