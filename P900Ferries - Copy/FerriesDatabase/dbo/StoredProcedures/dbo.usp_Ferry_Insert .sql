/*===========================================================================*\ 
Description: 
Creates new ferry in database

Parameters: 
@Name       NVARCHAR(256),
@CompanyId  INT,
@FerryId    INT OUTPUT

Created:    February 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_Ferry_Insert
@Name       NVARCHAR(256),
@CompanyId  INT

AS 
INSERT dbo.Ferry (
Name,
CompanyId)

VALUES (
@Name,
@CompanyId)

GO
