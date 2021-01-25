CREATE TABLE [dbo].[cat_categoria] (
    [cat_cod]  INT          IDENTITY (1, 1) NOT NULL,
    [cat_nome] VARCHAR (95) NULL,
    CONSTRAINT [XPKcategoria] PRIMARY KEY NONCLUSTERED ([cat_cod] ASC)
);

