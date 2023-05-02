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