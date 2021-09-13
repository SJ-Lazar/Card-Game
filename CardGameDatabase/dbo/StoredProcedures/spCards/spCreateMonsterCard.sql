CREATE PROCEDURE [dbo].[spCreateMonsterCard]
	@Name NVARCHAR(50),
	@ImagePath NVARCHAR(MAX),
	@ImageName NVARCHAR(MAX),
	@Description NVARCHAR(500),
	@Attack INT,
	@Defense INT

AS
	DECLARE @CardId INT, @ImageId INT
	
BEGIN 
		BEGIN TRAN
		BEGIN TRY 
			INSERT INTO dbo.Image(ImagePath, ImageName) VALUES(@ImagePath, @ImageName);
			SELECT @ImageId = SCOPE_IDENTITY();
				IF @ImageId IS NOT NULL 
				BEGIN
					INSERT INTO dbo.Card(Name, ImageId) VALUES(@Name, @ImageId)
				END
				SELECT @CardId = SCOPE_IDENTITY();
				IF @CardId IS NOT NULL 
					BEGIN
						INSERT INTO dbo.MonsterCard(CardId, Description, Attack, Defense) VALUES(@CardId, @Description, @Attack, @Defense)
					END
		COMMIT TRANSACTION
		END TRY 
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE()
	END CATCH 
END
 
