/*===========================================================================*\ 
Description: 
Deletes existing ferry

Parameters: 
@FerryId

Created:    February 2023
\*===========================================================================*/

CREATE PROCEDURE dbo.usp_Ferry_Delete
@FerryId INT

AS
BEGIN
DELETE 
FROM   dbo.Ferry
WHERE  FerryId = @FerryId
END
GO