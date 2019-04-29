# Base Application Template

This is a basic application template used as a base for future developments projects. This also demonstrates how data flows through the system from end to end.

This applications is a .NET Core MVC Application. The backend database is using SQL Server with a code first approach. This means database migrations scripts are included alongside the Database Models and will need to be updated for any data models changes. 

## Requirements

* .NET Core 2.1
* NuGet
* SQL Server 2008 or newer

## Installing Database from CMD

Check that the database connection string is correct for you environment. This is lcoated in the appsetings.json file.

Open the Web Application project root folder and run the below command.

``` cmd
dotnet ef database update
```

To add a new migration after model changes open the Database Models project root folder and run the following command.

``` cmd
dotnet ef migrations add NewMigrationName
```

## Installing Database from Visual Studio

Check that the database connection string is correct for you environment. This is lcoated in the appsetings.json file.

Open the Package Manager console and set the default project to Web Application then run the following command.

``` cmd
Update-Database
```

To add a new migration after model changes open the Package Manager Console and set the default project to Database Models the run the following command.

``` cmd
Add-Migration NewMigrationName
```

## Running from CMD

To build and run the application run the following command from the Web Application project root folder.

``` cmd
dotnet run
```

If you get an error in the browser about certificates not being trusted run the command below then close and reopen the browser and they will work as expected.

``` cmd
dotnet dev-certs https --trust
```

Debugging can be done differently depending on the IDE being used. I have included a deubg configuration for Visual Studio Code. This should allow you to click the play button and begin debugging the application like in full Visual Studio.

## Running from Visual Studio

Open the solution file and click the debug button as normal with .NET applications. This will build, run, and being debugging the application. 

## Resources

This is a short list of links I used to help me get started writing this application with .NET Core.

* [.NET Core Commands](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x)
* [EF Core Commands](https://docs.microsoft.com/en-us/ef/core/miscellaneous/cli/dotnet)