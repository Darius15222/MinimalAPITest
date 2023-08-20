CREATE TABLE [dbo].[Persons]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Nume] NCHAR(20) NOT NULL, 
    [Prenume] NCHAR(20) NOT NULL, 
    [Varsta] INT NOT NULL
)