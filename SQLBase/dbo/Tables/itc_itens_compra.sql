CREATE TABLE [dbo].[itc_itens_compra] (
    [itc_cod]         INT        NOT NULL,
    [itc_qtde]        FLOAT (53) NULL,
    [itc_valor]       MONEY      NULL,
    [itc_cod_compra]  INT        NOT NULL,
    [itc_cod_produto] INT        NOT NULL,
    CONSTRAINT [XPKitenscompra] PRIMARY KEY NONCLUSTERED ([itc_cod] ASC, [itc_cod_compra] ASC, [itc_cod_produto] ASC),
    CONSTRAINT [R_15] FOREIGN KEY ([itc_cod_compra]) REFERENCES [dbo].[com_compra] ([com_cod]),
    CONSTRAINT [R_17] FOREIGN KEY ([itc_cod_produto]) REFERENCES [dbo].[pro_produto] ([pro_cod])
);

