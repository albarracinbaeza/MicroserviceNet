FROM mcr.microsoft.com/dotnet/core/sdk:3.1

WORKDIR /api
COPY . .

RUN dotnet restore

RUN dotnet publish -o /publish

WORKDIR /publish

ENTRYPOINT ["dotnet","/publish/Microservice.Docker.Api.dll","--urls", "http://+:80;https://+:443"]