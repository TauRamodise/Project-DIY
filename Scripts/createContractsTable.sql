USE [DiyDB]
GO

CREATE TABLE [dbo].[Contracts](
	[ID] [int] PRIMARY KEY IDENTITY(1,1) NOT NULL,
	[CustomerID] [int] NOT NULL,
	[ProviderID] [int] NOT NULL,
	[ServiceID] [int] NOT NULL,
	[Description] [varchar](250) NOT NULL,
	[StartDate] [datetime2](7) NOT NULL,
	[EndDate] [datetime2](7) NOT NULL,
	[Amount] [int] NOT NULL,
	[IsCountered] [bit] NOT NULL,
	[Status] [int] NOT NULL,
	[Created] [datetime2](7) NOT NULL,
	[Modified] [datetime2](7) NOT NULL,
);
GO