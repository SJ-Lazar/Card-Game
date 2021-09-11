CREATE TABLE [dbo].[UserImage]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY(1,1), 
    [UserId] INT NOT NULL, 
    [ImageId] INT NOT NULL, 
    CONSTRAINT [FK_UserImage_User] FOREIGN KEY (UserId) REFERENCES [User](Id),
    CONSTRAINT [FK_UserImage_Image] FOREIGN KEY (ImageId) REFERENCES Image(Id)
)
