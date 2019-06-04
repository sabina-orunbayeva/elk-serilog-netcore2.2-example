FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ElkExampleApi.WebApi/ElkExampleApi.WebApi.csproj ElkExampleApi.WebApi/
RUN dotnet restore ElkExampleApi.WebApi/ElkExampleApi.WebApi.csproj
COPY . .
WORKDIR /src/ElkExampleApi.WebApi
RUN dotnet build ElkExampleApi.WebApi.csproj -c Release -o /app

FROM build AS publish
RUN dotnet publish ElkExampleApi.WebApi.csproj -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ElkExampleApi.WebApi.dll"]
