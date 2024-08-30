# NetBoilerPlate

## Overview
This ASP.NET Core Boilerplate provides a ready-to-use foundation for building web applications with best practices and industry standards. It's designed to give developers a clean and modular starting point, featuring dependency injection, logging, API versioning, and error handling integrated out of the box.

## Features
- **Dependency Injection Setup**: Configured to use built-in DI for managing services and repositories.
- **Error Handling**: Global error handling middleware for streamlined error management. (TODO)
- **Logging**: Integrated logging with Serilog (or another logging framework). (TODO)
- **API Documentation**: Swagger setup for API documentation and testing. 


## Prerequisites
- [.NET 8.0 SDK](https://dotnet.microsoft.com/download/dotnet/8.0) or higher
- Any compatible IDE (Visual Studio 2022, VS Code, JetBrains Rider)



## Getting Started
To get started with this boilerplate, clone the repository and install the necessary dependencies.



## Contributing

Contributions are what make the open-source community such an amazing place to learn, inspire, and create. Any contributions you make are greatly appreciated.



Structure
```
└── 📁src
    └── 📁Core
        └── 📁Entities
            └── Customer.cs
        └── 📁Interfaces
            └── ICustomerRepository.cs
            └── ICustomerService.cs
            └── IDBConnectionFactory.cs
            └── IEmailService.cs
        └── 📁Services
            └── CustomerService.cs
        └── Core.csproj
    └── 📁Infrastructure
        └── 📁BackgroundJobs
        └── 📁Caching
            └── RedisCacheServicecs.cs
        └── 📁Configuration
            └── EmailSettings.cs
            └── ServiceCollectionExtensions.cs
        └── 📁Data
            └── CustomerRepository.cs
            └── DBConnectionFactory.cs
        └── 📁DatabaseSeeder
            └── 📁SQLScripts
                └── SeedCustomers.sql
            └── Seeder.cs
        └── 📁EventBus
            └── AzureServiceBus.cs
        └── 📁ExternalServices
            └── 📁HttpClientWrappers
            └── EmailService.cs
        └── 📁FileStorage
            └── BlobStorageService.cs
            └── FileStorageService.cs
        └── 📁Logging
            └── DatabaseLogger.cs
            └── FileLogger.cs
        └── 📁Security
            └── JwtTokenService.cs
        └── Infrastructure.csproj
    └── 📁Tests
        └── 📁FunctionalTests

            └── FunctionalTests.csproj
            └── UnitTest1.cs
        └── 📁IntegrationTests
            └── IntegrationTests.csproj
            └── UnitTest1.cs
        └── 📁UnitTests
            └── UnitTest1.cs
            └── UnitTests.csproj
    └── 📁Web
        └── 📁Controllers
            └── CustomerController.cs
        └── 📁Properties
            └── launchSettings.json
        └── appsettings.Development.json
        └── appsettings.json
        └── mydatabase.db
        └── Program.cs
        └── Web.csproj
        └── Web.csproj.user
        └── Web.http
```
