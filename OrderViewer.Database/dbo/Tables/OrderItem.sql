CREATE TABLE [dbo].[OrderItem] (
    [Id]            INT           IDENTITY (1, 1) NOT NULL,
    [ProductCode]   NVARCHAR (50) NOT NULL,
    [Quantity]      INT           NOT NULL,
    [TotalPrice]    MONEY         NOT NULL,
    [ParentOrder]	INT           NOT NULL, 
    CONSTRAINT [PK_OrderItem] PRIMARY KEY ([Id]), 
    CONSTRAINT [FK_OrderItem_Order] FOREIGN KEY ([ParentOrder]) REFERENCES [Order]([Id])
);

