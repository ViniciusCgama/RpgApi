BEGIN TRANSACTION;
GO

CREATE TABLE [TB_ARMAS] (
    [IdF] int NOT NULL IDENTITY,
    [NomeF] nvarchar(max) NOT NULL,
    [DanoF] int NOT NULL,
    CONSTRAINT [PK_TB_ARMAS] PRIMARY KEY ([IdF])
);
GO

IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdF', N'DanoF', N'NomeF') AND [object_id] = OBJECT_ID(N'[TB_ARMAS]'))
    SET IDENTITY_INSERT [TB_ARMAS] ON;
INSERT INTO [TB_ARMAS] ([IdF], [DanoF], [NomeF])
VALUES (1, 50, N'Espada de cria demoniaca'),
(2, 45, N'Faca envenenada'),
(3, 75, N'Arco da fenda do vazio'),
(4, 69, N'Machado do Cleyton'),
(5, 35, N'Chicote do Desejo'),
(6, 42, N'Baseball BAT'),
(7, 50, N'Manopla do grande roxo');
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'IdF', N'DanoF', N'NomeF') AND [object_id] = OBJECT_ID(N'[TB_ARMAS]'))
    SET IDENTITY_INSERT [TB_ARMAS] OFF;
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20230926140615_MigracaoArmas', N'7.0.10');
GO

COMMIT;
GO

