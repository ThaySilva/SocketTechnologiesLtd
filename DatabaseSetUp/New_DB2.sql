USE [master]
GO
/****** Object:  Database [stldb1]    Script Date: 01/12/2016 15:28:53 ******/
CREATE DATABASE [stldb1]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'stldb1', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.TEAM5\MSSQL\DATA\stldb1.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'stldb1_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.TEAM5\MSSQL\DATA\stldb1_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [stldb1] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [stldb1].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [stldb1] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [stldb1] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [stldb1] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [stldb1] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [stldb1] SET ARITHABORT OFF 
GO
ALTER DATABASE [stldb1] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [stldb1] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [stldb1] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [stldb1] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [stldb1] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [stldb1] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [stldb1] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [stldb1] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [stldb1] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [stldb1] SET  DISABLE_BROKER 
GO
ALTER DATABASE [stldb1] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [stldb1] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [stldb1] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [stldb1] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [stldb1] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [stldb1] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [stldb1] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [stldb1] SET RECOVERY FULL 
GO
ALTER DATABASE [stldb1] SET  MULTI_USER 
GO
ALTER DATABASE [stldb1] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [stldb1] SET DB_CHAINING OFF 
GO
ALTER DATABASE [stldb1] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [stldb1] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [stldb1] SET DELAYED_DURABILITY = DISABLED 
GO
USE [stldb1]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Customer](
	[customer_ID] [int] IDENTITY(1,1) NOT NULL,
	[custFirstName] [varchar](15) NOT NULL,
	[custLastName] [varchar](15) NOT NULL,
	[custCompanyName] [varchar](15) NOT NULL,
	[custPhoneNum] [varchar](15) NOT NULL,
	[custAddress] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Department]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Department](
	[department_ID] [int] IDENTITY(1,1) NOT NULL,
	[departmentName] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[department_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Employee]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Employee](
	[employee_ID] [int] IDENTITY(1,1) NOT NULL,
	[empFirstName] [varchar](15) NOT NULL,
	[empLastName] [varchar](15) NOT NULL,
	[empPhoneNum] [varchar](15) NOT NULL,
	[department_ID] [int] NOT NULL,
	[User_user_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[employee_ID] ASC,
	[department_ID] ASC,
	[User_user_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Lot]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Lot](
	[Lot_ID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[Description] [varchar](45) NOT NULL,
	[DateRequired] [datetime2](0) NOT NULL,
	[STLProduct_STLProduct_ID] [int] NOT NULL,
	[WorkOrder_WorkOrder_ID] [int] NOT NULL,
	[WorkOrder_Customer_customer_ID] [int] NOT NULL,
	[PMRP_PMRP_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Lot_ID] ASC,
	[STLProduct_STLProduct_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[LotTraveller]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[LotTraveller](
	[LotTraveller_ID] [int] NOT NULL,
	[ProductionProcess] [varchar](45) NOT NULL,
	[Lot_Lot_ID] [int] NOT NULL,
	[Lot_STLProduct_STLProduct_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LotTraveller_ID] ASC,
	[Lot_Lot_ID] ASC,
	[Lot_STLProduct_STLProduct_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[PMRP]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PMRP](
	[PMRP_ID] [int] NOT NULL,
	[DateRequired] [datetime2](0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[PMRP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[RawMaterials]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RawMaterials](
	[RawMaterial_ID] [int] IDENTITY(1,1) NOT NULL,
	[materialName] [nchar](20) NOT NULL,
	[materialDescription] [nchar](45) NOT NULL,
 CONSTRAINT [PK_RawMaterials] PRIMARY KEY CLUSTERED 
(
	[RawMaterial_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Report]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Report](
	[ReportID] [int] NOT NULL,
	[pathAddress] [varchar](45) NOT NULL,
	[dateCreated] [datetime2](0) NOT NULL,
	[ReportType_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReportID] ASC,
	[ReportType_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ReportType]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ReportType](
	[ReportType_ID] [int] NOT NULL,
	[ReportName] [varchar](45) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ReportType_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STL_LineItem]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STL_LineItem](
	[STLLineItem_ID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
	[UnitPrice] [decimal](2, 0) NOT NULL,
	[LinePrice] [decimal](2, 0) NOT NULL,
	[VAT] [decimal](2, 0) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STLLineItem_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[STLProduct]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[STLProduct](
	[STLProduct_ID] [int] IDENTITY(1,1) NOT NULL,
	[productName] [varchar](20) NOT NULL,
	[manufacturingInstructions] [varchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[STLProduct_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[STLProducts_Materials]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[STLProducts_Materials](
	[STLProduct_ID] [int] NOT NULL,
	[RawMaterial_ID] [int] NOT NULL,
	[Quantity] [int] NOT NULL,
 CONSTRAINT [PK_STLProducts_Materials] PRIMARY KEY CLUSTERED 
(
	[STLProduct_ID] ASC,
	[RawMaterial_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TechnicalEnquiry]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[TechnicalEnquiry](
	[TechnicalEnquiry_ID] [int] NOT NULL,
	[EnquiryText] [varchar](max) NOT NULL,
	[Responded] [smallint] NOT NULL,
	[Accepted] [smallint] NOT NULL,
	[DateCreated] [datetime2](0) NOT NULL,
	[Customer_customer_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[TechnicalEnquiry_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Users]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Users](
	[user_ID] [int] IDENTITY(1,1) NOT NULL,
	[userName] [varchar](15) NOT NULL,
	[password] [varchar](15) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[user_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WorkOrder]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[WorkOrder](
	[WorkOrder_ID] [int] IDENTITY(1,1) NOT NULL,
	[dateRequired] [datetime2](0) NOT NULL,
	[TotalPrice] [varchar](45) NULL,
	[Customer_customer_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[WorkOrder_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[WorkOrder_has_STL_LineItem]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkOrder_has_STL_LineItem](
	[WorkOrder_WorkOrder_ID] [int] NOT NULL,
	[STL_LineItem_STLLineItem_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[WorkOrder_WorkOrder_ID] ASC,
	[STL_LineItem_STLLineItem_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[WorkOrder_has_STLProduct]    Script Date: 01/12/2016 15:28:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[WorkOrder_has_STLProduct](
	[WorkOrder_WorkOrder_ID] [int] NOT NULL,
	[STLProduct_STLProduct_ID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[WorkOrder_WorkOrder_ID] ASC,
	[STLProduct_STLProduct_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Index [department_ID_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [department_ID_idx] ON [dbo].[Employee]
(
	[department_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Employee_User1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_Employee_User1_idx] ON [dbo].[Employee]
(
	[User_user_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Lot_PMRP1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_Lot_PMRP1_idx] ON [dbo].[Lot]
(
	[PMRP_PMRP_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Lot_WorkOrder1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_Lot_WorkOrder1_idx] ON [dbo].[Lot]
(
	[WorkOrder_WorkOrder_ID] ASC,
	[WorkOrder_Customer_customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_LotTraveller_Lot1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_LotTraveller_Lot1_idx] ON [dbo].[LotTraveller]
(
	[Lot_Lot_ID] ASC,
	[Lot_STLProduct_STLProduct_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_Report_ReportType1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_Report_ReportType1_idx] ON [dbo].[Report]
(
	[ReportType_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_TechnicalEnquiry_Customer1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_TechnicalEnquiry_Customer1_idx] ON [dbo].[TechnicalEnquiry]
(
	[Customer_customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_WorkOrder_Customer1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_WorkOrder_Customer1_idx] ON [dbo].[WorkOrder]
(
	[Customer_customer_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_WorkOrder_has_STL_LineItem_STL_LineItem1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_WorkOrder_has_STL_LineItem_STL_LineItem1_idx] ON [dbo].[WorkOrder_has_STL_LineItem]
(
	[STL_LineItem_STLLineItem_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_WorkOrder_has_STL_LineItem_WorkOrder1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_WorkOrder_has_STL_LineItem_WorkOrder1_idx] ON [dbo].[WorkOrder_has_STL_LineItem]
(
	[WorkOrder_WorkOrder_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_WorkOrder_has_STLProduct_STLProduct1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_WorkOrder_has_STLProduct_STLProduct1_idx] ON [dbo].[WorkOrder_has_STLProduct]
(
	[STLProduct_STLProduct_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
/****** Object:  Index [fk_WorkOrder_has_STLProduct_WorkOrder1_idx]    Script Date: 01/12/2016 15:28:53 ******/
CREATE NONCLUSTERED INDEX [fk_WorkOrder_has_STLProduct_WorkOrder1_idx] ON [dbo].[WorkOrder_has_STLProduct]
(
	[WorkOrder_WorkOrder_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [department_ID] FOREIGN KEY([department_ID])
REFERENCES [dbo].[Department] ([department_ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [department_ID]
GO
ALTER TABLE [dbo].[Employee]  WITH CHECK ADD  CONSTRAINT [fk_Employee_User1] FOREIGN KEY([User_user_ID])
REFERENCES [dbo].[Users] ([user_ID])
GO
ALTER TABLE [dbo].[Employee] CHECK CONSTRAINT [fk_Employee_User1]
GO
ALTER TABLE [dbo].[Lot]  WITH CHECK ADD  CONSTRAINT [fk_Lot_PMRP1] FOREIGN KEY([PMRP_PMRP_ID])
REFERENCES [dbo].[PMRP] ([PMRP_ID])
GO
ALTER TABLE [dbo].[Lot] CHECK CONSTRAINT [fk_Lot_PMRP1]
GO
ALTER TABLE [dbo].[Lot]  WITH CHECK ADD  CONSTRAINT [fk_Lot_WorkOrder1] FOREIGN KEY([WorkOrder_WorkOrder_ID])
REFERENCES [dbo].[WorkOrder] ([WorkOrder_ID])
GO
ALTER TABLE [dbo].[Lot] CHECK CONSTRAINT [fk_Lot_WorkOrder1]
GO
ALTER TABLE [dbo].[LotTraveller]  WITH CHECK ADD  CONSTRAINT [fk_LotTraveller_Lot1] FOREIGN KEY([Lot_Lot_ID], [Lot_STLProduct_STLProduct_ID])
REFERENCES [dbo].[Lot] ([Lot_ID], [STLProduct_STLProduct_ID])
GO
ALTER TABLE [dbo].[LotTraveller] CHECK CONSTRAINT [fk_LotTraveller_Lot1]
GO
ALTER TABLE [dbo].[Report]  WITH CHECK ADD  CONSTRAINT [fk_Report_ReportType1] FOREIGN KEY([ReportType_ID])
REFERENCES [dbo].[ReportType] ([ReportType_ID])
GO
ALTER TABLE [dbo].[Report] CHECK CONSTRAINT [fk_Report_ReportType1]
GO
ALTER TABLE [dbo].[STLProducts_Materials]  WITH CHECK ADD  CONSTRAINT [FK_STLProducts_Materials_RawMaterials] FOREIGN KEY([RawMaterial_ID])
REFERENCES [dbo].[RawMaterials] ([RawMaterial_ID])
GO
ALTER TABLE [dbo].[STLProducts_Materials] CHECK CONSTRAINT [FK_STLProducts_Materials_RawMaterials]
GO
ALTER TABLE [dbo].[STLProducts_Materials]  WITH CHECK ADD  CONSTRAINT [FK_STLProducts_Materials_STLProduct] FOREIGN KEY([STLProduct_ID])
REFERENCES [dbo].[STLProduct] ([STLProduct_ID])
GO
ALTER TABLE [dbo].[STLProducts_Materials] CHECK CONSTRAINT [FK_STLProducts_Materials_STLProduct]
GO
ALTER TABLE [dbo].[TechnicalEnquiry]  WITH CHECK ADD  CONSTRAINT [fk_TechnicalEnquiry_Customer1] FOREIGN KEY([Customer_customer_ID])
REFERENCES [dbo].[Customer] ([customer_ID])
GO
ALTER TABLE [dbo].[TechnicalEnquiry] CHECK CONSTRAINT [fk_TechnicalEnquiry_Customer1]
GO
ALTER TABLE [dbo].[WorkOrder]  WITH CHECK ADD  CONSTRAINT [fk_WorkOrder_Customer1] FOREIGN KEY([Customer_customer_ID])
REFERENCES [dbo].[Customer] ([customer_ID])
GO
ALTER TABLE [dbo].[WorkOrder] CHECK CONSTRAINT [fk_WorkOrder_Customer1]
GO
ALTER TABLE [dbo].[WorkOrder_has_STL_LineItem]  WITH CHECK ADD  CONSTRAINT [fk_WorkOrder_has_STL_LineItem_STL_LineItem1] FOREIGN KEY([STL_LineItem_STLLineItem_ID])
REFERENCES [dbo].[STL_LineItem] ([STLLineItem_ID])
GO
ALTER TABLE [dbo].[WorkOrder_has_STL_LineItem] CHECK CONSTRAINT [fk_WorkOrder_has_STL_LineItem_STL_LineItem1]
GO
ALTER TABLE [dbo].[WorkOrder_has_STL_LineItem]  WITH CHECK ADD  CONSTRAINT [fk_WorkOrder_has_STL_LineItem_WorkOrder1] FOREIGN KEY([WorkOrder_WorkOrder_ID])
REFERENCES [dbo].[WorkOrder] ([WorkOrder_ID])
GO
ALTER TABLE [dbo].[WorkOrder_has_STL_LineItem] CHECK CONSTRAINT [fk_WorkOrder_has_STL_LineItem_WorkOrder1]
GO
ALTER TABLE [dbo].[WorkOrder_has_STLProduct]  WITH CHECK ADD  CONSTRAINT [fk_WorkOrder_has_STLProduct_STLProduct1] FOREIGN KEY([STLProduct_STLProduct_ID])
REFERENCES [dbo].[STLProduct] ([STLProduct_ID])
GO
ALTER TABLE [dbo].[WorkOrder_has_STLProduct] CHECK CONSTRAINT [fk_WorkOrder_has_STLProduct_STLProduct1]
GO
ALTER TABLE [dbo].[WorkOrder_has_STLProduct]  WITH CHECK ADD  CONSTRAINT [fk_WorkOrder_has_STLProduct_WorkOrder1] FOREIGN KEY([WorkOrder_WorkOrder_ID])
REFERENCES [dbo].[WorkOrder] ([WorkOrder_ID])
GO
ALTER TABLE [dbo].[WorkOrder_has_STLProduct] CHECK CONSTRAINT [fk_WorkOrder_has_STLProduct_WorkOrder1]
GO
USE [master]
GO
ALTER DATABASE [stldb1] SET  READ_WRITE 
GO
