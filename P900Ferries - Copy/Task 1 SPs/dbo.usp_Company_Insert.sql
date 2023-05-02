/*===========================================================================*\ 
Description: 
Creates new company in database

Parameters: 
@Name       NVARCHAR(256)
@CompanyId  INT OUTPUT

Created:    January 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Company_Insert') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Company_Insert
END
GO
CREATE PROCEDURE dbo.usp_Company_Insert
@Name       NVARCHAR(256),
@CompanyId  INT OUTPUT


AS 
INSERT dbo.Company (
Name)

VALUES (
@Name)

SELECT @CompanyId = SCOPE_IDENTITY()
GO
