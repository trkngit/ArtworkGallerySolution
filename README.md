Artwork Gallery Management System

This is a multi-layered C#/.NET 8 project designed to manage an artwork gallery's full operations.

Architecture

3-Layered Architecture:
DAL (Data Access Layer): Entity Framework Core with PostgreSQL
BLL (Business Logic Layer): DTO-service-repository structure using AutoMapper
API Layer: ASP.NET Core controllers with Swagger documentation
Features

CRUD support for:
Artworks, Artists, Galleries
Exhibitions, Critiques, Restorations
Staff, Specializations, Transactions
Owner records and exhibition assignments
Full DTO mapping for data encapsulation
Strongly-typed services and repositories
Secure API structure with validation and model state checks
Tools & Tech

C# + .NET 8
PostgreSQL
AutoMapper
Swagger (Swashbuckle)
Entity Framework Core
Visual Studio / Rider on macOS
Run It Locally

Clone the repository
Add your PostgreSQL connection string to appsettings.json
Run dotnet ef database update to migrate
Launch with dotnet run
Status

✅ Project completed during internship, July 2025
