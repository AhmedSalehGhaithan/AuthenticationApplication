# ASP.NET Core JWT Authentication & User Management API

[![ASP.NET Core](https://img.shields.io/badge/ASP.NET_Core-6.0-purple)](https://dotnet.microsoft.com/)
[![JWT](https://img.shields.io/badge/JWT-Authentication-orange)](https://jwt.io/)

A secure ASP.NET Core Web API for user authentication and management using JSON Web Tokens (JWT), with role-based authorization and refresh token support.

---

## 📌 Features
- **JWT Authentication**: Secure login/register with access and refresh tokens.
- **Role-Based Access Control**: Roles include `Admin`, `Teacher`, and `Student`.
- **User Management**:
  - Admin can create/delete users and assign roles.
  - Profile management for all users.
- **Refresh Tokens**: Auto-renew expired access tokens.
- **Swagger API Documentation**: Interactive API testing UI.
- **Entity Framework Core**: SQL Server database integration.

---

## 🛠 Technologies
- **Backend**: ASP.NET Core 6
- **Authentication**: JWT Bearer Tokens
- **ORM**: Entity Framework Core
- **Database**: SQL Server (configurable to PostgreSQL/MySQL)
- **Tools**: Swagger (OpenAPI), Postman

---

## 🚀 Getting Started

### Prerequisites
- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- [SQL Server](https://www.microsoft.com/sql-server) or another database provider
- IDE (e.g., Visual Studio, VS Code)

### Installation
1. Clone the repository:
   ```bash
   git clone https://github.com/your-repo/aspnet-jwt-auth.git
   cd aspnet-jwt-auth
