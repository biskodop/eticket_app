# eticket_app
IDE: Microsoft Visual Studio 2022
Database: Microsoft SQL Server 2022 Developer is a full-featured free edition, licensed for use as a development and test database in a non-production environment.
Framework: Asp.Net 5
Additional packages:
EntityFrameWorkCore
EntityFrameWorkCore SqlServer
EntityFrameWorkCore Tools
Identity.EntityFrameWorkCore
How to run:
1)Make connection to Database
Server name: .
Password: Windows Authentication
2)Make Migration
Add-Migration Name
3)Update Database
Update-Database

In first Launch, the appDbInitializer will add the initial Data to database.
After firs launch you can disable appDbInitializer.Seed() and SeedUsersAndRolesAsync() methods in Startup.cs file
