USE [master]
GO
/****** Object:  Database [SMMg]    Script Date: 3/19/2020 4:14:03 AM ******/
CREATE DATABASE [SMMg]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'SMMg', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SMMg.mdf' , SIZE = 58368KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'SMMg_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\SMMg_log.ldf' , SIZE = 32448KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [SMMg] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [SMMg].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [SMMg] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [SMMg] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [SMMg] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [SMMg] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [SMMg] SET ARITHABORT OFF 
GO
ALTER DATABASE [SMMg] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [SMMg] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [SMMg] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [SMMg] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [SMMg] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [SMMg] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [SMMg] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [SMMg] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [SMMg] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [SMMg] SET  DISABLE_BROKER 
GO
ALTER DATABASE [SMMg] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [SMMg] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [SMMg] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [SMMg] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [SMMg] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [SMMg] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [SMMg] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [SMMg] SET RECOVERY FULL 
GO
ALTER DATABASE [SMMg] SET  MULTI_USER 
GO
ALTER DATABASE [SMMg] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [SMMg] SET DB_CHAINING OFF 
GO
ALTER DATABASE [SMMg] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [SMMg] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [SMMg] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'SMMg', N'ON'
GO
USE [SMMg]
GO
/****** Object:  Table [dbo].[BiThu]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BiThu](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ngay] [datetime] NOT NULL,
	[SoPhieu] [int] NULL,
	[KiNhan] [nvarchar](265) NULL,
	[TenNoiNhan] [nvarchar](265) NULL,
	[TongSo] [int] NULL,
	[DanhSachDienMat] [nvarchar](265) NULL,
 CONSTRAINT [PK__BiThu__3213E83FC40D4C6F] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[CoSo]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CoSo](
	[TenCoSo] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_CoSo] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DienMat]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[DienMat](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[LuuFile] [nvarchar](265) NULL,
	[FileDinhKem] [nvarchar](265) NULL,
	[NoiGui] [nvarchar](265) NULL,
	[TrichYeu] [nvarchar](265) NULL,
	[DoMat] [nvarchar](20) NULL,
	[DoMatFile] [nchar](20) NULL,
	[MaDienMat] [int] NULL,
	[Ngay] [datetime2](7) NULL,
	[GhiChu] [nvarchar](265) NULL,
	[Loai] [nvarchar](20) NULL,
	[BanIn] [int] NULL,
	[NgayIn] [datetime2](7) NOT NULL,
	[NguoiDuyet] [nvarchar](256) NULL,
	[NguoiKy] [nvarchar](256) NULL,
	[ChucDanh] [nvarchar](256) NULL,
	[DsNoiNhan] [nvarchar](256) NULL,
	[Trang] [int] NULL,
	[idUsername] [int] NULL,
	[NguoiIn] [varchar](50) NULL,
 CONSTRAINT [PK_DienMat] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[DienMatDaPhanPhoi]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienMatDaPhanPhoi](
	[ID] [int] NOT NULL,
	[LuuFile] [nvarchar](265) NULL,
	[FileDinhKem] [nvarchar](265) NULL,
	[NoiGui] [nvarchar](265) NULL,
	[TrichYeu] [nvarchar](265) NULL,
	[DoMat] [nvarchar](20) NULL,
	[DoMatFile] [nchar](20) NULL,
	[MaDienMat] [int] NULL,
	[Ngay] [datetime] NULL,
	[GhiChu] [nvarchar](265) NULL,
	[Loai] [nvarchar](20) NOT NULL,
	[SoBaoMat] [int] NOT NULL,
	[BanIn] [int] NULL,
	[NgayIn] [datetime] NOT NULL,
	[NguoiDuyet] [nvarchar](256) NULL,
	[NguoiKy] [nvarchar](256) NULL,
	[ChucDanh] [nvarchar](256) NULL,
	[ChuKy] [image] NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DienMatTemp]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DienMatTemp](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaDienMat] [int] NULL,
 CONSTRAINT [PK_DienMatTemp] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[FileDinhKemDienMat]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FileDinhKemDienMat](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[FileDinhKem] [nvarchar](256) NULL,
	[MaDienMat] [int] NULL,
 CONSTRAINT [PK_FileDinhKemDienMat] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[KiemChungDien]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KiemChungDien](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[DanhSachDien] [nvarchar](265) NULL,
	[TongSoTrang] [int] NULL,
	[TenNoiNhan] [nvarchar](265) NULL,
	[SoLuongDien] [int] NULL,
	[NgayIn] [datetime2](7) NULL,
 CONSTRAINT [PK__KiemChun__3213E83FBBC6F6D5] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Loai]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenLoai] [nvarchar](50) NULL,
 CONSTRAINT [PK_Loai] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiDuyet]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiDuyet](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiDuyet] [nvarchar](265) NULL,
	[MacDinh] [bit] NULL,
	[ChuKy] [image] NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiKy]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiKy](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TenNguoiKy] [nvarchar](265) NULL,
	[ChucDanh] [nvarchar](265) NULL,
	[MacDinh] [bit] NULL,
	[ChuKy] [image] NULL,
 CONSTRAINT [PK__NguoiKy__3213E83F121C4865] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Nhom]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nhom](
	[TenNhom] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_Nhom] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NoiGui]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NoiGui](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[Ma] [varchar](265) NULL,
	[Ten] [nvarchar](265) NULL,
 CONSTRAINT [PK__NoiGui__3213E83F1A3C9502] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[NoiNhan]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoiNhan](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[MaNoiNhan] [nvarchar](20) NOT NULL,
	[TenNoiNhan] [nvarchar](265) NOT NULL,
	[Loai] [nvarchar](20) NOT NULL,
	[SoBaoMat] [int] NOT NULL,
	[Nhom] [nvarchar](265) NULL,
	[SoThuTu] [int] NULL,
	[CoBi] [bit] NULL,
	[DangHoatDong] [bit] NULL,
	[CoSo] [nvarchar](50) NULL,
 CONSTRAINT [PK__NoiNhan__3213E83FFDDFBFD0] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NoiNhanTemp]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NoiNhanTemp](
	[id] [int] NOT NULL,
	[MaNoiNhan] [nvarchar](20) NOT NULL,
	[TenNoiNhan] [nvarchar](265) NOT NULL,
	[Loai] [nvarchar](20) NOT NULL,
	[SoBaoMat] [int] NOT NULL,
	[Nhom] [nvarchar](265) NULL,
	[SoThuTu] [int] NULL,
	[CoBi] [bit] NULL,
	[DangHoatDong] [bit] NULL,
	[CoSo] [nvarchar](50) NULL,
 CONSTRAINT [PK__NoiNhanT__3213E83F92EA821E] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PemisionDetail]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[PemisionDetail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[PerDetail] [int] NOT NULL,
	[Per_Action] [varchar](20) NOT NULL,
	[Per] [char](10) NULL,
 CONSTRAINT [PK__Pemision__3213E83F20A95111] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Permision]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permision](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NamePer] [nvarchar](50) NOT NULL,
	[DescriptionPer] [nvarchar](256) NULL,
 CONSTRAINT [PK_Permision] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PhanLoaiNoiNhan]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhanLoaiNoiNhan](
	[PhanLoai] [nvarchar](50) NULL,
	[id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_PhanLoaiNoiNhan] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TrangThai]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TrangThai](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[NameTrangThai] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TuyChinh]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyChinh](
	[id] [int] NOT NULL,
	[VanBanLeTrai] [float] NULL,
	[VanBanLeTren] [float] NULL,
	[DsnLeTrai] [float] NULL,
	[DsnLeTren] [float] NULL,
	[DsnDanDong] [float] NULL,
	[DauChimRong] [float] NULL,
	[DauChimCao] [float] NULL,
	[DauChimFont] [float] NULL,
	[DauChimOpacity] [float] NULL,
	[DauChimMauDoc] [float] NULL,
	[DauChimMauPdf] [float] NULL,
	[VungCkRong] [float] NULL,
	[VungCkCao] [float] NULL,
	[VungCkLeDuoi] [float] NULL,
	[AnhCkRong1] [float] NULL,
	[AnhCkCao1] [float] NULL,
	[AnhCkCao2] [float] NULL,
	[AnhCkRong2] [float] NULL,
	[TieuDe] [nvarchar](256) NULL,
	[In2Mat] [nvarchar](50) NULL,
	[KhayGiay] [nvarchar](50) NULL,
	[Dien] [nvarchar](50) NULL,
	[Fax] [nvarchar](50) NULL,
	[InDauMatLenDien] [bit] NULL,
	[CoSo] [nvarchar](50) NULL,
	[LuuFile] [nvarchar](256) NULL,
 CONSTRAINT [PK_TuyChinh] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TuyChinhCombobox]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TuyChinhCombobox](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[TrangThaiTuyChinh] [nvarchar](50) NULL,
	[GiayIn] [nvarchar](50) NULL,
 CONSTRAINT [PK_TuyChinhInput] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[USER]    Script Date: 3/19/2020 4:14:03 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[USER](
	[NameUser] [nvarchar](250) NOT NULL,
	[Username] [varchar](50) NOT NULL,
	[Password] [varchar](50) NOT NULL,
	[PerUser] [nvarchar](50) NOT NULL,
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TrangThai] [nvarchar](50) NULL,
 CONSTRAINT [PK_USER] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
SET IDENTITY_INSERT [dbo].[CoSo] ON 

INSERT [dbo].[CoSo] ([TenCoSo], [id]) VALUES (N'Cơ sở 1', 1)
INSERT [dbo].[CoSo] ([TenCoSo], [id]) VALUES (N'Cơ sở 2', 2)
SET IDENTITY_INSERT [dbo].[CoSo] OFF
SET IDENTITY_INSERT [dbo].[Loai] ON 

INSERT [dbo].[Loai] ([id], [TenLoai]) VALUES (1, N'Bên ngoài ')
INSERT [dbo].[Loai] ([id], [TenLoai]) VALUES (2, N'Nội bộ')
INSERT [dbo].[Loai] ([id], [TenLoai]) VALUES (3, N'Tất cả')
SET IDENTITY_INSERT [dbo].[Loai] OFF
SET IDENTITY_INSERT [dbo].[Nhom] ON 

INSERT [dbo].[Nhom] ([TenNhom], [id]) VALUES (N'LDB', 1)
INSERT [dbo].[Nhom] ([TenNhom], [id]) VALUES (N'BCT', 2)
INSERT [dbo].[Nhom] ([TenNhom], [id]) VALUES (N'BBT', 3)
SET IDENTITY_INSERT [dbo].[Nhom] OFF
SET IDENTITY_INSERT [dbo].[Permision] ON 

INSERT [dbo].[Permision] ([id], [NamePer], [DescriptionPer]) VALUES (1, N'Quản trị', NULL)
INSERT [dbo].[Permision] ([id], [NamePer], [DescriptionPer]) VALUES (2, N'Nâng cao', NULL)
INSERT [dbo].[Permision] ([id], [NamePer], [DescriptionPer]) VALUES (3, N'Cơ bản', NULL)
SET IDENTITY_INSERT [dbo].[Permision] OFF
SET IDENTITY_INSERT [dbo].[PhanLoaiNoiNhan] ON 

INSERT [dbo].[PhanLoaiNoiNhan] ([PhanLoai], [id]) VALUES (N'Nội bộ', 1)
INSERT [dbo].[PhanLoaiNoiNhan] ([PhanLoai], [id]) VALUES (N'Bên ngoài', 2)
SET IDENTITY_INSERT [dbo].[PhanLoaiNoiNhan] OFF
SET IDENTITY_INSERT [dbo].[TrangThai] ON 

INSERT [dbo].[TrangThai] ([id], [NameTrangThai]) VALUES (1, N'Đang hoạt động')
INSERT [dbo].[TrangThai] ([id], [NameTrangThai]) VALUES (2, N'Không hoạt động')
SET IDENTITY_INSERT [dbo].[TrangThai] OFF
INSERT [dbo].[TuyChinh] ([id], [VanBanLeTrai], [VanBanLeTren], [DsnLeTrai], [DsnLeTren], [DsnDanDong], [DauChimRong], [DauChimCao], [DauChimFont], [DauChimOpacity], [DauChimMauDoc], [DauChimMauPdf], [VungCkRong], [VungCkCao], [VungCkLeDuoi], [AnhCkRong1], [AnhCkCao1], [AnhCkCao2], [AnhCkRong2], [TieuDe], [In2Mat], [KhayGiay], [Dien], [Fax], [InDauMatLenDien], [CoSo], [LuuFile]) VALUES (1, 1, 1, 1, 1, 1, 10.795000076293945, 13.970000267028809, 300, 0.5, 1, -8421505, 5, 24, 2, 3, 1.5, 1, 1, N'Hà Nội', N'1', N'1', N'1', N'1', 1, N'1', N'D:\BACKUP\Desktop')
SET IDENTITY_INSERT [dbo].[TuyChinhCombobox] ON 

INSERT [dbo].[TuyChinhCombobox] ([id], [TrangThaiTuyChinh], [GiayIn]) VALUES (1, N'Tự động', N'Tray1')
INSERT [dbo].[TuyChinhCombobox] ([id], [TrangThaiTuyChinh], [GiayIn]) VALUES (2, N'Không tự động', N'Tray 2')
SET IDENTITY_INSERT [dbo].[TuyChinhCombobox] OFF
SET IDENTITY_INSERT [dbo].[USER] ON 

INSERT [dbo].[USER] ([NameUser], [Username], [Password], [PerUser], [ID], [TrangThai]) VALUES (N'1', N'1', N'1', N'Quản trị', 1, N'Đang hoạt động')
SET IDENTITY_INSERT [dbo].[USER] OFF
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__USER__536C85E466EADC8A]    Script Date: 3/19/2020 4:14:03 AM ******/
ALTER TABLE [dbo].[USER] ADD UNIQUE NONCLUSTERED 
(
	[Username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[DienMat]  WITH CHECK ADD  CONSTRAINT [FK_DienMat_USER1] FOREIGN KEY([idUsername])
REFERENCES [dbo].[USER] ([ID])
GO
ALTER TABLE [dbo].[DienMat] CHECK CONSTRAINT [FK_DienMat_USER1]
GO
USE [master]
GO
ALTER DATABASE [SMMg] SET  READ_WRITE 
GO
