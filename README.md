# PC-Configuration-Tool
PC Configuration Tool is an app for selecting PC components from a 'Store'. It's able to calculate the total sum of the selected items.

Setup Steps:

1. Install ".Net 5" or later version.
2. Open the solution with Visual Studio.
3. Navigate to Project: "PCConfiguration.Web" and open it's appsettings.json
4. In ConnectionStrings section - replace "(my-server-name)" with the name of your server
5. Right-Click on the Solution -> Restore NuGet packages for the solution.

For Creating the Databse
1. In Visual Studio - navigate to -> Tools -> NuGet Package Manager -> Package Manager Console
2. In Package Manager Console - For "Default project" property choose "PCConfigurationTool.DataModel" project
3. In Package Manager Console - Type - Add-Migration InitialMigration
	3.3 If you get this error: "Exception has been thrown by the target of an invocation." - Make sure your Starup Project for the solution is - "PCConfiguration.Web" (the Web one) and then run the command above again. 
4. In Package Manager Console - Type - Update-Database

It should create DB for you populated with some test data.
Now you should be able to use the app.
