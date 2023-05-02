/*===========================================================================*\ 
Description: 
Updates details for existing company 

Parameters: 
@CompanyId  INT,
@Name       NVARCHAR(256)
@RowVersion ROWVERSION

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Company_Update') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Company_Update
END
GO
CREATE PROCEDURE dbo.usp_Company_Update
(@CompanyId  INT,
 @Name       NVARCHAR(256),
 @RowVersion ROWVERSION)

AS 
BEGIN 
UPDATE dbo.Company
SET    Name = @Name
WHERE  (CompanyId = @CompanyId) AND (RowVersion = @RowVersion)
END
GO