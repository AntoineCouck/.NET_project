CREATE TABLE [dbo].[Patients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Firstname] NVARCHAR(15) NOT NULL, 
    [Lastname] NVARCHAR(15) NOT NULL, 
    [Birthday] DATETIME NOT NULL, 
    [Followup] NVARCHAR(50) NOT NULL, 
    [LeftSessions] INT NOT NULL ,
    [UserId] INT  NULL ,
    CONSTRAINT [FK_Users] FOREIGN KEY (UserId) REFERENCES Users (Id) 
)
