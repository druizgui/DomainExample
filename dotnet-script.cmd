SET PROJECTNAME=AdventureWorks
SET REPOSITORY=https://github.com/<account>/<repo>.git

git clone %REPOSITORY% %PROJECTNAME%
cd %PROJECTNAME%

git init
dotnet new gitignore
git add .
git commit -m "startup project"
git push

git checkout -b dev
git push --set-upstream origin dev

dotnet new sln %PROJECTNAME%



dotnet new classlib -n %PROJECTNAME%.Data -f netcoreapp3.1
dotnet sln add         %PROJECTNAME%.Data

dotnet new classlib -n %PROJECTNAME%.Dom 
dotnet sln add         %PROJECTNAME%.Dom
dotnet new mstest   -n %PROJECTNAME%.Tests
dotnet sln add         %PROJECTNAME%.Tests

:: dotnet add package Microsoft.EntityFrameworkCore.Tools 
:: dotnet add package Microsoft.EntityFrameworkCore.Design
:: dotnet add package Microsoft.EntityFrameworkCore.InMemory
:: dotnet add package Microsoft.EntityFrameworkCore.SqlServer
:: dotnet add package System.ComponentModel.Annotations

:: Code Analysis
:: dotnet add package Microsoft.CodeAnalysis.FxCopAnalyzers
:: dotnet add package SecurityCodeScan
