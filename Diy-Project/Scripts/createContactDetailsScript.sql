USE [diyDB]
GO
-- Create the table
CREATE TABLE [dbo].[ContactDetails]
(
    [ID] [INT] PRIMARY KEY IDENTITY(1,1),                        -- primary key column    
    [PhoneNumber] [VARCHAR](3) NOT NULL,        
    [Email] [VARCHAR](50) NOT NULL,
    [Telephone] [VARCHAR](13) NULL,                   
    [AfterHours] [VARCHAR](13) NULL,
    [UserID] [INT] NOT NULL
);
GO