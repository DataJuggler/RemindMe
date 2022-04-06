In SQL Server Management Studio, Create a new database named RemindMe

Open RemindMe.Database.sql and execute the script to create the Reminder table and the stored procedures.

Next, Set your connection string.

Here is an example:

Data Source=[Server Name];Initial Catalog=RemindMe;Integrated Security=True

In Windows 10 Search, Start Typing "Edit The System Environment Variables".
Before you get to System, you should be shown "Edit The System Environment Variables".

Click Environment Variables.

At the bottom, add a new entry named RemindMeConnString.

Paste in your connection string as the value and hit OK.

You are now ready to run Remind Me.

Tip: If you would like to create projects like this, DataTier.Net was used to create the stored procedures
and data tier. DataTier.Net comes with a Connection String Builder app, that you will probably think is
worth the price.

https://github.com/DataJuggler/DataTier.Net

Run Remind Me and create some reminders. Each time you start the app, it checks if there are any reminders 
for that day.



