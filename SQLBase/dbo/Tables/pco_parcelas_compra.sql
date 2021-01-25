CREATE TABLE [dbo].[pco_parcelas_compra] (
    [pco_cod]        INT   NOT NULL,
    [pco_valor]      MONEY NULL,
    [pco_datapagto]  DATE  NULL,
    [pco_datavecto]  DATE  NULL,
    [pco_cod_compra] INT   NOT NULL,
    CONSTRAINT [XPKparcelascompra] PRIMARY KEY CLUSTERED ([pco_cod] ASC, [pco_cod_compra] ASC),
    CONSTRAINT [R_25] FOREIGN KEY ([pco_cod_compra]) REFERENCES [dbo].[com_compra] ([com_cod])
);

