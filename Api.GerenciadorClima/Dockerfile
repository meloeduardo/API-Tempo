#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["Api.GerenciadorClima/Api.GerenciadorClima.csproj", "Api.GerenciadorClima/"]
RUN dotnet restore "Api.GerenciadorClima/Api.GerenciadorClima.csproj"
COPY . .
WORKDIR "/src/Api.GerenciadorClima"
RUN dotnet build "Api.GerenciadorClima.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Api.GerenciadorClima.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Api.GerenciadorClima.dll"]