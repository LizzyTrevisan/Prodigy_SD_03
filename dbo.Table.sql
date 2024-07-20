CREATE TABLE [dbo].[Table]
(
    [ContactId] INT NOT NULL IDENTITY, 
    [Name] NCHAR(50) NULL, 
    [Phone] NVARCHAR(30) NULL, 
    [Email] NVARCHAR(50) NULL, 
    PRIMARY KEY ([ContactId])
)
