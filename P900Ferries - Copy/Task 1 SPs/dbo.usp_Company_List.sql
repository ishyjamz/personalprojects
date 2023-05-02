/*===========================================================================*\ 
Description: 
Lists all the companies in a database
Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Company_List') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Company_List
END
GO
CREATE PROCEDURE dbo.usp_Company_List

AS 
BEGIN
SELECT CompanyId, Name
FROM dbo.Company
END
GO
