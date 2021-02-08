# CognisessTest
Answer to coding test
This is the Solution to the coding test, 
Clone the application into Visua Studio and press Ctrl F5 and it should run on your PC

This is an application form to perform CRUD Operations, at present it can GET and POST all additional functionality are viewable in the BackEnd but not yet wired up to the FrontEnd.

## Summary
The application Intergrated a SQL server database into a ASP.NET Core Web Application using a Entity Framework(EF) Core. The AccountManagementApp2 used No authentication and used the Web-Application (model-View-Controller).

The application has two Model public classes, Account.cs & AccountManagementDbContext(inherited a DbContext from Entity Framework Core) respectively.

Within Visual Studio 2019, in Server Explorer, i Created a New SQL Server Database called it Accountmanagedb.dbo, Selected Modified connection and copied -- @" Data Source =.; Initial Catalog = AccountManagerdb; Integrated Security = True; Pooling = False" -- ConfigureServices in Startup.cs.
CRUD operations were created in the AccountsController


### Implementation Requirements
*Visual Studio 2019
*.NetCore with c#
*Microsoft SQL Server Management Studio
*github
*GitBash

### Nuget Packages to Download in Visual Studio(VS) 2019
*knockout.js (Nuget Package)
*jQuery (Nuget Package)
*jquery.Validation (Nuget Package)
*Microsoft.AspNetCore (Nuget Package)
*Microsoft.AspNetCore.Mvc (Nuget Package)
*Microsoft.EntityFrameworkCore.SqlServer (Nuget Package)
*Micorsoft.Extensions.DependencyInjection (Nuget Package)
*Microsoft.EntityFrameworkCore.Tools (Nuget Package)
*Microsoft.EntityFrameworkCore.InMemory (Nuget Package) 
*JetBrains.Annotations (Nuget Package)

### Questions
How long did you spend writing the application?

I spent 8 hours writing the application.

What part of the application are you most proud of?
My work on the Account Controller, specifically the HTTPGet .

If you had more time what would you improve in the application?

Would finishing with the Frontend work for the rest of the CRUD operations. Use Microsoft Azure services to imrove database accessiblitiy. I would of also at more BackEnd fucntionality for DateOfBirth, use more Javascript like Moment.js to pass correct Daytime to the Backend. Make the app more visually appealing on the FrontEnd.
