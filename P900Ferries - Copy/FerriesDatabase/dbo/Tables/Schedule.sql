CREATE TABLE dbo.Schedule (
	ScheduleId							INT NOT NULL IDENTITY,
	FerryId								INT NOT NULL,
	Description							NVARCHAR(256) NULL,
	CostPerPerson						DECIMAL(9, 2) NOT NULL,
	CostPerVehicle						DECIMAL(9, 2) NOT NULL,
	RowVersion							ROWVERSION NOT NULL
)
GO
ALTER TABLE		dbo.Schedule
ADD CONSTRAINT	FK_Schedule_Ferry
FOREIGN KEY		(FerryId)
REFERENCES		dbo.Ferry
GO
ALTER TABLE		dbo.Schedule
ADD CONSTRAINT	PK_Schedule
PRIMARY KEY		(ScheduleId)