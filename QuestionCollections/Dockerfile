# Use the ASP.NET runtime as a base image for the final image
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

# Use the SDK image to build the application
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
# Copy the .csproj file and restore dependencies
COPY ["QuestionCollections.csproj", "./"]
RUN dotnet restore "./QuestionCollections.csproj"
# Copy the rest of the application code
COPY . .
WORKDIR "/src/."
# Build the application
RUN dotnet build "QuestionCollections.csproj" -c Release -o /app/build

# Publish the application
FROM build AS publish
RUN dotnet publish "QuestionCollections.csproj" -c Release -o /app/publish

# Create the final image from the published output
FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "YourAppName.dll"]
