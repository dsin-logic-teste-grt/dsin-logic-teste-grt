FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build
WORKDIR /app
COPY src/DsinLogicTesteGrt/*.csproj ./
RUN dotnet restore
COPY src/DsinLogicTesteGrt/ ./
RUN dotnet publish -c Release -o /out

FROM mcr.microsoft.com/dotnet/runtime:8.0
WORKDIR /app
COPY --from=build /out .
ENTRYPOINT ["dotnet", "DsinLogicTesteGrt.dll"]
