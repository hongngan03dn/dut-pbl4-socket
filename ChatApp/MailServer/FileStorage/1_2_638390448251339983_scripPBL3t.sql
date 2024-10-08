/****** Object:  Database [testpbldb]    Script Date: 10/6/2023 9:08:54 AM ******/
CREATE DATABASE [testpbldb]  (EDITION = 'Basic', SERVICE_OBJECTIVE = 'Basic', MAXSIZE = 2 GB) WITH CATALOG_COLLATION = SQL_Latin1_General_CP1_CI_AS;
GO
ALTER DATABASE [testpbldb] SET COMPATIBILITY_LEVEL = 150
GO
ALTER DATABASE [testpbldb] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [testpbldb] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [testpbldb] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [testpbldb] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [testpbldb] SET ARITHABORT OFF 
GO
ALTER DATABASE [testpbldb] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [testpbldb] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [testpbldb] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [testpbldb] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [testpbldb] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [testpbldb] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [testpbldb] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [testpbldb] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [testpbldb] SET ALLOW_SNAPSHOT_ISOLATION ON 
GO
ALTER DATABASE [testpbldb] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [testpbldb] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [testpbldb] SET  MULTI_USER 
GO
ALTER DATABASE [testpbldb] SET ENCRYPTION ON
GO
ALTER DATABASE [testpbldb] SET QUERY_STORE = ON
GO
ALTER DATABASE [testpbldb] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 7), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 10, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
/*** The scripts of database scoped configurations in Azure should be executed inside the target database connection. ***/
GO
-- ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 8;
GO
/****** Object:  Table [dbo].[Accounts]    Script Date: 10/6/2023 9:08:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Accounts](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[Gmail] [varchar](50) NOT NULL,
	[Password] [varchar](64) NULL,
	[Status] [int] NOT NULL,
	[Description] [varchar](20) NULL,
	[CreatedBy] [varchar](10) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [varchar](10) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Accounts] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_Accounts_Users] UNIQUE NONCLUSTERED 
(
	[IdUser] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicalRecordDetails]    Script Date: 10/6/2023 9:08:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalRecordDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdMedicalRecord] [int] NOT NULL,
	[IdMeeting] [int] NOT NULL,
	[Medication] [varchar](100) NULL,
	[Diagnosis] [varchar](50) NULL,
	[Status] [int] NOT NULL,
	[Description] [varchar](20) NULL,
	[CreatedBy] [varchar](10) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [varchar](10) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_MedicalRecordDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_MedicalRecordDetails_Meetings] UNIQUE NONCLUSTERED 
(
	[IdMeeting] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[MedicalRecords]    Script Date: 10/6/2023 9:08:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[MedicalRecords](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[BloodType] [varchar](7) NULL,
	[Allergy] [varchar](20) NULL,
	[Status] [int] NOT NULL,
	[Description] [varchar](20) NULL,
	[CreatedBy] [varchar](10) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [varchar](10) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_MedicalRecords] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_MedicalRecords_Users] UNIQUE NONCLUSTERED 
(
	[IdUser] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Meetings]    Script Date: 10/6/2023 9:08:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Meetings](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdPatient] [int] NOT NULL,
	[IdSchedule] [int] NULL,
	[Reason] [varchar](30) NULL,
	[Symptom] [varchar](30) NULL,
	[Status] [int] NOT NULL,
	[Description] [varchar](20) NULL,
	[CreatedBy] [varchar](10) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [varchar](10) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Meetings] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ__Meetings__D16D3B632107A5FB] UNIQUE NONCLUSTERED 
(
	[IdSchedule] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Roles]    Script Date: 10/6/2023 9:08:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Roles](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [varchar](10) NOT NULL,
	[Status] [int] NOT NULL,
	[Description] [varchar](20) NULL,
	[CreatedBy] [varchar](10) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [varchar](10) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Schedules]    Script Date: 10/6/2023 9:08:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Schedules](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdUser] [int] NOT NULL,
	[StartShift] [datetime2](7) NULL,
	[Status] [int] NOT NULL,
	[Description] [varchar](20) NULL,
	[CreatedBy] [varchar](10) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [varchar](10) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Schedules] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 10/6/2023 9:08:54 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdRole] [int] NOT NULL,
	[Name] [varchar](25) NULL,
	[Birth] [datetime2](7) NULL,
	[Gender] [bit] NULL,
	[PhoneNumber] [varchar](15) NULL,
	[Status] [int] NOT NULL,
	[Description] [varchar](150) NULL,
	[CreatedBy] [varchar](10) NULL,
	[CreatedDate] [datetime2](7) NULL,
	[UpdatedBy] [varchar](10) NULL,
	[UpdatedDate] [datetime2](7) NULL,
 CONSTRAINT [PK_Users] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Accounts]  WITH CHECK ADD  CONSTRAINT [FK_Accounts_Users_IdUser] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Accounts] CHECK CONSTRAINT [FK_Accounts_Users_IdUser]
GO
ALTER TABLE [dbo].[MedicalRecordDetails]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecordDetails_MedicalRecords_IdMedicalRecord] FOREIGN KEY([IdMedicalRecord])
REFERENCES [dbo].[MedicalRecords] ([Id])
GO
ALTER TABLE [dbo].[MedicalRecordDetails] CHECK CONSTRAINT [FK_MedicalRecordDetails_MedicalRecords_IdMedicalRecord]
GO
ALTER TABLE [dbo].[MedicalRecordDetails]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecordDetails_Meetings_IdMeeting] FOREIGN KEY([IdMeeting])
REFERENCES [dbo].[Meetings] ([Id])
GO
ALTER TABLE [dbo].[MedicalRecordDetails] CHECK CONSTRAINT [FK_MedicalRecordDetails_Meetings_IdMeeting]
GO
ALTER TABLE [dbo].[MedicalRecords]  WITH CHECK ADD  CONSTRAINT [FK_MedicalRecords_Users_IdUser] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[MedicalRecords] CHECK CONSTRAINT [FK_MedicalRecords_Users_IdUser]
GO
ALTER TABLE [dbo].[Meetings]  WITH CHECK ADD  CONSTRAINT [FK__Meetings__IdSche__151B244E] FOREIGN KEY([IdSchedule])
REFERENCES [dbo].[Schedules] ([Id])
GO
ALTER TABLE [dbo].[Meetings] CHECK CONSTRAINT [FK__Meetings__IdSche__151B244E]
GO
ALTER TABLE [dbo].[Meetings]  WITH CHECK ADD  CONSTRAINT [FK_Meetings_Users_IdPatient] FOREIGN KEY([IdPatient])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Meetings] CHECK CONSTRAINT [FK_Meetings_Users_IdPatient]
GO
ALTER TABLE [dbo].[Schedules]  WITH CHECK ADD  CONSTRAINT [FK_Schedules_Users_IdUser] FOREIGN KEY([IdUser])
REFERENCES [dbo].[Users] ([Id])
GO
ALTER TABLE [dbo].[Schedules] CHECK CONSTRAINT [FK_Schedules_Users_IdUser]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_Users_Roles_IdRole] FOREIGN KEY([IdRole])
REFERENCES [dbo].[Roles] ([Id])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_Users_Roles_IdRole]
GO
ALTER DATABASE [testpbldb] SET  READ_WRITE 
GO
