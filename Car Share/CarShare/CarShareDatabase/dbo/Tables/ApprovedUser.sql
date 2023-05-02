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