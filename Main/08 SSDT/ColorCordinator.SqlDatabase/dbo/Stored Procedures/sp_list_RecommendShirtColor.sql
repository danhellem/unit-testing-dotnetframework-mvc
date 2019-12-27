CREATE PROCEDURE sp_list_RecommendShirtColor
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT RecId, PantColor, ShirtColor from RecommendShirtColor
END