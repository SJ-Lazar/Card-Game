CREATE PROCEDURE [dbo].[spCreateSpellCard]
	@Name NVARCHAR(50),
	@ImagePath NVARCHAR(MAX),
	@ImageName NVARCHAR(MAX),
	@SpellEffect NVARCHAR(500)
	

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
						INSERT INTO dbo.SpellCard(CardId, SpellEffect) VALUES(@CardId, @SpellEffect)
					END
		COMMIT TRANSACTION
		END TRY 
	BEGIN CATCH 
		ROLLBACK TRANSACTION
		SELECT ERROR_MESSAGE()
	END CATCH 
END
