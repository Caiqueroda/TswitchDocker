FROM mcr.microsoft.com/dotnet/nightly/sdk:8.0 AS build-env
WORKDIR /app

COPY *.csproj ./
RUN dotnet restore


COPY . ./
RUN dotnet publish -c Release -o /app/publish

FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
EXPOSE 80
COPY --from=build-env /app/publish .
ENTRYPOINT ["dotnet", "DockerSampleAPI.dll"]