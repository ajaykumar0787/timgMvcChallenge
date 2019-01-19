/*
Post-Deployment Script						
--------------------------------------------------------------------------------------	
*/

INSERT INTO [dbo].[Order]([ClientId],[ClientName],[OrderDate],[GST],[Total]) VALUES (123,'DC Corp','2017-01-10 00:00:00',5.00,55.00)
INSERT INTO [dbo].[Order]([ClientId],[ClientName],[OrderDate],[GST],[Total]) VALUES (124,'Swift Enterprises','2017-02-06 00:00:00',150.00,1650.00)
GO

INSERT INTO [dbo].[OrderItem]([ProductCode],[Quantity],[TotalPrice],[ParentOrder])VALUES('ABC',1,22,1)
INSERT INTO [dbo].[OrderItem]([ProductCode],[Quantity],[TotalPrice],[ParentOrder])VALUES('DAC',4,8.25,1)
INSERT INTO [dbo].[OrderItem]([ProductCode],[Quantity],[TotalPrice],[ParentOrder])VALUES('CRE',2,550.00,2)
INSERT INTO [dbo].[OrderItem]([ProductCode],[Quantity],[TotalPrice],[ParentOrder])VALUES('ABF',4,137.50,2)
GO
