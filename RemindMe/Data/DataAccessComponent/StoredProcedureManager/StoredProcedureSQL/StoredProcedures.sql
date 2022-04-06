Use [RemindMe]

set ANSI_NULLS ON
set QUOTED_IDENTIFIER ON
Go
-- =========================================================
-- Procure Name: Reminder_Insert
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   4/5/2022
-- Description:    Insert a new Reminder
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Reminder_Insert'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Reminder_Insert

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Reminder_Insert') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Reminder_Insert >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Reminder_Insert >>>'

    End

GO

Create PROCEDURE Reminder_Insert

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
Go
-- =========================================================
-- Procure Name: Reminder_Update
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   4/5/2022
-- Description:    Update an existing Reminder
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Reminder_Update'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Reminder_Update

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Reminder_Update') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Reminder_Update >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Reminder_Update >>>'

    End

GO

Create PROCEDURE Reminder_Update

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
Go
-- =========================================================
-- Procure Name: Reminder_Find
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   4/5/2022
-- Description:    Find an existing Reminder
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Reminder_Find'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Reminder_Find

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Reminder_Find') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Reminder_Find >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Reminder_Find >>>'

    End

GO

Create PROCEDURE Reminder_Find

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
Go
-- =========================================================
-- Procure Name: Reminder_Delete
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   4/5/2022
-- Description:    Delete an existing Reminder
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Reminder_Delete'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Reminder_Delete

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Reminder_Delete') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Reminder_Delete >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Reminder_Delete >>>'

    End

GO

Create PROCEDURE Reminder_Delete

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
Go
-- =========================================================
-- Procure Name: Reminder_FetchAll
-- Author:           Data Juggler - Data Tier.Net Procedure Generator
-- Create Date:   4/5/2022
-- Description:    Returns all Reminder objects
-- =========================================================

-- Check if the procedure already exists
IF EXISTS (select * from syscomments where id = object_id ('Reminder_FetchAll'))

    -- Procedure Does Exist, Drop First
    BEGIN

        -- Execute Drop
        Drop Procedure Reminder_FetchAll

        -- Test if procedure was dropped
        IF OBJECT_ID('dbo.Reminder_FetchAll') IS NOT NULL

            -- Print Line Drop Failed
            PRINT '<<< Drop Failed On Procedure Reminder_FetchAll >>>'

        Else

            -- Print Line Procedure Dropped
            PRINT '<<< Drop Suceeded On Procedure Reminder_FetchAll >>>'

    End

GO

Create PROCEDURE Reminder_FetchAll

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

