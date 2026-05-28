FROM mcr.microsoft.com/dotnet/sdk:9.0

WORKDIR /app

ENV HTTP_PROXY="host.docker.internal:3128"
ENV HTTPS_PROXY="host.docker.internal:3128"

COPY ./api/*.csproj /app
RUN dotnet restore
COPY ./api /app

CMD ["dotnet", "run", "--urls=http://0.0.0.0:8080"]

EXPOSE 5162