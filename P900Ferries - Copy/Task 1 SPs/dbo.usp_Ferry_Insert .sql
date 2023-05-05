/*===========================================================================*\ 
Description: 
Creates new ferry in database

Parameters: 
@Name       NVARCHAR(256),
@CompanyId  INT,
@FerryId    INT OUTPUT

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Ferry_Insert') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Ferry_Insert
END
GO
CREATE PROCEDURE dbo.usp_Ferry_Insert
@Name       NVARCHAR(256),
@CompanyId  INT,
@FerryId    INT OUTPUT

AS 
INSERT dbo.Ferry (
Name,
CompanyId)

VALUES (
@Name,
@CompanyId)

SELECT @FerryId = SCOPE_IDENTITY()
GO
