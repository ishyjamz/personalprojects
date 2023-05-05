USE [FerriesDatabase]
CREATE ROLE FerriesAdminUser

GRANT EXECUTE ON dbo.usp_Company_Delete      TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Company_Insert      TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Company_Update      TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Company_List        TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Company_Get         TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Company_ListFerry   TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Ferry_Delete        TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Ferry_Insert        TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Ferry_Update        TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Ferry_List          TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Ferry_ListSchedules TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Ferry_Get           TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Schedule_Insert     TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Schedule_Delete     TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Schedule_Update     TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Schedule_List       TO FerriesAdminUser
GRANT EXECUTE ON dbo.usp_Schedule_Get        TO FerriesAdminUser

GO

