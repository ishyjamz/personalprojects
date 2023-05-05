/*===========================================================================*\ 
Description: 


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
IF OBJECT_ID('dbo.usp_Employee_SEARCH') IS NOT NULL
BEGIN
DROP PROCEDURE dbo.usp_Employee_SEARCH
END
GO
CREATE PROCEDURE dbo.usp_Employee_SEARCH
(@FirstName VARCHAR(70) = NULL,
@Surname VARCHAR(70) = NULL,
@Postcode VARCHAR(8) = NULL
)

AS 
	SELECT EmployeeID, FirstName, Surname, [Address], Postcode, Salary, StartDate, RowVersion
	FROM dbo.Employee
	WHERE (((FirstName = @FirstName) OR (@FirstName IS NULL)) AND ((Surname = @Surname) OR (@Surname IS NULL)) AND ((Postcode = @Postcode) OR (@Postcode IS NULL)))
GO