#See https://aka.ms/customizecontainer to learn how to customize your debug container and how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:7.0-alpine AS base
WORKDIR /app
EXPOSE 80

FROM mcr.microsoft.com/dotnet/sdk:7.0-alpine AS build
WORKDIR /src
COPY ["fine-kube-operator-csharp-example.csproj", "."]
RUN dotnet restore "./fine-kube-operator-csharp-example.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "fine-kube-operator-csharp-example.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "fine-kube-operator-csharp-example.csproj" -c Release -o /app/publish /p:UseAppHost=false

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Example.dll"]