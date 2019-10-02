CREATE TABLE [dbo].[Team]
(
	[TeamId] int PRIMARY KEY IDENTITY,
	[FullTeamName] varchar(30) NOT NULL
	CONSTRAINT UC_Team UNIQUE (FullTeamName)
)
