# Используйте официальный образ.NET Core SDK для сборки проекта
FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build-env
WORKDIR /

# Копируем файлы проекта в рабочую директорию
COPY ./WebUI.csproj .
RUN dotnet restore

# Копируем все остальные файлы проекта
COPY ./. .

# Собираем проект
RUN dotnet publish -c Release -o out

# Используем официальный образ.NET Core runtime для запуска приложения
FROM mcr.microsoft.com/dotnet/aspnet:5.0
WORKDIR /
COPY --from=build-env / ./out
ENTRYPOINT ["dotnet", "out/WebUI.dll"]