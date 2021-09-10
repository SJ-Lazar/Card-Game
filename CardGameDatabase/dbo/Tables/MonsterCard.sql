CREATE TABLE [dbo].[MonsterCard]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [CardId] INT NOT NULL, 
    [Description] NVARCHAR(500) NOT NULL, 
    [Attack] INT NOT NULL, 
    [Defense] INT NOT NULL, 
)
