CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](128) NOT NULL,
	[Email] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEndDateUtc] [datetime] NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
	[UserName] [nvarchar](256) NOT NULL,
	[FirstName] [nvarchar](256) NULL,
	[LastName] [nvarchar](256) NULL,
 CONSTRAINT [PK_dbo.AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
CREATE TABLE dbo.[Location] (	
    LocationId          INT IDENTITY(1,1)	NOT NULL,
    [Name]              VARCHAR(256)	    NOT NULL,
    DistanceToWork      INT				    NOT NULL,
    CONSTRAINT PK_Location
        PRIMARY KEY(LocationId)
)
GO

CREATE TABLE dbo.[User] (
    UserId              INT IDENTITY(1,1)       NOT NULL,
    [Name]              VARCHAR(256)            NOT NULL,
    AspNetUserId        NVARCHAR(128)           NOT NULL,
    CONSTRAINT PK_User
        PRIMARY KEY(UserId),
    CONSTRAINT FK_User_AspNetUsers
        FOREIGN KEY(AspNetUserId)
        REFERENCES  AspNetUsers(Id),
);
GO

CREATE TABLE dbo.DriverStop (
    LocationId      INT      NOT NULL,
    UserId			INT		 NOT NULL,
    TimeFromHome	INT      NOT NULL,
    CONSTRAINT PK_DriverStop
        PRIMARY KEY(LocationId, UserId),
    CONSTRAINT FK_DriverStop_Location
        FOREIGN KEY(LocationId)
        REFERENCES  [Location](LocationId),
    CONSTRAINT FK_DriverStop_User
        FOREIGN KEY(UserId)
        REFERENCES [User](UserId)
)
GO

CREATE TABLE dbo.ApprovedUser (
    PassengerId     INT                 NOT NULL,
    DriverId		INT                 NOT NULL,
    CONSTRAINT PK_ApprovedUser
        PRIMARY KEY(PassengerId, DriverId),
    CONSTRAINT FK_ApprovedUser_Passenger
        FOREIGN KEY (PassengerId)
        REFERENCES  [User](UserId),
    CONSTRAINT FK_ApprovedUser_Driver
        FOREIGN KEY (DriverId)
        REFERENCES  [User](UserId)
)
GO

CREATE TABLE dbo.DriverJourney (
    DriverJourneyId	INT IDENTITY(1,1)	NOT NULL,
    DriverId		INT				    NOT NULL,
    [Date]          DATE			    NOT NULL,
    SeatsAvailable  INT				    NOT NULL,
    RowVersion      ROWVERSION          NOT NULL,
    CONSTRAINT PK_DriverJourney
        PRIMARY KEY(DriverJourneyId),
    CONSTRAINT FK_DriverJourney_Driver
        FOREIGN KEY(DriverId)
        REFERENCES  [User](UserId),
)
GO

CREATE TABLE dbo.JourneyStop (
    JourneyStopId     INT IDENTITY(1,1)		NOT NULL,
    LocationId		  INT				    NOT NULL,
    DriverJourneyId   INT				    NOT NULL,
    TimeFromHome      INT				    NOT NULL,
    CONSTRAINT PK_JourneyStop
        PRIMARY KEY(JourneyStopId),
    CONSTRAINT FK_JourneyStop_Location
        FOREIGN KEY(LocationId)
        REFERENCES  [Location](LocationId),
    CONSTRAINT FK_DriverStop_DriverJourney
        FOREIGN KEY(DriverJourneyId)
        REFERENCES  DriverJourney(DriverJourneyId)
)
GO

CREATE TABLE dbo.PassengerJourneyStatus (
    StatusId     INT IDENTITY(1,1)		NOT NULL,
    [Name]		 VARCHAR(256)		    NOT NULL,
    CONSTRAINT PK_PassengerJourneyStatus
        PRIMARY KEY(StatusId),
);
GO

CREATE TABLE dbo.PassengerJourney (
    PassengerJourneyId		INT IDENTITY(1,1)	NOT NULL,
    JourneyStopId			INT				    NOT NULL,
    StatusId				INT				    NOT NULL,
    RowVersion              ROWVERSION          NOT NULL,
    CONSTRAINT PK_PassengerJourney
        PRIMARY KEY(PassengerJourneyId),
    CONSTRAINT FK_PassengerJourney_JourneyStop
        FOREIGN KEY(JourneyStopId)
        REFERENCES  JourneyStop(JourneyStopId),
    CONSTRAINT FK_PassengerJourney_PassengerJourneyStatus
        FOREIGN KEY(StatusId)
        REFERENCES  PassengerJourneyStatus(StatusId)
)
GO

CREATE TABLE dbo.[Notification] (
    NotificationId			INT IDENTITY(1,1)	NOT NULL,
    [Type]					VARCHAR(256)	    NOT NULL,
    PassengerJourneyId		INT				    NOT NULL,
    CONSTRAINT PK_Notification
        PRIMARY KEY(NotificationId),
    CONSTRAINT FK_Notification_PassengerJourney
        FOREIGN KEY(PassengerJourneyId)
        REFERENCES  PassengerJourney(PassengerJourneyId)
)
GO

CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](256) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO

CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[UserId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC,
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](128) NOT NULL,
	[RoleId] [nvarchar](128) NOT NULL,
 CONSTRAINT [PK_dbo.AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

ALTER TABLE [dbo].[AspNetUserClaims]  ADD  CONSTRAINT [FK_dbo.AspNetUserClaims_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins]  ADD  CONSTRAINT [FK_dbo.AspNetUserLogins_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles]  ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles]  ADD  CONSTRAINT [FK_dbo.AspNetUserRoles_dbo.AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
