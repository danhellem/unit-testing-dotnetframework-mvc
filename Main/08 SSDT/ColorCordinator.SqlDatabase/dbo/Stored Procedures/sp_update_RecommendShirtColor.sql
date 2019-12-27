-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE sp_update_RecommendShirtColor (
	@RecId as int,
	@pantColor as varchar(50),
	@shirtColor as varchar(50)
)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    UPDATE RecommendShirtColor SET
		PantColor = @pantColor,
		ShirtColor = @shirtColor
	WHERE
		RecId = @RecId

END
