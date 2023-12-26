# VPCT API Project

This project is an ASP.NET Core API for the VPCT system.

## Requirements

- Visual Studio 2019 or later
- .NET Core SDK
- SQL Server (local or remote)

## Setup

1. Open the solution in Visual Studio.
2. Change the ConnectionString in the file `VPCTDbContext.cs` in the `VPCT.Core` project to point to your local SQL Server instance.
3. Change the ConnectionString in the file `appsettings.json` in the `VPCTWebsiteAPI` project to point to your local SQL Server instance.
4. Open the Package Manager Console in Visual Studio, with the default project set to `VPCT.Core`.
5. Run the following command to apply the database migrations:
   ```
   Update-Database
   ```

## Running the API

Once the setup is complete, you can run the API project in Visual Studio. The API will be hosted at the specified endpoint, and you can start making requests to it.

That's it! You should now have the VPCT API project set up and running locally.
