CREATE TABLE [dbo].[com_compra] (
    [com_cod]                INT          IDENTITY (1, 1) NOT NULL,
    [com_data]               DATETIME     NULL,
    [com_nfiscal]            INT          NULL,
    [com_total]              MONEY        NULL,
    [com_nparcelas]          INT          NULL,
    [com_status]             VARCHAR (95) NULL,
    [com_cod_fornecedor]     INT          NULL,
    [com_cod_tipo_pagamento] INT          NULL,
    CONSTRAINT [XPKcompra] PRIMARY KEY NONCLUSTERED ([com_cod] ASC),
    CONSTRAINT [R_21] FOREIGN KEY ([com_cod_fornecedor]) REFERENCES [dbo].[for_fornecedor] ([for_cod]),
    CONSTRAINT [R_24] FOREIGN KEY ([com_cod_tipo_pagamento]) REFERENCES [dbo].[tpa_tipo_pagamento] ([tpa_cod])
);

