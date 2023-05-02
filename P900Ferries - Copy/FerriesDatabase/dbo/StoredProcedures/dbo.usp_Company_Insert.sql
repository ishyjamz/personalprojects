/*===========================================================================*\ 
Description: 
Creates new company in database

Parameters: 
@Name       NVARCHAR(256)
@CompanyId  INT OUTPUT

Created:    January 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Company_Insert
@Name       NVARCHAR(256)

AS 
INSERT dbo.Company (
Name)

VALUES (
@Name)

GO
