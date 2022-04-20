USE [diyDB]
GO

ALTER TABLE [dbo].[Services] ADD CONSTRAINT [FK_UsersID] FOREIGN KEY (UserID) REFERENCES [dbo].[Users] ([ID]);
ALTER TABLE [dbo].[ContactDetails] ADD CONSTRAINT [FK_UsersID] FOREIGN KEY (UserID) REFERENCES [dbo].[Users] ([ID]);
ALTER TABLE [dbo].[Contracts] ADD CONSTRAINT [FK_CustomerID] FOREIGN KEY (CustomerID) REFERENCES [dbo].[Users] ([ID]);
ALTER TABLE [dbo].[Contracts] ADD CONSTRAINT [FK_ProviderID] FOREIGN KEY (ProviderID) REFERENCES [dbo].[Users] ([ID]);
ALTER TABLE [dbo].[Contracts] ADD CONSTRAINT [FK_ServiceID] FOREIGN KEY (ServiceID) REFERENCES [dbo].[Services] ([ID]);
GO
