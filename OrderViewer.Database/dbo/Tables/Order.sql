CREATE TABLE [dbo].[Order] (
    [Id]			INT            IDENTITY (1, 1) NOT NULL,
    [ClientId]		INT            NOT NULL,
    [ClientName]	NVARCHAR (150) NOT NULL,
    [OrderDate]		DATETIME       NOT NULL,
    [GST]			SMALLMONEY     NOT NULL,
    [Total]			MONEY          NOT NULL, 
    CONSTRAINT		[PK_Order]	   PRIMARY KEY ([Id])
);



