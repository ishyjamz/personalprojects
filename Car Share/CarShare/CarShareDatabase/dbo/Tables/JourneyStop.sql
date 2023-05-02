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