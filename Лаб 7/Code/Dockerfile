



# Этап сборки
FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
WORKDIR /src

# Копируем csproj и восстанавливаем зависимости
COPY *.csproj .
RUN dotnet restore

# Копируем всё остальное и билдим
COPY . .
RUN dotnet publish -c Release -o /Code/publish

# Этап запуска
FROM mcr.microsoft.com/dotnet/aspnet:9.0
WORKDIR /Code
COPY --from=build /Code/publish .

# если нужен именно путь /Code/Program/wwwroot
# можно сделать так:
COPY ./Program/wwwroot /Code/Program/wwwroot


ENTRYPOINT ["dotnet", "Code.dll"]