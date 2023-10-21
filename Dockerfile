## Use the official .NET Core SDK as a parent image
#FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
#WORKDIR /app
#
## Copy the project file and restore any dependencies (use .csproj for the project name)
#COPY BitTagAPI/*.csproj ./
#COPY BitTagDAL/*.csproj ./
#COPY BitTagModels/*.csproj ./
#COPY BitTagUser/*.CSPROJ ./
#COPY BitTagWebAPP/*.CSPROJ ./
#RUN dotnet restore /app/BitTagAPI.csproj
#RUN dotnet restore /app/BitTagDAL.csproj
#RUN dotnet restore /app/BitTagModels.csproj
#
## Copy the rest of the application code
#COPY . .
#
## Publish the application
#RUN dotnet publish -c Debug -o out /app/BitTagAPI.csproj
#
## Build the runtime image
#FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
#WORKDIR /app
#COPY --from=build /app/out ./
#
## Expose the port your application will run on
#EXPOSE 80
#
## Start the application
#ENTRYPOINT ["dotnet", "BitTagAPI.sln"]

# Use the official .NET Core SDK as a parent image
FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /app

# Copy the project files and restore dependencies
COPY BitTagAPI/*.csproj ./BitTagAPI/
COPY BitTagDAL/*.csproj ./BitTagDAL/
COPY BitTagModels/*.csproj ./BitTagModels/
COPY BitTagUser/*.csproj ./BitTagUser/
COPY BitTagWebAPP/*.csproj ./BitTagWebAPP/

# Restore dependencies for each project
RUN dotnet restore ./BitTagAPI/BitTagAPI.csproj
RUN dotnet restore ./BitTagDAL/BitTagDAL.csproj
RUN dotnet restore ./BitTagModels/BitTagModels.csproj
RUN dotnet restore ./BitTagUser/BitTagUser.csproj
RUN dotnet restore ./BitTagWebAPP/BitTagWebAPP.csproj

# Copy the rest of the application code
COPY . .

# Publish the application using the project file
RUN dotnet publish -c Debug -o out ./BitTagAPI/BitTagAPI.csproj
RUN dotnet publish -c Debug -o out ./BitTagUser/BitTagUser.csproj
RUN dotnet publish -c Debug -o out ./BitTagWebAPP/BitTagWebAPP.csproj

# Build the runtime image
FROM mcr.microsoft.com/dotnet/aspnet:7.0 AS runtime
WORKDIR /app
COPY --from=build /app/out ./

# Expose the port your application will run on
EXPOSE 80

# Start the application
ENTRYPOINT ["dotnet", "BitTagAPI.dll"]
