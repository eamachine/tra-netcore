FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY tra-core-1.csproj tra-core-1/
RUN dotnet restore tra-core-1/tra-core-1.csproj
WORKDIR /src/tra-core-1
COPY . .
RUN dotnet build tra-core-1.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish tra-core-1.csproj -c Release -o /app

FROM base AS final
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "tra-core-1.dll"]