CREATE TABLE [dbo].[cli_cliente] (
    [cli_cod]       INT          IDENTITY (1, 1) NOT NULL,
    [cli_nome]      VARCHAR (95) NULL,
    [cli_cpfcnpj]   VARCHAR (95) NULL,
    [cli_rgie]      VARCHAR (95) NULL,
    [cli_rsocial]   VARCHAR (95) NULL,
    [cli_tipo]      VARCHAR (20) NULL,
    [cli_cep]       VARCHAR (20) NULL,
    [cli_endereco]  VARCHAR (95) NULL,
    [cli_bairro]    VARCHAR (95) NULL,
    [cli_fone]      VARCHAR (95) NULL,
    [cli_cel]       VARCHAR (95) NULL,
    [cli_email]     VARCHAR (95) NULL,
    [cli_endnumero] VARCHAR (10) NULL,
    [cli_cidade]    CHAR (18)    NULL,
    [cli_estado]    CHAR (18)    NULL,
    CONSTRAINT [XPKcliente] PRIMARY KEY NONCLUSTERED ([cli_cod] ASC)
);

