


# Создание решений
dotnet new sln -n Project

# Создание Code
mkdir Code
cd Code
dotnet new winforms
cd ..

dotnet sln add Code/Code.csproj


В папке Code находится проект посвященный самому приложению


# Создание другой сборки
## Если находимся не в Code
dotnet new classlib -n MyDataBase
dotnet sln add MyDataBase/MyDataBase.csproj

cd Code
dotnet add reference ../MyDataBase/MyDataBase.csproj

cd ..
cd MyDataBase
dotnet add package MySql.Data
dotnet add package Autofac

