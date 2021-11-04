CREATE TABLE [dbo].[Patients]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Firstname] NVARCHAR(15) NOT NULL, 
    [Lastname] NVARCHAR(15) NOT NULL, 
    [Birthday] DATETIME NOT NULL, 
    [Followup] NVARCHAR(50) NOT NULL, 
    [LeftSessions] INT NOT NULL ,
    [UserName] NVARCHAR(50)  NULL ,
    [InsuranceName] NVARCHAR(50) NOT NULL ,
    CONSTRAINT [FK_Users] FOREIGN KEY (UserName) REFERENCES Users(Name),
    CONSTRAINT [FK_Insurance] FOREIGN KEY (InsuranceName) REFERENCES Insurances(Name)
)
