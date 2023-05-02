/*===========================================================================*\ 
Description: 
Updates details for existing employee in data table

Parameters: 
@EmployeeID INT,
@FirstName VARCHAR(70),
@Surname VARCHAR(70),
@Address VARCHAR(255),
@Postcode VARCHAR(8),
@Salary DECIMAL(7,2),
@StartDate DATE

Created:    January 2023
\*===========================================================================*/
IF OBJECT_ID('dbo.usp_Employee_UPDATE') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Employee_UPDATE
END
GO
CREATE PROCEDURE dbo.usp_Employee_UPDATE
(@EmployeeID INT,
@FirstName VARCHAR(70),
@Surname VARCHAR(70),
@Address VARCHAR(255),
@Postcode VARCHAR(8),
@Salary DECIMAL(9,2),
@StartDate DATE,
@RowVersion ROWVERSION)

AS 
BEGIN 
UPDATE dbo.Employee
SET FirstName = @FirstName,
    Surname = @Surname,
	[Address] = @Address,
	Postcode = @Postcode,
	Salary = @Salary, 
	StartDate = @StartDate
WHERE (EmployeeID = @EmployeeID AND RowVersion = @RowVersion)
END
GO