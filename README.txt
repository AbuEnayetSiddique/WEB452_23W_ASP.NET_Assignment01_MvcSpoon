
#Assignment 01 
Author name : Abu Enayet Siddique 
Program name : MvcSpoon 
Program purpose : Create an MVC ASP.NET application using .NET core 3.1 
Date created : 2023-02-16 1246EST

# My product is Spoon
Company Name: The Silver Spoon

# Created the project
Cheked the project and it worked perfectly. 
Created new Github Repository and push the project.
Added a README file in the Github with bacis informations of the project.
Added another README file in the project to document all the steps and actions taken to complete the project.

0137EST
Tried to commit the README file to github but got issue.
It was asking to Pull and then Push but did not working.
Tried to find solution on Google. Got some in Stackoverflow.
Merges local and Master branch together. 

0330EST
Added Spoones Controller.
Updated the footer with the dinamic Date-Time.

0415EST
Created HelloWorld folder and inside that added Index.cshtml

0424-EST
Added About Us button in the Navigatin Bar.
then makes it functional by creating About.cshtml item and added one method in home controller.

0504-EST
Created model class named Spoon.cs and added properties.

To add NuGet packages, in PowerShall I ran 'Install-Package Microsoft.EntityFrameworkCore.SqlServer' 
command and got some nfromation, says that it is not compatible with netcoreapp3.1
I remember, it is already install with the 3.1 frmawork.

0751-EST
Created database context class named MvcSpoonContext.cs and modified the class and method.

Updated Startup.ConfigureServices and added database a connection string to the appsettings.json file.

0832-EST
I understand I made mistake that I made Spoons Controller by myself but it will generate automatically when we will do the Scaffolding.
I deleted the Spoons Controller and Scaffold.

Scaffolding done.

For Initial migration- I Used following command lile
		Add-Migration InitialCreate -Context MvcSpoonContext
		Update-Database -Context MvcSpoonContext
the EF Core Migrations feature to created and updated the database.


2023-02-17
0859-EST
Checked the Database-localDB: Id is the primary key and there is no Data.

Created SeedData class and populated with 10 fields.
Checked the application and data was correctly added.

1253-EST
Added some css style
Added some comment