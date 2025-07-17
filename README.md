# App Management Starter Project

This repository provides a foundation for building a **Book Store**, **Game Store**, or **Music Store** web application using ASP.NET Core (.NET 8) with authentication already implemented.

## Features

- User registration and login with JWT authentication
- Role-based authorization (Administrator, Customer)
- Modular architecture (API, Application, Infrastructure layers)
- Entity Framework Core with SQL Server
---

## Getting Started

### Prerequisites

- [.NET 8 SDK](https://dotnet.microsoft.com/download/dotnet/8.0)
- [SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads) or Local Db
- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/)

### Setup Instructions

#### 1. Clone the repository
#### 2. Configure the database connection (Optional if you use Local Db)

Update the `AppManagement.Api/appsettings.Development.json` file with your SQL Server connection string:

```json
"ConnectionStrings": {
	"AppManagementConnectionString": "Server=YOUR_SERVER;Database=AppManagementDb;Trusted_Connection=True;MultipleActiveResultSets=true"
}
```
Replace `YOUR_SERVER`, `your_user`, and `your_password` with your actual SQL Server details.

#### 3. Apply database migrations

1. Go to the top menu bar in Visual Studio.
2. Set `AppManagement.Api` as the startup project:	
	1. In **Solution Explorer**, right-click on the `AppManagement.Api` project.
	2. Select **Set as Startup Project** from the context menu.
	3. The project name will appear in bold, indicating it is now the startup project.
3. Click __Tools__ ➡️ __NuGet Package Manager__ ➡️ __Package Manager Console__.
3. Set Default project to `AppManagement.Infrastructure`.
5. Run:
 ```pwsh
 Update-Database -Context ApplicationIdentityDbContext
```

#### 4. Define Secret Key for JWT

1. Open Git Bash and execute the following command to generate a secret key:
```bash
openssl rand -hex 32
```
2. Copy the generated keyvIn `AppManagement.Api/appsettings.Development.json`, add a secret key for JWT authentication:
```json
"JwtSettings": {
	"Key": "SECRET_JWT_KEY_HERE"
	... // other JWT settings
}
```

#### 5. Run the application

- Run the application using Visual Studio (F5 or Ctrl+F5).

#### 5. Explore the API

- Swagger UI is available at `https://localhost:7155/swagger` for testing authentication endpoints.

---

## Authentication Endpoints

- `POST /api/auth/login` – User login
- `POST /api/auth/register` – User registration

Example request payloads can be found in the Swagger UI.

---

## Next Steps

> NB: The choice of project (Book Store, Game Store, or Music Store) will be made by your Project Buddy.

- Add domain models, controllers, and business logic for your chosen store.
- Implement product management, shopping cart, and order features as needed.

---

## Project Structure

- `AppManagement.Api` – API layer (controllers endpoints)
- `AppManagement.Application` – Application logic (interfaces, DTOs, services)
- `AppManagement.Infrastructure` – Data access, Identity

---

## Useful Resources

- [ASP.NET Core Documentation](https://docs.microsoft.com/en-us/aspnet/core/)
- [Entity Framework Core Documentation](https://docs.microsoft.com/en-us/ef/core/)
- [Microsoft Identity Platform](https://docs.microsoft.com/en-us/azure/active-directory/develop/)

---

## License

This project is licensed under the MIT License.

