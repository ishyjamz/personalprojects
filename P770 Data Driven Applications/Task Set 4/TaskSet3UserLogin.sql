USE [DVLA]
CREATE ROLE TaskSet3StandardUser
GRANT SELECT ON dbo.Address TO TaskSet3StandardUser
GRANT INSERT, SELECT, UPDATE ON dbo.Camera TO TaskSet3StandardUser
GRANT INSERT, SELECT, UPDATE ON dbo.Car TO TaskSet3StandardUser
GRANT SELECT ON dbo.Colour TO TaskSet3StandardUser
GRANT SELECT ON dbo.Fine TO TaskSet3StandardUser
GRANT SELECT ON dbo.Make TO TaskSet3StandardUser
GRANT SELECT ON dbo.Model TO TaskSet3StandardUser
GRANT INSERT, SELECT, UPDATE ON dbo.Owner TO TaskSet3StandardUser
GRANT SELECT ON dbo.Sighting TO TaskSet3StandardUser
GRANT INSERT, SELECT, UPDATE ON dbo.SpeedCamera TO TaskSet3StandardUser
GRANT INSERT, SELECT, UPDATE ON dbo.TrafficLightCamera TO TaskSet3StandardUser
GO

CREATE LOGIN [P770TaskSet3User]
WITH PASSWORD =N'770DatabaseDrivenApp', DEFAULT_DATABASE=[DVLA],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

CREATE USER [User1] FOR LOGIN [P770TaskSet3User]
GO

ALTER ROLE TaskSet3StandardUser ADD MEMBER [User1]
GO