CREATE TABLE [dbo].[Jeux]
(
	[jeuxID] INT NOT NULL PRIMARY KEY, 
    [titre] VARCHAR(50) NOT NULL, 
    [anneeSortie] INT NOT NULL, 
    [synopsis] VARCHAR(MAX) NOT NULL, 
    
)
