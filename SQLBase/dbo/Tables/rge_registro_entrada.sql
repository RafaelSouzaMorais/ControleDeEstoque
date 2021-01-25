CREATE TABLE [dbo].[rge_registro_entrada] (
    [rge_cod]           INT        IDENTITY (1, 1) NOT NULL,
    [rge_cod_estoque]   INT        NOT NULL,
    [rge_quantidade]    FLOAT (53) NOT NULL,
    [rge_data_registro] DATETIME   NOT NULL,
    [rge_cod_usuario]   INT        NULL,
    [rge_valor_pago]    MONEY      NOT NULL,
    CONSTRAINT [PK_rge_registro_entrada] PRIMARY KEY CLUSTERED ([rge_cod] ASC),
    CONSTRAINT [FK_rge_registro_entrada_estq_estoque] FOREIGN KEY ([rge_cod_estoque]) REFERENCES [dbo].[estq_estoque] ([estq_cod])
);

