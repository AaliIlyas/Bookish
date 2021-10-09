# Bookish #

Welcome to Bookish. This is a basic application to manage a library. In this you can add, remove and modify books and members. You can also checkout books and return them from members.

### Prerequisites
- You will need to have MSSQL installed. You can download it [here](https://www.microsoft.com/en-gb/sql-server/sql-server-downloads?rtc=1).
- You will also need docker installed. You can download this from [here](https://www.docker.com/products/docker-desktop).

### Setup

Open an admin command line and navigate to the project directory.

run:
- `docker-compose up`

Now we can set up the database.

run:
- `dotnet tool install --global dotnet-ef`
- `dotnet ef migrations add LibraryDb`
- `dotnet ef database update`

You can open the solution file in Visual Studio and run it.

### To connect to this database with Sequel Server Management Studio

Use SQL Server Authentication.

Server name: `localhost,1433`
Login: `SA`
Password: `Password123`

---

This is my rudimentary application using the ASP.NET MVC. I really enjoyed building this and I am looking forward to continue improving my skill set in this. Thanks for visiting.

Ilyas
