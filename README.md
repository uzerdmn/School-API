# 🎓 School API

Welcome to the School API project! This RESTful API manages school operations, including user authentication for various roles such as Students, Teachers, and Administrators. It also handles subjects, grades, and semester periods. You can find the latest releases [here](https://github.com/uzerdmn/School-API/releases).

![School API](https://img.shields.io/badge/School_API-v1.0-brightgreen)

## 🚀 Technologies Used

This project employs a range of technologies to ensure robust functionality and maintainability:

- **ASP.NET Core 8**: A powerful framework for building web applications.
- **Entity Framework Core**: An ORM that simplifies data access.
- **SQL Server**: A reliable database solution for storing school data.
- **Unit of Work + Repository Pattern**: These patterns promote clean architecture and maintainability.

## 📂 Project Structure

The project is organized into several key folders, each serving a specific purpose:

```
├── school-api/
│ ├── Properties/
│ ├── SQL/
│ │ └── Int.sql
│ ├── Src/
│ │ ├── Core/
│ │ ├── Application/
│ │ ├── Infrastructure/
│ │ └── API/
│ ├── appsettings.Development.json
│ ├── appsettings.json
│ └── school_api.csproj
├── .gitignore
├── README.md
└── school_web_api.sln
```

### Core

This folder contains domain entities and interfaces that define the core business logic of the application.

### Application

Here, you will find use cases, Data Transfer Objects (DTOs), services, and validation logic. This layer interacts with the Core and Infrastructure layers.

### Infrastructure

This folder holds the implementation of repositories, Entity Framework configurations, and data access logic.

### API

The presentation layer consists of controllers and middleware that handle incoming requests and responses.

## 🔐 Authentication

The API uses JSON Web Tokens (JWT) for authentication. This method validates user credentials and controls access based on user roles. 

## 🌐 Endpoints

The API provides several endpoints for different functionalities:

- **User Authentication**: Log in and receive a JWT.
- **Subject Management**: Add, update, or delete subjects.
- **Grade Management**: Record and retrieve student grades.
- **Semester Management**: Manage semester periods.

### Example Endpoint

Here’s a sample endpoint for user login:

```http
POST /api/auth/login
Content-Type: application/json

{
  "username": "exampleUser",
  "password": "examplePassword"
}
```

On successful authentication, the server responds with a JWT that can be used for subsequent requests.

## 🔧 Installation

To set up the project locally, follow these steps:

1. Clone the repository:

   ```bash
   git clone https://github.com/uzerdmn/School-API.git
   ```

2. Navigate to the project directory:

   ```bash
   cd School-API
   ```

3. Restore the NuGet packages:

   ```bash
   dotnet restore
   ```

4. Update the connection string in `appsettings.json` to point to your SQL Server instance.

5. Run the application:

   ```bash
   dotnet run
   ```

## 🛠 Usage

After running the application, you can access the API through `http://localhost:5000/api`. Use tools like Postman or cURL to test the endpoints.

### Example Request

To get a list of subjects, send a GET request to:

```http
GET /api/subjects
Authorization: Bearer {your_jwt_token}
```

## 🔍 Testing

The project includes unit tests to ensure the functionality of critical components. To run the tests, use:

```bash
dotnet test
```

## 📚 Documentation

For detailed documentation, please refer to the Wiki section of this repository. It includes guides on how to use the API effectively.

## 🎉 Contributing

Contributions are welcome! Please follow these steps:

1. Fork the repository.
2. Create a new branch for your feature or bug fix.
3. Commit your changes.
4. Push your branch to your forked repository.
5. Create a pull request.

## 📅 Release Notes

For the latest updates and changes, check the [Releases](https://github.com/uzerdmn/School-API/releases) section.

## 💬 Support

If you encounter issues or have questions, feel free to open an issue in this repository. 

## 📖 Topics

This project covers various topics relevant to its functionality:

- `api-rest`
- `asp-net`
- `clean-architecture`
- `csharp`
- `ddd-patterns`
- `entity-framework`
- `mvc`
- `repository-pattern`
- `school`
- `sql-server`
- `unit-of-work`

## 📸 Screenshots

Here are some screenshots showcasing the API in action:

![API Screenshot 1](https://via.placeholder.com/600x400?text=API+Screenshot+1)
![API Screenshot 2](https://via.placeholder.com/600x400?text=API+Screenshot+2)

## 📝 License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

For more information and updates, visit the [Releases](https://github.com/uzerdmn/School-API/releases) section.