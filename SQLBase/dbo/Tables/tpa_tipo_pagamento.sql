CREATE TABLE [dbo].[tpa_tipo_pagamento] (
    [tpa_cod]  INT          IDENTITY (1, 1) NOT NULL,
    [tpa_nome] VARCHAR (90) NULL,
    CONSTRAINT [XPKtipopagamento] PRIMARY KEY CLUSTERED ([tpa_cod] ASC)
);

