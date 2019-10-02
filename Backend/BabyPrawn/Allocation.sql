CREATE TABLE [dbo].[Allocation]
(
	[TeamId] INT,
	[PlayerId] INT,
	CONSTRAINT PK_Allocation PRIMARY KEY (TeamId, PlayerId),
	FOREIGN KEY (TeamId) references Team(TeamID),
	FOREIGN KEY (PlayerId) references Player(PlayerId)
)
