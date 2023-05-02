CREATE TABLE dbo.[Location] (	
    LocationId          INT IDENTITY(1,1)	NOT NULL,
    [Name]              VARCHAR(256)	    NOT NULL,
    DistanceToWork      INT				    NOT NULL,
    CONSTRAINT PK_Location
        PRIMARY KEY(LocationId)
)