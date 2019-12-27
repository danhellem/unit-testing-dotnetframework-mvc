CREATE PROCEDURE [dbo].[sp_delete_RecommendShirtColor]
(
	@RecId int
)	
AS

	DELETE FROM RecommendShirtColor Where RecId = @RecId;

	RETURN 0;