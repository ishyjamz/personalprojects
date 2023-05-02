USE [P770TaskSet2]
CREATE ROLE StandardUser
GRANT EXECUTE on dbo.usp_Employee_READ TO StandardUser
GRANT EXECUTE on dbo.usp_Employee_SEARCH TO StandardUser
GRANT EXECUTE on dbo.usp_Employee_CREATE TO StandardUser
GRANT EXECUTE on dbo.usp_Employee_UPDATE TO StandardUser
GRANT EXECUTE on dbo.usp_Employee_DELETE TO StandardUser
GO

CREATE LOGIN [P770TaskSet2User]
WITH PASSWORD =N'770DatabaseDrivenApp', DEFAULT_DATABASE=[P770TaskSet2],
CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
GO

CREATE USER [User1] FOR LOGIN [P770TaskSet2User]
GO

ALTER ROLE StandardUser ADD MEMBER [User1]
GO
