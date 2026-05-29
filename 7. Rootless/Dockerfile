FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build

WORKDIR /app

COPY ./Client/*.csproj ./
RUN dotnet restore
COPY ./Client ./

CMD ["dotnet", "run", "--urls=http://0.0.0.0:8080"]

RUN dotnet publish -c Release -o /app/publish

# Second Layer
FROM mcr.microsoft.com/dotnet/aspnet:9.0

# RootLess
RUN addgroup -S testers
RUN adduser -S beta_cristian -G testers>
#

WORKDIR /app

ENV HTTP_PROXY: http://host.docker.internal:3128
ENV HTTPS_PROXY: http://host.docker.internal:3128

COPY --from=build /app/publish .
USER beta_cristian

ENTRYPOINT ["dotnet", "Client.dll"]