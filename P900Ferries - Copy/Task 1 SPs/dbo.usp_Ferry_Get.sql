/*===========================================================================*\ 
Description: 
Retrieves ferry details for specified ferry

Parameters: 
@FerryId  INT

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Ferry_Get') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Ferry_Get
END
GO
CREATE PROCEDURE dbo.usp_Ferry_Get (
@FerryId INT)

AS 
BEGIN 
SELECT  FerryId, CompanyId, Name, RowVersion
FROM    dbo.Ferry
WHERE   FerryId = @FerryId
END 
GO