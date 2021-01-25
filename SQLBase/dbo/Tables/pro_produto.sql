CREATE TABLE [dbo].[pro_produto] (
    [pro_cod]              INT          IDENTITY (1, 1) NOT NULL,
    [pro_nome]             VARCHAR (95) NULL,
    [pro_descricao]        TEXT         NULL,
    [pro_foto]             IMAGE        NULL,
    [pro_cod_und_medida]   INT          NULL,
    [pro_cod_categoria]    INT          NULL,
    [pro_cod_subcategoria] INT          NULL,
    [pro_valor_venda]      MONEY        NULL,
    CONSTRAINT [XPKproduto] PRIMARY KEY NONCLUSTERED ([pro_cod] ASC),
    CONSTRAINT [R_11] FOREIGN KEY ([pro_cod_categoria]) REFERENCES [dbo].[cat_categoria] ([cat_cod]),
    CONSTRAINT [R_12] FOREIGN KEY ([pro_cod_subcategoria]) REFERENCES [dbo].[scat_subcategoria] ([scat_cod]),
    CONSTRAINT [R_9] FOREIGN KEY ([pro_cod_und_medida]) REFERENCES [dbo].[umed_und_medida] ([umed_cod])
);

