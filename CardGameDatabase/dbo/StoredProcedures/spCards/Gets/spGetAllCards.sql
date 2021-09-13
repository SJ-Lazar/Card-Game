CREATE PROCEDURE [dbo].[spGetAllCards]
	
AS
BEGIN
	SELECT [c].[Name], [c].[ImageId], 
		   [mc].[CardId], [mc].[Description], [mc].[Attack], [mc].[Defense], 
		   [sc].[CardId], [sc].[SpellEffect] FROM dbo.Card c
	LEFT JOIN  dbo.MonsterCard mc ON mc.CardId = c.Id
	LEFT JOIN dbo.SpellCard sc ON sc.CardId = c.Id
END

