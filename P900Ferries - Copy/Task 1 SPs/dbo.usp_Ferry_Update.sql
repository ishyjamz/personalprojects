/*===========================================================================*\ 
Description: 
Updates details for existing ferry 

Parameters: 
@FerryId    INT,
@Name       NVARCHAR(256),
@CompanyId  INT,
@RowVersion ROWVERSION

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Ferry_Update') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Ferry_Update
END
GO
CREATE PROCEDURE dbo.usp_Ferry_Update
(@FerryId    INT,
 @CompanyId  INT,
 @Name       NVARCHAR(256),
 @RowVersion ROWVERSION)

AS 
BEGIN 
UPDATE dbo.Ferry
SET    Name = @Name, CompanyId = @CompanyId
WHERE  (FerryId = @FerryId) AND (RowVersion = @RowVersion)
END
GO