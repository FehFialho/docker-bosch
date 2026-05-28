FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /app

ENV ASPNETCORE_URLS=http://+:8080

COPY ./httyd/*.csproj /app
RUN dotnet restore
COPY ./httyd /app

CMD ["dotnet", "run"]

EXPOSE 8080