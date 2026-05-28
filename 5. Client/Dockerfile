FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /app

COPY ./ClientJoy/*.csproj /app
RUN dotnet restore
COPY ./ClientJoy /app

CMD ["dotnet", "run", "--urls=http://0.0.0.0:8080"]

EXPOSE 8080