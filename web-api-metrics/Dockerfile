FROM mcr.microsoft.com/dotnet/core/sdk:3.1 AS build-env

WORKDIR /app

# Copy everything else and build
COPY . ./
RUN dotnet publish web-api-metrics.sln -c Release -o /out
#COPY Repository.EF/Migrations/Scripts/. /out

# Copy everything else and build
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1 AS final
WORKDIR /app
COPY --from=build-env /out .
EXPOSE 80

ENTRYPOINT ["dotnet", "web-api-metrics.dll"]
