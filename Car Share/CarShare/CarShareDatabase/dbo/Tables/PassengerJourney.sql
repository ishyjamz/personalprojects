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