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
PRINT N'Altering Procedure [dbo].[usp_Ferry_ListSearch]...';


GO
/*===========================================================================*\ 
Description: 
Lists all the ferries in a database
Parameters:
@FerryName NVARCHAR(256) NULL,
@CompanyName NVARCHAR(256) NULL
Created:    February 2023
\*===========================================================================*/
ALTER PROCEDURE dbo.usp_Ferry_ListSearch
@FerryName NVARCHAR(256) = NULL,
@CompanyName NVARCHAR(256) = NULL

AS 
BEGIN
SELECT FerryId, f.[Name] AS FerryName, c.[Name] AS CompanyName
FROM dbo.Ferry f
INNER JOIN dbo.Company c
ON f.CompanyId = c.CompanyId
WHERE (f.[Name] LIKE '%' + @FerryName + '%' OR @FerryName IS NULL) AND (c.[Name] LIKE '%'+@CompanyName + '%' OR @CompanyName IS NULL) 
END
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
