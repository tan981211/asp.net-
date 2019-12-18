SET IDENTITY_INSERT [dbo].[user] ON
INSERT INTO [dbo].[user] ([userId], [userName], [userEmail], [userPhone], [userAddress], [userPassword]) VALUES (NULL, NULL, NULL, NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[user] OFF
Use safe
insert into [dbo].[user] values('100','张三','609736480@qq.com','15362924645','1','123')