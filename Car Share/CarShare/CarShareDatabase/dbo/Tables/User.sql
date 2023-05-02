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