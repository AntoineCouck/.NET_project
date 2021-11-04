CREATE TABLE [dbo].[PatientsTests] (
    [Id]        INT IDENTITY (1, 1) NOT NULL,
    [PatientId] INT NOT NULL,
    [TestId]    INT NOT NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC),
    CONSTRAINT [FK_PatientsToTest] FOREIGN KEY ([PatientId]) REFERENCES [dbo].[Patients] ([Id]) ,
    CONSTRAINT [TestsToPatients] FOREIGN KEY ([TestId]) REFERENCES [dbo].[Tests] ([Id])
);

