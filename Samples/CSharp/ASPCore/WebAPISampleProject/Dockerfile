FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["../../Samples/CSharp/ASPCore/WebAPISampleProject/WebAPISampleProject.csproj", "WebAPISampleProject/"]
RUN dotnet restore "../../Samples/CSharp/ASPCore/WebAPISampleProject/WebAPISampleProject.csproj"
COPY . .
WORKDIR "/src/WebAPISampleProject"
RUN dotnet build "WebAPISampleProject.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WebAPISampleProject.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WebAPISampleProject.dll"]
