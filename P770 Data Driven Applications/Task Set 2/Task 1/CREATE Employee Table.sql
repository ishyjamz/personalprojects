IF OBJECT_ID('dbo.Employee') IS NOT NULL
BEGIN
DROP TABLE dbo.Employee
END
GO
CREATE TABLE dbo.Employee (
EmployeeID INT IDENTITY(1,1) NOT NULL,
FirstName VARCHAR(70) NOT NULL,
Surname VARCHAR(70) NOT NULL,
[Address] VARCHAR(255) NOT NULL,
Postcode VARCHAR(8) NOT NULL,
Salary DECIMAL(9,2) NOT NULL,
StartDate DATE NOT NULL,
"RowVersion" ROWVERSION NOT NULL)
GO