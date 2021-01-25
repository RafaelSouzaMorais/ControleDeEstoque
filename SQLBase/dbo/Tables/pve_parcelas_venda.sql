CREATE TABLE [dbo].[pve_parcelas_venda] (
    [pve_cod]       INT   NOT NULL,
    [pve_valor]     MONEY NULL,
    [pve_datapagto] DATE  NULL,
    [pve_datavecto] DATE  NULL,
    [pve_cod_venda] INT   NOT NULL,
    CONSTRAINT [XPKparcelasvenda] PRIMARY KEY CLUSTERED ([pve_cod_venda] ASC, [pve_cod] ASC),
    CONSTRAINT [R_22] FOREIGN KEY ([pve_cod_venda]) REFERENCES [dbo].[ven_venda] ([ven_cod])
);

