CREATE TABLE [dbo].[estq_estoque] (
    [estq_cod]           INT           IDENTITY (1, 1) NOT NULL,
    [estq_data_validade] DATETIME      NULL,
    [estq_cod_produto]   INT           NOT NULL,
    [estq_quantidade]    FLOAT (53)    NOT NULL,
    [estq_codigo_barra]  VARCHAR (MAX) NULL,
    CONSTRAINT [PK_estq_estoque] PRIMARY KEY CLUSTERED ([estq_cod] ASC),
    CONSTRAINT [FK_estoque_produto] FOREIGN KEY ([estq_cod_produto]) REFERENCES [dbo].[pro_produto] ([pro_cod])
);

