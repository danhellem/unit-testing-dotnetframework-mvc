CREATE TABLE [dbo].[RecommendShirtColor] (
    [RecId]      INT          IDENTITY (1, 1) NOT NULL,
    [PantColor]  VARCHAR (50) NOT NULL,
    [ShirtColor] VARCHAR (50) NOT NULL,
    CONSTRAINT [PK_RecommendShirtColor] PRIMARY KEY CLUSTERED ([RecId] ASC)
);

