CREATE TABLE [dbo].[CardImage]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [CardId] INT NOT NULL, 
    [ImageId] INT NOT NULL, 
    CONSTRAINT [FK_CardImage_Card] FOREIGN KEY (CardId) REFERENCES Card(Id), 
    CONSTRAINT [FK_CardImage_Image] FOREIGN KEY (ImageId) REFERENCES Image(Id)

)
