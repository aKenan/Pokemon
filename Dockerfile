#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src

# copy all the layers' csproj files into respective folders
COPY ["./Adecco.Pokemon.BuildingBlocks/Adecco.Pokemon.BuildingBlocks.csproj", "src/Adecco.Pokemon.BuildingBlocks/"]
COPY ["./Adecco.Pokemon/Adecco.Pokemon.csproj", "src/Adecco.Pokemon/"]

# run restore over API project - this pulls restore over the dependent projects as well
RUN dotnet restore "src/Adecco.Pokemon/Adecco.Pokemon.csproj"

COPY . .

# run build over the API project
WORKDIR "/src/Adecco.Pokemon/"
RUN dotnet build -c Release -o /app/build

# run publish over the API project
FROM build AS publish
RUN dotnet publish -c Release -o /app/publish

FROM base AS runtime
WORKDIR /app

COPY --from=publish /app/publish .
RUN ls -l
ENTRYPOINT [ "dotnet", "Adecco.Pokemon.dll" ]