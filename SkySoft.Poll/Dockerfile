FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["SkySoft.Poll/SkySoft.Poll.csproj", "SkySoft.Poll/"]
RUN dotnet restore "SkySoft.Poll/SkySoft.Poll.csproj"
COPY . .
WORKDIR "/src/SkySoft.Poll"
RUN dotnet build "SkySoft.Poll.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "SkySoft.Poll.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "SkySoft.Poll.dll"]
