CREATE TABLE [dbo].[umed_und_medida] (
    [umed_cod]  INT          IDENTITY (1, 1) NOT NULL,
    [umed_nome] VARCHAR (95) NULL,
    CONSTRAINT [XPKmedida] PRIMARY KEY NONCLUSTERED ([umed_cod] ASC)
);

