USE [diyDB]
GO
-- Create the table
CREATE TABLE [dbo].[Users]
(
    [ID] [INT] PRIMARY KEY IDENTITY(1,1),                        -- primary key column
    [FirstName] [VARCHAR](50) NOT NULL,
    [Surname] [VARCHAR](50) NOT NULL,      
    [Gender] [VARCHAR](10) NOT NULL
                                          
);
GO