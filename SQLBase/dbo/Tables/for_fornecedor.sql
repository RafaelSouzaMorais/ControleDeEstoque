CREATE TABLE [dbo].[for_fornecedor] (
    [for_cod]       INT          IDENTITY (1, 1) NOT NULL,
    [for_nome]      VARCHAR (95) NULL,
    [for_rsocial]   VARCHAR (95) NULL,
    [for_ie]        VARCHAR (95) NULL,
    [for_cnpj]      VARCHAR (95) NULL,
    [for_cep]       VARCHAR (95) NULL,
    [for_endereco]  VARCHAR (95) NULL,
    [for_bairro]    VARCHAR (95) NULL,
    [for_fone]      VARCHAR (95) NULL,
    [for_cel]       VARCHAR (95) NULL,
    [for_email]     VARCHAR (95) NULL,
    [for_endnumero] VARCHAR (95) NULL,
    [for_cidade]    VARCHAR (95) NULL,
    [for_estado]    VARCHAR (95) NULL,
    CONSTRAINT [XPKfornecedor] PRIMARY KEY NONCLUSTERED ([for_cod] ASC)
);

