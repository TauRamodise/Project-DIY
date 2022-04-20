SET IDENTITY_INSERT [dbo].[Services] ON
INSERT INTO [dbo].[Services] ([ID], [ProviderName], [ServiceType], [Description], [CallOutFee], [UserID]) VALUES (1, N'LightBlub', N'Electricity services', N'Electrical applicances, circuits and breakers', CAST(100.0000 AS SmallMoney), 1)
INSERT INTO [dbo].[Services] ([ID], [ProviderName], [ServiceType], [Description], [CallOutFee], [UserID]) VALUES (2, N'Tapwater', N'Water services', N'Borehole making services', CAST(100.0000 AS SmallMoney), 2)
INSERT INTO [dbo].[Services] ([ID], [ProviderName], [ServiceType], [Description], [CallOutFee], [UserID]) VALUES (3, N'Plumber', N'Water services', N'For all indoor and outdoor plumbing needs', CAST(100.0000 AS SmallMoney), 2)
INSERT INTO [dbo].[Services] ([ID], [ProviderName], [ServiceType], [Description], [CallOutFee], [UserID]) VALUES (4, N'Roofing', N'Roofing', N'Water fix roofing, tiling, gutters', CAST(100.0000 AS SmallMoney), 3)
INSERT INTO [dbo].[Services] ([ID], [ProviderName], [ServiceType], [Description], [CallOutFee], [UserID]) VALUES (5, N'Landscape', N'gardening services', N'gardening services', CAST(100.0000 AS SmallMoney), 4)
INSERT INTO [dbo].[Services] ([ID], [ProviderName], [ServiceType], [Description], [CallOutFee], [UserID]) VALUES (6, N'PoolBoy', N'Pool cleaning services', N'Pool cleaning services', CAST(100.0000 AS SmallMoney), 2)
SET IDENTITY_INSERT [dbo].[Services] OFF
