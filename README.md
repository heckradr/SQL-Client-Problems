# SQL-Client-Problems

## Description
In my demo project there are 2 solutions. A "Core" solution (with a DLL project) which included EF-Core as NuGet package. So it will get a reference to Microsoft.Data.SqlClient as a transitive package. There is also a test project in the same solution named "TestWithinSolution". This is a winforms project which is referencing only the core project. This is working as expected, the EF core query is running.

In the second solution called "App" there is another winforms project which is an exact copy of the first winforms project. Only the reference to the core project was changed so it will point directly to the bin/Debug output of the core solution. Here it will throw an exception when trying to execute the code: Microsoft.Data.SqlClient is not supported on this platform

The problem disappears if you include the NuGet package Microsoft.Data.SqlClient directly in the WinForms project. But I think it should work without this package as well. Since such a core project can be used in various apps, I don't want to have to add all the NuGet packages of the core project to each app.

After the build of the second winforms project all needed files are properly in the bin/Debug output directory. I tried it also with .NET8 and .NET9 but this makes no difference. 

Note: The Northwind database used for the test is not necessary. You can see the exception even without a working sql database.

## Problem
Exception Microsoft.Data.SqlClient is not supported on this platform is thrown

## Steps to reproduce
- checkout project
- open the core solution and compile it (debug build)
- start the WinForms project within the core solution -> Test function will work
- open the app solution and compile it
- start the second WinForms project -> Test function will throw the exception
  

![image](https://github.com/user-attachments/assets/3431d5db-8c86-4969-a15f-c17e784b3284)
