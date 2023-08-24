CREATE TABLE [dbo].[JeuxCategories]
(
	[jeuxID] INT NOT NULL PRIMARY KEY, 
    [CategorieID] INT NOT NULL, 
    CONSTRAINT [FKCATID] FOREIGN KEY ([CategorieID]) REFERENCES [Categorie]([CategorieID]), 
    CONSTRAINT [FK_JEUXID] FOREIGN KEY ([jeuxID]) REFERENCES [Jeux]([jeuxID]), 
    
)
