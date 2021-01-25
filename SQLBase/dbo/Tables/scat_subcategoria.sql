CREATE TABLE [dbo].[scat_subcategoria] (
    [scat_cod]           INT          IDENTITY (1, 1) NOT NULL,
    [scat_nome]          VARCHAR (95) NULL,
    [scat_cod_categoria] INT          NULL,
    CONSTRAINT [XPKsubcategoria] PRIMARY KEY NONCLUSTERED ([scat_cod] ASC),
    CONSTRAINT [R_10] FOREIGN KEY ([scat_cod_categoria]) REFERENCES [dbo].[cat_categoria] ([cat_cod])
);


GO
EXECUTE sp_addextendedproperty @name = N'MS_Description', @value = N'Não é bossivel remover essa Categoria pois existe uma SubCategoria para a Categoria selecionada.', @level0type = N'SCHEMA', @level0name = N'dbo', @level1type = N'TABLE', @level1name = N'scat_subcategoria', @level2type = N'CONSTRAINT', @level2name = N'R_10';

