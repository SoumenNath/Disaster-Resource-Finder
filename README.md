# Disaster Resource Finder

A full-stack web application that helps users locate nearby disaster relief resources such as shelters, food banks, and medical centers.
Users can view real-time availability, submit reports, and administrators can manage and verify updates.

---

## Features

### Resource Discovery

* Search for nearby resources using geolocation (latitude/longitude + radius)
* Filter by city, type (Shelter, Food, Medical), etc.
* View real-time availability (AvailableSpots)

### Crowdsourced Reports

* Authenticated users can submit updates (e.g., “shelter is full”)
* Reports include type, description, and timestamp

### Admin Moderation

* Admins can:

  * Approve or reject reports
  * Create, update, and delete resources

### Authentication & Authorization

* JWT-based authentication
* Role-based access:

  * Admin → full control
  * User → submit reports, view data
  * Public → read-only access (approved data only)

---

## Tech Stack

### Frontend

* Blazor WebAssembly (C# SPA)
* HttpClient for API communication
* Custom AuthenticationStateProvider (JWT handling)

### Backend

* ASP.NET Core Web API (.NET 8)
* Entity Framework Core (Code First)
* ASP.NET Identity (User & Role management)
* JWT Authentication

### Database

* SQL Server (LocalDB)
* EF Core Migrations

---

## Project Structure

```
DisasterResourceFinder/
│
├── DisasterResourceFinder/          # ASP.NET Core API
│   ├── Controllers/
│   ├── Models/
│   ├── Data/
│   └── Program.cs
│
├── DisasterResourceFinder.Client/   # Blazor WebAssembly frontend
│   ├── Pages/
│   ├── Shared/
│   └── Program.cs
│
└── README.md
```

---

## Setup & Installation

### 1. Clone the Repository

```
git clone https://github.com/your-username/disaster-resource-finder.git
cd disaster-resource-finder
```

---

### 2. Setup Backend (API)

```
cd DisasterResourceFinder
dotnet restore
dotnet build
```

### Apply Migrations & Create Database

```
dotnet ef database update
```

### Run the API

```
dotnet run
```

API will run at:

```
https://localhost:5001
```

---

### 3. Setup Frontend (Blazor)

```
cd ../DisasterResourceFinder.Client
dotnet restore
dotnet run
```

Frontend will run at:

```
https://localhost:5002
```

---

## Default Accounts (Seeded)

| Role  | Email                                                       | Password  |
| ----- | ----------------------------------------------------------- | --------- |
| Admin | [admin@disasterfinder.com](mailto:admin@disasterfinder.com) | Admin@123 |
| User  | [user@disasterfinder.com](mailto:user@disasterfinder.com)   | User@123  |

---

## API Testing

You can test endpoints using tools like Postman.

Example:

```
GET /api/resources
POST /api/auth/login
POST /api/reports
```

---

## Example Workflow

1. User logs in and receives a JWT token
2. User searches for nearby resources
3. User submits a report (e.g., “shelter is full”)
4. Admin reviews and approves the report
5. Approved data becomes visible to the public

---

## Author

Moi.

---

## License

This project is for educational purposes.
