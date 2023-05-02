/*===========================================================================*\ 
Description: 
Deletes existing employee from data table

Parameters: 
@EmployeeID

Created:    January 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Employee_DELETE') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Employee_DELETE
END
GO
CREATE PROCEDURE dbo.usp_Employee_DELETE
@EmployeeID INT

AS
BEGIN
DELETE 
FROM dbo.Employee
WHERE EmployeeID = @EmployeeID

END
GO