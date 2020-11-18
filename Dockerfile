FROM microsoft/dotnet:2.2-aspnetcore-runtime AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443
EXPOSE 1433

FROM microsoft/dotnet:2.2-sdk AS build
WORKDIR /src
COPY ["testwebapp/ValkyraECommerce.csproj", "testwebapp/"]
RUN dotnet restore "testwebapp/ValkyraECommerce.csproj"
COPY . .
WORKDIR "/src/testwebapp"
RUN dotnet build "ValkyraECommerce.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "ValkyraECommerce.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "ValkyraECommerce.dll"]