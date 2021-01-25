CREATE TABLE [dbo].[itv_itens_venda] (
    [itv_cod]         INT        NOT NULL,
    [itv_qtde]        FLOAT (53) NULL,
    [itv_valor]       MONEY      NULL,
    [itv_cod_venda]   INT        NOT NULL,
    [itv_cod_produto] INT        NOT NULL,
    CONSTRAINT [XPKitensVenda] PRIMARY KEY NONCLUSTERED ([itv_cod] ASC, [itv_cod_venda] ASC, [itv_cod_produto] ASC),
    CONSTRAINT [R_13] FOREIGN KEY ([itv_cod_venda]) REFERENCES [dbo].[ven_venda] ([ven_cod]),
    CONSTRAINT [R_14] FOREIGN KEY ([itv_cod_produto]) REFERENCES [dbo].[pro_produto] ([pro_cod])
);

