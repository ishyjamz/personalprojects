/*===========================================================================*\ 
Description: 
Adds a new booking to database
Parameters: 
@UserId             NVARCHAR(128),
@BookingReference   NCHAR(5),
@Cars               INT, 
@Passengers         INT,
@Cost               DECIMAL(9,2),
@CompanyName        NVARCHAR(256),
@FerryName          NVARCHAR(256),
@DepartureDate      DATETIME2(7),
@DepartureLocation  NVARCHAR(256),
@ArrivalDate        DATETIME2(7),
@ArrivalLocation    NVARCHAR(256)

Created:    March 2023
\*===========================================================================*/
CREATE PROCEDURE dbo.usp_BookingContact_Insert
@Name           NVARCHAR(100),
@AddressLine1   NVARCHAR(256),
@AddressLine2   NVARCHAR(256) = NULL, 
@City           NVARCHAR(256),
@PostalCode     NVARCHAR(20),
@BookingId      INT

AS 
INSERT dbo.BookingContact (
[Name],
AddressLine1,
AddressLine2, 
City,
PostalCode,
BookingId)

VALUES (
@Name,
@AddressLine1,
@AddressLine2, 
@City,
@PostalCode,
@BookingId
)

GO
