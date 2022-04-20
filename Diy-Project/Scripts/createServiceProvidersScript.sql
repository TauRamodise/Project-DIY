USE [diyDB]
GO
-- Create the table
CREATE TABLE [dbo].[Services]
(
    [ID] [INT] PRIMARY KEY IDENTITY(1,1),                        -- primary key column
    [ProviderName] [VARCHAR](50) NOT NULL,
    [Service] [VARCHAR](50) NOT NULL,
    [Description] [VARCHAR](250) NOT NULL,            
    [CallOutFee] [SmallMoney] NOT NULL,
    [UserID] [INT] NOT NULL
);
GO