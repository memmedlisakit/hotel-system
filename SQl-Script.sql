USE [HotelDB]
GO
/****** Object:  Table [dbo].[Booking]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Booking](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[booking_code] [int] NOT NULL,
	[check_in_date] [datetime] NOT NULL,
	[check_out_date] [datetime] NOT NULL,
	[adult_count] [int] NOT NULL,
	[child_count] [int] NULL,
	[room_type_id] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[booking_status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employer_Types]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employer_Types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employer_type_name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employers]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employers](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employer_full_name] [nvarchar](100) NOT NULL,
	[employer_info] [nvarchar](500) NULL,
	[employer_start_time] [datetime] NOT NULL,
	[employer_end_time] [datetime] NOT NULL,
	[employer_salary] [float] NOT NULL,
	[employer_type_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expences]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expences](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[expence_type_id] [int] NOT NULL,
	[expence_description] [nvarchar](max) NOT NULL,
	[expence_amount] [float] NOT NULL,
	[payment_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Expences_Types]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Expences_Types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[expences_type_name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Guests]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Guests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[booking_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payment_Types]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payment_Types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[payment_type_name] [nvarchar](150) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Payments]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Payments](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[payment_amount] [float] NOT NULL,
	[guest_id] [int] NOT NULL,
	[payment_type_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Photos]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Photos](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[image_name] [nvarchar](max) NOT NULL,
	[image_src] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room_Details]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_Details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[detail_name] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Room_Types]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Room_Types](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_type_name] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_number] [int] NOT NULL,
	[room_type_id] [int] NOT NULL,
	[bed_count] [int] NOT NULL,
	[room_price] [int] NOT NULL,
	[room_reservation_status] [bit] NOT NULL,
	[room_cleaning_status] [bit] NOT NULL,
	[room_status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms_Details]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms_Details](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NULL,
	[detail_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms_Guests]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms_Guests](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NOT NULL,
	[guest_id] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Rooms_Photos]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Rooms_Photos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[room_id] [int] NULL,
	[photo_id] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tasks]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tasks](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[employer_id] [int] NOT NULL,
	[task_description] [nvarchar](max) NOT NULL,
	[task_start_time] [datetime] NOT NULL,
	[task_end_time] [datetime] NOT NULL,
	[task_status] [bit] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Users]    Script Date: 12-Jan-18 6:34:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_full_name] [nvarchar](150) NOT NULL,
	[user_email] [nvarchar](100) NOT NULL,
	[user_phone] [nvarchar](100) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [booking_to_room_type] FOREIGN KEY([room_type_id])
REFERENCES [dbo].[Room_Types] ([id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [booking_to_room_type]
GO
ALTER TABLE [dbo].[Booking]  WITH CHECK ADD  CONSTRAINT [booking_to_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Booking] CHECK CONSTRAINT [booking_to_user]
GO
ALTER TABLE [dbo].[Employers]  WITH CHECK ADD  CONSTRAINT [Employers_to_type] FOREIGN KEY([employer_type_id])
REFERENCES [dbo].[Employer_Types] ([id])
GO
ALTER TABLE [dbo].[Employers] CHECK CONSTRAINT [Employers_to_type]
GO
ALTER TABLE [dbo].[Expences]  WITH CHECK ADD  CONSTRAINT [Expences_to_payment] FOREIGN KEY([payment_id])
REFERENCES [dbo].[Payments] ([id])
GO
ALTER TABLE [dbo].[Expences] CHECK CONSTRAINT [Expences_to_payment]
GO
ALTER TABLE [dbo].[Expences]  WITH CHECK ADD  CONSTRAINT [Expences_to_type] FOREIGN KEY([expence_type_id])
REFERENCES [dbo].[Expences_Types] ([id])
GO
ALTER TABLE [dbo].[Expences] CHECK CONSTRAINT [Expences_to_type]
GO
ALTER TABLE [dbo].[Guests]  WITH CHECK ADD  CONSTRAINT [Guest_to_booking] FOREIGN KEY([booking_id])
REFERENCES [dbo].[Booking] ([id])
GO
ALTER TABLE [dbo].[Guests] CHECK CONSTRAINT [Guest_to_booking]
GO
ALTER TABLE [dbo].[Guests]  WITH CHECK ADD  CONSTRAINT [Guest_to_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[Users] ([id])
GO
ALTER TABLE [dbo].[Guests] CHECK CONSTRAINT [Guest_to_user]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [Payment_to_guest] FOREIGN KEY([guest_id])
REFERENCES [dbo].[Guests] ([id])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [Payment_to_guest]
GO
ALTER TABLE [dbo].[Payments]  WITH CHECK ADD  CONSTRAINT [Payments_to_types] FOREIGN KEY([payment_type_id])
REFERENCES [dbo].[Payment_Types] ([id])
GO
ALTER TABLE [dbo].[Payments] CHECK CONSTRAINT [Payments_to_types]
GO
ALTER TABLE [dbo].[Rooms]  WITH CHECK ADD  CONSTRAINT [room_to_type] FOREIGN KEY([room_type_id])
REFERENCES [dbo].[Room_Types] ([id])
GO
ALTER TABLE [dbo].[Rooms] CHECK CONSTRAINT [room_to_type]
GO
ALTER TABLE [dbo].[Rooms_Details]  WITH CHECK ADD  CONSTRAINT [to_detail] FOREIGN KEY([detail_id])
REFERENCES [dbo].[Room_Details] ([id])
GO
ALTER TABLE [dbo].[Rooms_Details] CHECK CONSTRAINT [to_detail]
GO
ALTER TABLE [dbo].[Rooms_Details]  WITH CHECK ADD  CONSTRAINT [to_room] FOREIGN KEY([room_id])
REFERENCES [dbo].[Rooms] ([id])
GO
ALTER TABLE [dbo].[Rooms_Details] CHECK CONSTRAINT [to_room]
GO
ALTER TABLE [dbo].[Rooms_Guests]  WITH CHECK ADD  CONSTRAINT [Guest_to_guest] FOREIGN KEY([guest_id])
REFERENCES [dbo].[Guests] ([id])
GO
ALTER TABLE [dbo].[Rooms_Guests] CHECK CONSTRAINT [Guest_to_guest]
GO
ALTER TABLE [dbo].[Rooms_Guests]  WITH CHECK ADD  CONSTRAINT [Room_to_guest] FOREIGN KEY([room_id])
REFERENCES [dbo].[Rooms] ([id])
GO
ALTER TABLE [dbo].[Rooms_Guests] CHECK CONSTRAINT [Room_to_guest]
GO
ALTER TABLE [dbo].[Rooms_Photos]  WITH CHECK ADD  CONSTRAINT [to_photo] FOREIGN KEY([photo_id])
REFERENCES [dbo].[Photos] ([id])
GO
ALTER TABLE [dbo].[Rooms_Photos] CHECK CONSTRAINT [to_photo]
GO
ALTER TABLE [dbo].[Rooms_Photos]  WITH CHECK ADD  CONSTRAINT [to_room_01] FOREIGN KEY([room_id])
REFERENCES [dbo].[Rooms] ([id])
GO
ALTER TABLE [dbo].[Rooms_Photos] CHECK CONSTRAINT [to_room_01]
GO
ALTER TABLE [dbo].[Tasks]  WITH CHECK ADD  CONSTRAINT [Task_to_employer] FOREIGN KEY([employer_id])
REFERENCES [dbo].[Employers] ([id])
GO
ALTER TABLE [dbo].[Tasks] CHECK CONSTRAINT [Task_to_employer]
GO
