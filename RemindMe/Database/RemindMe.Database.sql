USE [RemindMe]
GO
/****** Object:  Table [dbo].[Reminder]    Script Date: 4/5/2022 10:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reminder](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[ReminderDate] [datetime] NOT NULL,
	[Recurring] [bit] NOT NULL,
	[RecurringType] [int] NOT NULL,
	[Note] [nvarchar](255) NULL,
 CONSTRAINT [PK_Reminder] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Reminder_Delete]    Script Date: 4/5/2022 10:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Reminder_Delete]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Delete Statement
    Delete From [Reminder]

    -- Delete Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Reminder_FetchAll]    Script Date: 4/5/2022 10:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Reminder_FetchAll]

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[Note],[Recurring],[RecurringType],[ReminderDate]

    -- From tableName
    From [Reminder]

END

-- Thank you for using DataTier.Net.

GO
/****** Object:  StoredProcedure [dbo].[Reminder_FetchAllForReminderDate]    Script Date: 4/5/2022 10:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Reminder_FetchAllForReminderDate]

    -- Create @ReminderDate Paramater
    @ReminderDate datetime

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[Note],[Recurring],[RecurringType],[ReminderDate]

    -- From tableName
    From [Reminder]

    -- Load Matching Records
    Where [ReminderDate] Between @ReminderDate And (DATEADD(s, 86399, @ReminderDate))

END
GO
/****** Object:  StoredProcedure [dbo].[Reminder_Find]    Script Date: 4/5/2022 10:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Reminder_Find]

    -- Primary Key Paramater
    @Id int

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Select Statement
    Select [Id],[Name],[Note],[Recurring],[RecurringType],[ReminderDate]

    -- From tableName
    From [Reminder]

    -- Find Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Reminder_Insert]    Script Date: 4/5/2022 10:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Reminder_Insert]

    -- Add the parameters for the stored procedure here
    @Name nvarchar(50),
    @Note nvarchar(255),
    @Recurring bit,
    @RecurringType int,
    @ReminderDate datetime

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Insert Statement
    Insert Into [Reminder]
    ([Name],[Note],[Recurring],[RecurringType],[ReminderDate])

    -- Begin Values List
    Values(@Name, @Note, @Recurring, @RecurringType, @ReminderDate)

    -- Return ID of new record
    SELECT SCOPE_IDENTITY()

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
/****** Object:  StoredProcedure [dbo].[Reminder_Update]    Script Date: 4/5/2022 10:15:28 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[Reminder_Update]

    -- Add the parameters for the stored procedure here
    @Id int,
    @Name nvarchar(50),
    @Note nvarchar(255),
    @Recurring bit,
    @RecurringType int,
    @ReminderDate datetime

AS
BEGIN

    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON

    -- Begin Update Statement
    Update [Reminder]

    -- Update Each field
    Set [Name] = @Name,
    [Note] = @Note,
    [Recurring] = @Recurring,
    [RecurringType] = @RecurringType,
    [ReminderDate] = @ReminderDate

    -- Update Matching Record
    Where [Id] = @Id

END

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
GO
