/*===========================================================================*\ 
Description: 
Lists all the companies in a database
Created:    February 2023
\*===========================================================================*/

CREATE PROCEDURE dbo.usp_Company_List

AS 
BEGIN
SELECT CompanyId, Name AS CompanyName
FROM dbo.Company
END
GO
