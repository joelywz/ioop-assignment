
GO
/****** Object:  Table [dbo].[CompletedService]    Script Date: 25/10/2021 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CompletedService](
	[serviceId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[completedByUserId] [int] NOT NULL,
	[name] [varchar](128) NOT NULL,
	[urgent] [bit] NOT NULL,
	[status] [varchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[hasPaid] [bit] NOT NULL,
	[description] [text] NOT NULL,
	[dateTimeCreated] [datetime] NOT NULL,
	[dateTimeCompleted] [datetime] NOT NULL,
 CONSTRAINT [PK_CompletedService] PRIMARY KEY CLUSTERED 
(
	[serviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[IncompleteService]    Script Date: 25/10/2021 12:27:44 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[IncompleteService](
	[serviceId] [int] NOT NULL,
	[userId] [int] NOT NULL,
	[name] [varchar](128) NOT NULL,
	[urgent] [bit] NOT NULL,
	[status] [varchar](50) NOT NULL,
	[price] [float] NOT NULL,
	[dateTimeCreated] [datetime] NOT NULL,
 CONSTRAINT [PK_IncompleteService] PRIMARY KEY CLUSTERED 
(
	[serviceId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 25/10/2021 12:27:44 PM ******/
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
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (1, N'johndoe', N'John Doe', N'johndoe@gmail.com', N'johndoe', N'0123456789', NULL, N'1996-12-25', 0)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (2, N'janedoe', N'janedoe', N'janedoe@gmail.com', N'janedoe', N'0183675829', NULL, N'1997-5-23', 1)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (3, N'johnsmith', N'John Smith', N'johnsmith@gmail.com', N'johnsmith', N'0169247129', NULL, N'1992-10-5', 2)
INSERT [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (4, N'joeblow', N'Joe Blow', N'joeblow@yahoo.com', N'joeblow', N'0165902752', NULL, N'1997-5-20', 3)
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[User] ADD  DEFAULT ((0)) FOR [role]
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
ALTER TABLE [dbo].[IncompleteService]  WITH CHECK ADD  CONSTRAINT [FK_IncompleteServices_User] FOREIGN KEY([userId])
REFERENCES [dbo].[User] ([userId])
GO
ALTER TABLE [dbo].[IncompleteService] CHECK CONSTRAINT [FK_IncompleteServices_User]
GO
