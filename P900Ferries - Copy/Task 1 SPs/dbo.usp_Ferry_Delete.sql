/*===========================================================================*\ 
Description: 
Deletes existing ferry

Parameters: 
@FerryId

Created:    February 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Ferry_Delete') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Ferry_Delete
END
GO
CREATE PROCEDURE dbo.usp_Ferry_Delete
@FerryId INT

AS
BEGIN
DELETE 
FROM   dbo.Ferry
WHERE  FerryId = @FerryId
END
GO