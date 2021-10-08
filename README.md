# Bookish #

Welcome to Bookish. This is a basic application to manage a library. In this you can add, remove and modify books and members. You can also checkout books and return them.

## Setup

You will need to have MSSQL installed. You can download it [here](https://www.microsoft.com/en-gb/sql-server/sql-server-downloads?rtc=1).

Open an Admin command line.
First run this command in the project directory: `dotnet toool install --global dotnet-ef`.

Then run `dotnet tool install --global dotnet-ef`.

Now run `dotnet ef migrations add BookDbContext`

Finally, run `dotnet ef database update`.

You can open this solution is Visual Studio and run it.

**README work in progress**
