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