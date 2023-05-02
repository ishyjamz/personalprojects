CREATE TABLE dbo.PassengerJourneyStatus (
    StatusId     INT IDENTITY(1,1)		NOT NULL,
    [Name]		 VARCHAR(256)		    NOT NULL,
    CONSTRAINT PK_PassengerJourneyStatus
        PRIMARY KEY(StatusId),
);