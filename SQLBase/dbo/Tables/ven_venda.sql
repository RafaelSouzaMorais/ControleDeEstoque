CREATE TABLE [dbo].[ven_venda] (
    [ven_cod]            INT           IDENTITY (1, 1) NOT NULL,
    [ven_data]           DATETIME      NULL,
    [ven_valor_total]    MONEY         NULL,
    [ven_valor_recebido] MONEY         NULL,
    [ven_observacao]     VARCHAR (MAX) NULL,
    [ven_cod_usuario]    INT           NULL,
    CONSTRAINT [XPKvenda] PRIMARY KEY NONCLUSTERED ([ven_cod] ASC)
);

