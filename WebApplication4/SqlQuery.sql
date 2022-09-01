CREATE TABLE [dbo].[Users]
(
	[UID] [int] IDENTITY(1,1) NOT NULL,
	[Username] [nvarchar](128) NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[Active] [bit] NOT NULL DEFAULT(CONVERT(BIT, 1))
);


INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('gwashington', '1234', 0);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('alincoln', '1234', 0);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('jfkennedy', '1234', 0);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('jcarter', '1234', 0);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('gford', '1234', 1);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('rreagan', '1234', 0);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('ghbush', '1234', 1);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('bclinton', '1234', 1);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('gwbush', '1234', 1);
INSERT INTO [dbo].[Users] ([Username], [Password], [Active]) VALUES ('bobama', '1234', 1);




