# eticket_app
IDE: Microsoft Visual Studio 2022
Database: Microsoft SQL Server 2022 Developer is a full-featured free edition, licensed for use as a development and test database in a non-production environment.
Framework: Asp.Net 5
Additional packages:
EntityFrameWorkCore 5.0.6
EntityFrameWorkCore SqlServer 5.0.6
EntityFrameWorkCore Tools 5.0.6
Identity.EntityFrameWorkCore 5.0.6
# How to run:
1)Make connection to Database
Server name: .
Password: Windows Authentication
2)Make Migration(Packet Manager Console)
Add-Migration Name
3)Update Database(Packet Manager Console)
Update-Database
# Init
In the first Launch, the appDbInitializer will add the initial Data to database.
After the first launch you can disable appDbInitializer.Seed() and SeedUsersAndRolesAsync() methods in Startup.cs file
