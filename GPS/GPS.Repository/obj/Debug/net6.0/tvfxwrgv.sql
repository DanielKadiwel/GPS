IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Empresas] (
    [Id] int NOT NULL IDENTITY,
    [status] nvarchar(max) NOT NULL,
    [message] nvarchar(max) NOT NULL,
    [cnpj] nvarchar(max) NOT NULL,
    [tipo] nvarchar(max) NOT NULL,
    [abertura] nvarchar(max) NOT NULL,
    [nome] nvarchar(max) NOT NULL,
    [fantasia] nvarchar(max) NOT NULL,
    [natureza_juridica] nvarchar(max) NOT NULL,
    [logradouro] nvarchar(max) NOT NULL,
    [numero] nvarchar(max) NOT NULL,
    [complemento] nvarchar(max) NOT NULL,
    [cep] nvarchar(max) NOT NULL,
    [bairro] nvarchar(max) NOT NULL,
    [municipio] nvarchar(max) NOT NULL,
    [uf] nvarchar(max) NOT NULL,
    [email] nvarchar(max) NOT NULL,
    [telefone] nvarchar(max) NOT NULL,
    [efr] nvarchar(max) NOT NULL,
    [situacao] nvarchar(max) NOT NULL,
    [data_situacao] nvarchar(max) NOT NULL,
    [motivo_situacao] nvarchar(max) NOT NULL,
    [situacao_especial] nvarchar(max) NOT NULL,
    [data_situacao_especial] nvarchar(max) NOT NULL,
    [capital_social] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Empresas] PRIMARY KEY ([Id])
);
GO

CREATE TABLE [atividade_principais] (
    [id] int NOT NULL IDENTITY,
    [EmpresaId] int NOT NULL,
    [code] nvarchar(max) NOT NULL,
    [text] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_atividade_principais] PRIMARY KEY ([id]),
    CONSTRAINT [FK_atividade_principais_Empresas_EmpresaId] FOREIGN KEY ([EmpresaId]) REFERENCES [Empresas] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [atividades_secundarias] (
    [id] int NOT NULL IDENTITY,
    [EmpresaId] int NOT NULL,
    [code] nvarchar(max) NOT NULL,
    [text] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_atividades_secundarias] PRIMARY KEY ([id]),
    CONSTRAINT [FK_atividades_secundarias_Empresas_EmpresaId] FOREIGN KEY ([EmpresaId]) REFERENCES [Empresas] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [billing] (
    [id] int NOT NULL IDENTITY,
    [EmpresaId] int NOT NULL,
    [free] bit NOT NULL,
    [database] bit NOT NULL,
    CONSTRAINT [PK_billing] PRIMARY KEY ([id]),
    CONSTRAINT [FK_billing_Empresas_EmpresaId] FOREIGN KEY ([EmpresaId]) REFERENCES [Empresas] ([Id]) ON DELETE CASCADE
);
GO

CREATE TABLE [qsas] (
    [id] int NOT NULL IDENTITY,
    [EmpresaId] int NOT NULL,
    [nome] nvarchar(max) NOT NULL,
    [qual] nvarchar(max) NOT NULL,
    [pais_origem] nvarchar(max) NOT NULL,
    [nome_rep_legal] nvarchar(max) NOT NULL,
    [qual_rep_legal] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_qsas] PRIMARY KEY ([id]),
    CONSTRAINT [FK_qsas_Empresas_EmpresaId] FOREIGN KEY ([EmpresaId]) REFERENCES [Empresas] ([Id]) ON DELETE CASCADE
);
GO

CREATE INDEX [IX_atividade_principais_EmpresaId] ON [atividade_principais] ([EmpresaId]);
GO

CREATE INDEX [IX_atividades_secundarias_EmpresaId] ON [atividades_secundarias] ([EmpresaId]);
GO

CREATE UNIQUE INDEX [IX_billing_EmpresaId] ON [billing] ([EmpresaId]);
GO

CREATE INDEX [IX_qsas_EmpresaId] ON [qsas] ([EmpresaId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20221031015636_initial', N'6.0.10');
GO

COMMIT;
GO

