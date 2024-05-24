# Используйте официальный образ.NET Core SDK для сборки проекта
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /

# Копируем файлы проекта в рабочую директорию
COPY ./Domain.csproj .
RUN dotnet restore

# Копируем все остальные файлы проекта
COPY ./. /app

# Собираем проект
RUN dotnet publish -c Release -o out

# Используем официальный образ.NET Core runtime для запуска приложения
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /app
COPY --from=build-env /app ./out
ENTRYPOINT ["dotnet", "out/Domain.dll"]
