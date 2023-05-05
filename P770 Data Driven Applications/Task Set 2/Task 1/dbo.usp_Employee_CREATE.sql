/*===========================================================================*\ 
Description: 
Creates new employee in data table

Parameters: 
@FirstName VARCHAR(70),
@Surname VARCHAR(70),
@Address VARCHAR(255),
@Postcode VARCHAR(8),
@Salary DECIMAL(7,2),
@StartDate DATE

Created:    January 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Employee_CREATE') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Employee_CREATE
END
GO
CREATE PROCEDURE dbo.usp_Employee_CREATE
(@FirstName VARCHAR(70),
@Surname VARCHAR(70),
@Address VARCHAR(255),
@Postcode VARCHAR(8),
@Salary DECIMAL(9,2),
@StartDate DATE,
@EmployeeID INT OUTPUT)

AS 
INSERT dbo.Employee (
FirstName,
Surname,
[Address],
Postcode,
Salary,
StartDate)

VALUES (
@FirstName,
@Surname,
@Address,
@Postcode,
@Salary,
@StartDate)

SELECT @EmployeeID = SCOPE_IDENTITY()
GO
