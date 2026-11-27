# Practical 10 – Student Management REST API (Local / No Database)

## Aim
Build a Student Management REST API using ASP.NET Core with CRUD operations and a responsive web dashboard.

## Technologies
- ASP.NET Core 8 Minimal API
- C#
- HTML, CSS and JavaScript
- Swagger / OpenAPI

## Storage
This version uses an in-memory `ConcurrentDictionary`. It does not use SQLite, SQL Server, Entity Framework Core, or any external database. Three sample records are loaded whenever the application starts. Any changes made while the server is running are held in memory and are reset when the application stops or restarts.

## Run the project
1. Install the .NET 8 SDK.
2. Extract the ZIP.
3. Open the `Practical10_StudentManagementAPI` folder in Visual Studio 2022 or VS Code.
4. Open a terminal in that folder and run:
   ```bash
   dotnet restore
   dotnet run
   ```
5. Open the localhost URL shown in the terminal.
6. Open `/swagger` on the same host to test the REST API.

## API endpoints
| Method | Endpoint | Purpose |
|---|---|---|
| GET | `/api/students` | Get all students |
| GET | `/api/students?search=aarav` | Search students |
| GET | `/api/students/{id}` | Get one student |
| POST | `/api/students` | Add a student |
| PUT | `/api/students/{id}` | Update a student |
| DELETE | `/api/students/{id}` | Delete a student |
| GET | `/api/health` | API health check |

## Sample JSON for POST / PUT
```json
{
  "fullName": "Smit Jhinjhuvadia",
  "email": "smit@example.com",
  "course": "Computer Science",
  "semester": 5,
  "phone": "9876543210",
  "enrollmentNo": "MU2024004"
}
```

## Practical outcome
A working local ASP.NET Core REST API with CRUD operations, Swagger documentation, in-memory data storage and a responsive student management dashboard.


## Compatibility note
The endpoint definitions intentionally do not use the optional `WithOpenApi()` extension, so the project does not need the separate `Microsoft.AspNetCore.OpenApi` package. Swagger UI is still configured through Swashbuckle.


## Visual Studio launch configuration
This project includes one explicit HTTP launch profile (`Practical10_StudentManagementAPI`) at `http://localhost:5080`. It does not require the ASP.NET Core HTTPS development certificate.

If Visual Studio still shows a launch-profile/self-host configuration error after extracting this updated ZIP:
1. Close Visual Studio.
2. In the extracted project folder, delete the hidden `.vs` folder if it exists.
3. Delete the `bin` and `obj` folders if they exist.
4. Reopen the `.csproj` file or solution in Visual Studio.
5. Select the `Practical10_StudentManagementAPI` run target and press F5.

You can also run it from the project folder with `dotnet run`, then open `http://localhost:5080`.


## Dashboard and Swagger
When you press F5, the browser opens the Student Management dashboard at `http://localhost:5080/`. Swagger is available separately at `http://localhost:5080/swagger` for API testing. The dashboard is the main user-facing output for this practical.


## Normal application usage
Press F5 to open the Student Management dashboard at `http://localhost:5080/`. Swagger is intentionally not linked in the dashboard navigation. To access API testing separately when needed, manually visit `http://localhost:5080/swagger` in a browser tab.
