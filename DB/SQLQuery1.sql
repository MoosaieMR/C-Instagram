USE [master]
GO
/****** Object:  Database [AATest]    Script Date: 2/23/2023 3:49:36 PM ******/
CREATE DATABASE [AATest];

USE [AATest] ; 

GO;

CREATE TABLE [dbo].[Users](
	[U_ID] [int] IDENTITY(1,1) NOT NULL,
	[UT_ID_fk] [int] NULL,
	[U_FirstName] [nvarchar](100) NULL,
	[U_LastName] [nvarchar](100) NULL,
	[U_Gender] [bit] NULL,
	[U_MeliCode] [char](10) NULL,
	[U_Email] [nvarchar](100) NULL,
	[U_Mobile] [varchar](200) NULL,
	[U_Username] [nvarchar](100) NULL,
	[U_Password] [nvarchar](100) NULL,
	[U_Image] [image] NULL,
	[U_Address] [nvarchar](100) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[U_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

CREATE TABLE [dbo].[UserTypes](
	[UT_ID] [int] IDENTITY(1,1) NOT NULL,
	[UT_Name] [nvarchar](100) NULL,
 CONSTRAINT [PK_UserTypes] PRIMARY KEY CLUSTERED 
(
	[UT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_UserTypes] FOREIGN KEY([UT_ID_fk])
REFERENCES [dbo].[UserTypes] ([UT_ID])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_UserTypes]
GO
