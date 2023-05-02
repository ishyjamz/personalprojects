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