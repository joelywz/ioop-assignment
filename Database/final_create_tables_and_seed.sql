
-- Create User Table
CREATE TABLE [dbo].[User] (
    [userId]      INT           IDENTITY (1, 1) NOT NULL,
    [username]    VARCHAR (50)  NOT NULL,
    [fullName]    VARCHAR (128) NOT NULL,
    [email]       VARCHAR (128) NOT NULL,
    [password]    VARCHAR (128) NOT NULL,
    [phoneNo]     VARCHAR (128) NOT NULL,
    [ic]          VARCHAR (128) NULL,
    [dateOfBirth] VARCHAR (128) NULL,
    [role]        INT           DEFAULT ((0)) NOT NULL,
    CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED ([userId] ASC),
    UNIQUE NONCLUSTERED ([username] ASC)
);

-- Create Service Table
CREATE TABLE [dbo].[Service] (
    [serviceId]   INT        NOT NULL,
    [price]       FLOAT (53) NOT NULL,
    [urgentPrice] FLOAT (53) NOT NULL,
    [name]        TEXT       NOT NULL,
    CONSTRAINT [PK_Service] PRIMARY KEY CLUSTERED ([serviceId] ASC)
);

-- Create IncompleteService Table
CREATE TABLE [dbo].[IncompleteService] (
    [userId]          INT      NOT NULL,
    [serviceId]       INT      NOT NULL,
    [urgent]          BIT      NOT NULL,
    [dateTimeCreated] DATETIME DEFAULT (sysdatetime()) NOT NULL,
    CONSTRAINT [PK_IncompleteService] PRIMARY KEY CLUSTERED ([userId] ASC),
    CONSTRAINT [FK_IncompleteService_Service] FOREIGN KEY ([serviceId]) REFERENCES [dbo].[Service] ([serviceId]),
    CONSTRAINT [FK_IncompleteService_User] FOREIGN KEY ([userId]) REFERENCES [dbo].[User] ([userId])
);

-- Create CompletedService Table
CREATE TABLE [dbo].[CompletedService] (
    [completedServiceId] INT        IDENTITY (1, 1) NOT NULL,
    [userId]             INT        NOT NULL,
    [technicianId]       INT        NOT NULL,
    [serviceId]          INT        NOT NULL,
    [urgent]             BIT        NOT NULL,
    [price]              FLOAT (53) NOT NULL,
    [hasPaid]            BIT        DEFAULT ((0)) NOT NULL,
    [description]        TEXT       NOT NULL,
    [dateTimeCreated]    DATETIME   NOT NULL,
    [dateTimeCompleted]  DATETIME   DEFAULT (sysdatetime()) NOT NULL,
    CONSTRAINT [PK_CompletedService] PRIMARY KEY CLUSTERED ([completedServiceId] ASC),
    CONSTRAINT [FK_CompletedService_Service] FOREIGN KEY ([serviceId]) REFERENCES [dbo].[Service] ([serviceId]),
    CONSTRAINT [FK_CompletedServices_TechnicianUser] FOREIGN KEY ([technicianId]) REFERENCES [dbo].[User] ([userId]),
    CONSTRAINT [FK_CompletedServices_User] FOREIGN KEY ([userId]) REFERENCES [dbo].[User] ([userId])
);

