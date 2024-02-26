CREATE TABLE [dbo].[utilizadores]
(
	[Id] INT NOT NULL PRIMARY KEY,
	[nome] NVARCHAR(50) NULL,
	[login] NVARCHAR(50) NULL,
	[pass] NCHAR(10) NULL,
	[email] NVARCHAR(50) NULL,
)
