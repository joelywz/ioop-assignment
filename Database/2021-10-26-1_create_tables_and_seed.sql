GO
/****** Object:  Table [dbo].[CompletedService]    Script Date: 26/10/2021 12:29:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompletedService](
	[completedServiceId] [int] IDENTITY(1,1) NOT NULL,
	[userId] [int] NOT NULL,
	[completedByUserId] [int] NOT NULL,
	[serviceId] [int] NOT NULL,
	[urgent] [bit] NOT NULL,
	[price] [float] NOT NULL,
	[hasPaid] [bit] NOT NULL,
	[description] [text] NOT NULL,
	[dateTimeCreated] [datetime] NOT NULL,
	[dateTimeCompleted] [datetime] NOT NULL,
 CONSTRAINT [PK_CompletedService] PRIMARY KEY CLUSTERED 
(
	[completedServiceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IncompleteService]    Script Date: 26/10/2021 12:29:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncompleteService](
	[userId] [int] NOT NULL,
	[serviceId] [int] NOT NULL,
	[urgent] [bit] NOT NULL,
	[dateTimeCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_IncompleteService] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Service]    Script Date: 26/10/2021 12:29:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Service](
	[serviceId] [int] NOT NULL,
	[price] [float] NOT NULL,
	[urgentPrice] [float] NOT NULL,
	[name] [text] NOT NULL,
 CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED 
(
	[serviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 26/10/2021 12:29:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[userId] [int] IDENTITY(1,1) NOT NULL,
	[username] [varchar](50) NOT NULL,
	[fullName] [varchar](128) NOT NULL,
	[email] [varchar](128) NOT NULL,
	[password] [varchar](128) NOT NULL,
	[phoneNo] [varchar](128) NOT NULL,
	[ic] [varchar](128) NULL,
	[dateOfBirth] [varchar](128) NULL,
	[role] [int] NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[userId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[IncompleteService] ([userId], [serviceId], [urgent], [dateTimeCreated]) VALUES (5, 7, 1, CAST(N'2021-10-26T10:23:38.267' AS DateTime))
INSERT [dbo].[IncompleteService] ([userId], [serviceId], [urgent], [dateTimeCreated]) VALUES (8, 3, 1, CAST(N'2021-10-26T10:35:09.683' AS DateTime))
GO
INSERT [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (1, 50, 80, N'Remove virus, malware or spyware')
INSERT [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (2, 60, 90, N'Troubleshot and fix computer running slow')
INSERT [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (3, 380, 430, N'Laptop screen replacement')
INSERT [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (4, 160, 200, N'Laptop keyboard replacement')
INSERT [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (5, 180, 210, N'Laptop battery replacement')
INSERT [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (6, 100, 150, N'Operating System Format and Installation')
INSERT [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (7, 80, 130, N'Data backup and recovery')
INSERT [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (8, 70, 100, N'Internet connectivity issues')
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (1, N'johndoe', N'John Doe', N'johndoe@gmail.com', N'johndoe', N'0123456789', NULL, N'1996-12-25', 0)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (2, N'janedoe', N'Jane Doe', N'janedoe@gmail.com', N'janedoe', N'0183675829', NULL, N'1997-5-23', 1)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (3, N'johnsmith', N'John Smith', N'johnsmith@gmail.com', N'johnsmith', N'0169247129', NULL, N'1992-10-5', 2)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (4, N'joeblow', N'Joe Blow', N'joeblow@yahoo.com', N'joeblow', N'0165902752', NULL, N'1997-5-20', 3)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (5, N'samueljackson', N'Samuel Jackson', N'samueljackson@yahoo.com', N'samueljackson', N'0125684956', NULL, NULL, 0)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (6, N'jamesbond', N'James Bond', N'jamesbond@gmail.com', N'jamesbond', N'0122441231', NULL, NULL, 0)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (7, N'alexsmith', N'Alex Smith', N'alexsmith@gmail.com', N'alexsmith', N'0123947283', NULL, NULL, 0)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (8, N'peglegge', N'Peg Legge', N'iampeg@hotmail.com', N'peglegge', N'0122837679', NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UQ__User__F3DBC572219ABD0A]    Script Date: 26/10/2021 12:29:51 PM ******/
ALTER TABLE [dbo].[User] ADD UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CompletedService] ADD  DEFAULT ((0)) FOR [hasPaid]
GO
ALTER TABLE [dbo].[CompletedService] ADD  DEFAULT (sysdatetime()) FOR [dateTimeCompleted]
GO
ALTER TABLE [dbo].[IncompleteService] ADD  DEFAULT (sysdatetime()) FOR [dateTimeCreated]
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((0)) FOR [role]
GO
ALTER TABLE [dbo].[CompletedService]  WITH CHECK ADD  CONSTRAINT [FK_CompletedService_Service] FOREIGN KEY([serviceId])
REFERENCES [dbo].[Service] ([serviceId])
GO
ALTER TABLE [dbo].[CompletedService] CHECK CONSTRAINT [FK_CompletedService_Service]
GO
ALTER TABLE [dbo].[CompletedService]  WITH CHECK ADD  CONSTRAINT [FK_CompletedServices_CompletedByUser] FOREIGN KEY([completedByUserId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[CompletedService] CHECK CONSTRAINT [FK_CompletedServices_CompletedByUser]
GO
ALTER TABLE [dbo].[CompletedService]  WITH CHECK ADD  CONSTRAINT [FK_CompletedServices_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[CompletedService] CHECK CONSTRAINT [FK_CompletedServices_User]
GO
ALTER TABLE [dbo].[IncompleteService]  WITH CHECK ADD  CONSTRAINT [FK_IncompleteService_Service] FOREIGN KEY([serviceId])
REFERENCES [dbo].[Service] ([serviceId])
GO
ALTER TABLE [dbo].[IncompleteService] CHECK CONSTRAINT [FK_IncompleteService_Service]
GO
ALTER TABLE [dbo].[IncompleteService]  WITH CHECK ADD  CONSTRAINT [FK_IncompleteService_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[IncompleteService] CHECK CONSTRAINT [FK_IncompleteService_User]
GO
