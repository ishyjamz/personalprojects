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
CREATE PROCEDURE dbo.usp_Booking_Insert
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
@ArrivalLocation    NVARCHAR(256),
@BookingId          INT OUTPUT


AS 
INSERT dbo.Booking (
UserId,
BookingReference,
Cars, 
Passengers,
Cost,
CompanyName,
FerryName,
DepartureDate,
DepartureLocation,
ArrivalDate,
ArrivalLocation )

VALUES (
@UserId,
@BookingReference,
@Cars, 
@Passengers,
@Cost,
@CompanyName,
@FerryName,
@DepartureDate,
@DepartureLocation,
@ArrivalDate,
@ArrivalLocation
)

SELECT @BookingId = SCOPE_IDENTITY()
GO
