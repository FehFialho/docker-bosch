FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /app

COPY /api/*.csproj /app
RUN dotnet restore

COPY /api /app

EXPOSE 9090

CMD ["dotnet", "run"]