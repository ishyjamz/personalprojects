﻿/*
Deployment script for FerriesDatabase

This code was generated by a tool.
Changes to this file may cause incorrect behavior and will be lost if
the code is regenerated.
*/

GO
SET ANSI_NULLS, ANSI_PADDING, ANSI_WARNINGS, ARITHABORT, CONCAT_NULL_YIELDS_NULL, QUOTED_IDENTIFIER ON;

SET NUMERIC_ROUNDABORT OFF;


GO
:setvar DatabaseName "FerriesDatabase"
:setvar DefaultFilePrefix "FerriesDatabase"
:setvar DefaultDataPath "C:\Users\DeveloperTraining\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"
:setvar DefaultLogPath "C:\Users\DeveloperTraining\AppData\Local\Microsoft\Microsoft SQL Server Local DB\Instances\MSSQLLocalDB\"

GO
:on error exit
GO
/*
Detect SQLCMD mode and disable script execution if SQLCMD mode is not supported.
To re-enable the script after enabling SQLCMD mode, execute the following:
SET NOEXEC OFF; 
*/
:setvar __IsSqlCmdEnabled "True"
GO
IF N'$(__IsSqlCmdEnabled)' NOT LIKE N'True'
    BEGIN
        PRINT N'SQLCMD mode must be enabled to successfully execute this script.';
        SET NOEXEC ON;
    END


GO
USE [$(DatabaseName)];


GO
PRINT N'Dropping Check Constraint [dbo].[CK_ScheduleStop_ArrivalDay]...';


GO
ALTER TABLE [dbo].[ScheduleStop] DROP CONSTRAINT [CK_ScheduleStop_ArrivalDay];


GO
PRINT N'Dropping Check Constraint [dbo].[CK_ScheduleStop_DepartureDay]...';


GO
ALTER TABLE [dbo].[ScheduleStop] DROP CONSTRAINT [CK_ScheduleStop_DepartureDay];


GO
PRINT N'Creating Check Constraint [dbo].[CK_ScheduleStop_ArrivalDay]...';


GO
ALTER TABLE [dbo].[ScheduleStop] WITH NOCHECK
    ADD CONSTRAINT [CK_ScheduleStop_ArrivalDay] CHECK (ArrivalDay BETWEEN 0 AND 6);


GO
PRINT N'Creating Check Constraint [dbo].[CK_ScheduleStop_DepartureDay]...';


GO
ALTER TABLE [dbo].[ScheduleStop] WITH NOCHECK
    ADD CONSTRAINT [CK_ScheduleStop_DepartureDay] CHECK (DepartureDay BETWEEN 0 AND 6);


GO
PRINT N'Creating Procedure [dbo].[usp_Booking_Insert]...';


GO
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
@ArrivalLocation    NVARCHAR(256)

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
GO
PRINT N'Creating Procedure [dbo].[usp_BookingContact_Insert]...';


GO
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
@PostalCode     NVARCHAR(20)

AS 
INSERT dbo.BookingContact (
[Name],
AddressLine1,
AddressLine2, 
City,
PostalCode)

VALUES (
@Name,
@AddressLine1,
@AddressLine2, 
@City,
@PostalCode
)
GO
PRINT N'Checking existing data against newly created constraints';


GO
USE [$(DatabaseName)];


GO
ALTER TABLE [dbo].[ScheduleStop] WITH CHECK CHECK CONSTRAINT [CK_ScheduleStop_ArrivalDay];

ALTER TABLE [dbo].[ScheduleStop] WITH CHECK CHECK CONSTRAINT [CK_ScheduleStop_DepartureDay];


GO
PRINT N'Update complete.';


GO
