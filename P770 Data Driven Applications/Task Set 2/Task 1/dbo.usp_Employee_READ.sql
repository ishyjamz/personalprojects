/*===========================================================================*\ 
Description: 
Retrieves employee details which correspond to inputted employee ID

Parameters: 
@EmployeeID

Created:    January 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Employee_READ') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Employee_READ
END
GO
CREATE PROCEDURE dbo.usp_Employee_READ (
@EmployeeID INT)

AS 
BEGIN 
SELECT EmployeeID, FirstName, Surname, [Address], Postcode, Salary, StartDate, RowVersion
FROM dbo.Employee
WHERE (EmployeeID = @EmployeeID)
END 
GO