-- Data
SET IDENTITY_INSERT [dbo].[User] ON
INSERT INTO [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (1, N'johndoe', N'John Doe', N'johndoe@gmail.com', N'johndoe', N'0123456789', NULL, N'1996-12-25', 0)
INSERT INTO [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (2, N'janedoe', N'Jane Doe', N'janedoe@gmail.com', N'janedoe', N'0183675829', NULL, N'1997-5-23', 1)
INSERT INTO [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (3, N'johnsmith', N'John Smith', N'johnsmith@gmail.com', N'johnsmith', N'0169247129', NULL, N'1992-10-05', 2)
INSERT INTO [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (4, N'joeblow', N'Joe Blow', N'joeblow@yahoo.com', N'joeblow', N'0165902752', NULL, N'1997-5-20', 3)
INSERT INTO [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (5, N'samueljackson', N'Samuel Jackson', N'samueljackson@yahoo.com', N'samueljackson', N'0125684956', NULL, NULL, 0)
INSERT INTO [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (6, N'jamesbond', N'James Bond', N'jamesbond@gmail.com', N'jamesbond', N'0122441231', NULL, NULL, 0)
INSERT INTO [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (7, N'alexsmith', N'Alex Smith', N'alexsmith@gmail.com', N'alexsmith', N'0123947283', NULL, NULL, 0)
INSERT INTO [dbo].[User] ([userId], [username], [fullName], [email], [password], [phoneNo], [ic], [dateOfBirth], [role]) VALUES (8, N'peglegge', N'Peg Legge', N'iampeg@hotmail.com', N'peglegge', N'0122837679', NULL, NULL, 0)
SET IDENTITY_INSERT [dbo].[User] OFF

INSERT INTO [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (1, 50, 80, N'Remove virus, malware or spyware')
INSERT INTO [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (2, 60, 90, N'Troubleshot and fix computer running slow')
INSERT INTO [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (3, 380, 430, N'Laptop screen replacement')
INSERT INTO [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (4, 160, 200, N'Laptop keyboard replacement')
INSERT INTO [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (5, 180, 210, N'Laptop battery replacement')
INSERT INTO [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (6, 100, 150, N'Operating System Format and Installation')
INSERT INTO [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (7, 80, 130, N'Data backup and recovery')
INSERT INTO [dbo].[Service] ([serviceId], [price], [urgentPrice], [name]) VALUES (8, 70, 100, N'Internet connectivity issues')

INSERT INTO [dbo].[IncompleteService] ([userId], [serviceId], [urgent], [dateTimeCreated]) VALUES (1, 4, 1, N'2021-11-09 23:31:20')
INSERT INTO [dbo].[IncompleteService] ([userId], [serviceId], [urgent], [dateTimeCreated]) VALUES (6, 7, 1, N'2021-11-09 23:32:56')
INSERT INTO [dbo].[IncompleteService] ([userId], [serviceId], [urgent], [dateTimeCreated]) VALUES (7, 5, 1, N'2021-10-26 13:08:50')
INSERT INTO [dbo].[IncompleteService] ([userId], [serviceId], [urgent], [dateTimeCreated]) VALUES (8, 3, 1, N'2021-10-26 10:35:09')

SET IDENTITY_INSERT [dbo].[CompletedService] ON
INSERT INTO [dbo].[CompletedService] ([completedServiceId], [userId], [technicianId], [serviceId], [urgent], [price], [hasPaid], [description], [dateTimeCreated], [dateTimeCompleted]) VALUES (1, 6, 4, 6, 1, 150, 1, N'Warranty 1 year.', N'2021-06-26 10:23:38', N'2021-06-26 16:24:17')
INSERT INTO [dbo].[CompletedService] ([completedServiceId], [userId], [technicianId], [serviceId], [urgent], [price], [hasPaid], [description], [dateTimeCreated], [dateTimeCompleted]) VALUES (2, 7, 3, 2, 1, 90, 1, N'Warranty 2 years.', N'2021-07-15 10:23:38', N'2021-07-16 16:24:17')
INSERT INTO [dbo].[CompletedService] ([completedServiceId], [userId], [technicianId], [serviceId], [urgent], [price], [hasPaid], [description], [dateTimeCreated], [dateTimeCompleted]) VALUES (3, 8, 4, 1, 0, 50, 1, N'Warranty 2 years.', N'2021-08-26 10:23:38', N'2021-08-27 16:24:17')
INSERT INTO [dbo].[CompletedService] ([completedServiceId], [userId], [technicianId], [serviceId], [urgent], [price], [hasPaid], [description], [dateTimeCreated], [dateTimeCompleted]) VALUES (4, 9, 4, 6, 1, 150, 1, N'Warranty 3 years.', N'2021-10-26 10:23:38', N'2021-10-26 16:24:17')
INSERT INTO [dbo].[CompletedService] ([completedServiceId], [userId], [technicianId], [serviceId], [urgent], [price], [hasPaid], [description], [dateTimeCreated], [dateTimeCompleted]) VALUES (5, 6, 3, 7, 0, 80, 1, N'Warranty 1 year.', N'2021-10-25 10:30:00', N'2021-10-26 10:30:00')
INSERT INTO [dbo].[CompletedService] ([completedServiceId], [userId], [technicianId], [serviceId], [urgent], [price], [hasPaid], [description], [dateTimeCreated], [dateTimeCompleted]) VALUES (6, 7, 4, 7, 0, 130, 1, N'Warranty 2 years.', N'2021-11-02 14:00:00', N'2021-11-03 17:07:47')
INSERT INTO [dbo].[CompletedService] ([completedServiceId], [userId], [technicianId], [serviceId], [urgent], [price], [hasPaid], [description], [dateTimeCreated], [dateTimeCompleted]) VALUES (7, 8, 3, 8, 0, 100, 1, N'No warranty', N'2021-11-03 00:00:00', N'2021-11-04 00:00:00')
INSERT INTO [dbo].[CompletedService] ([completedServiceId], [userId], [technicianId], [serviceId], [urgent], [price], [hasPaid], [description], [dateTimeCreated], [dateTimeCompleted]) VALUES (8, 9, 4, 2, 1, 90, 1, N'Warranty 6 months,', N'2021-11-05 21:45:55', N'2021-11-06 21:46:26')
SET IDENTITY_INSERT [dbo].[CompletedService] OFF







