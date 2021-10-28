CREATE TABLE [dbo].[Tests]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(50) NOT NULL, 
    [Age] INT NOT NULL, 
    [Type_of_followUp] NVARCHAR(50) NOT NULL
)
