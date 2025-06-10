
# 🎓 School_API 

API Rest para la gestion escolar que permite la autenticación de usuarios con diferentes roles (Alumnos, Docentes y Administradores), gestión de materias, calificaciones y periodos semestrales.


## 🚀 Tecnologías utilizadas

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- Unit of Work + Repository Pattern


## 📂 Estructura del proyecto

- `App`: Servicios de aplicación y lógica de negocio.
- `Core`: Entidades.
- `Infrastructure`: Implementaciones de repositorio y acceso a datos, middlewares y filtros.
- `Presentation`: Endpoints y configuración general de la API.

```text
school-api/
├── Src/
│ ├── Core/ # Entidades del dominio, interfaces, objetos de valor
│ ├── Application/ # Casos de uso, DTOs, servicios, validaciones
│ ├── Infrastructure/ # Implementaciones de repositorios, EF, acceso a datos
│ └── API/ # Capa de presentación: controladores, middlewares
├── Scripts/
│ └── init-db.sql # Script para creación inicial de base de datos
├── README.md
├── school-api.sln
```

## 🔐 Autenticación

- Autenticación basada en Json Web Token (JWT) con validacion de credenciales y control de acceso mediante roles de usuario.
- Hashing de contraseñas usando el algoritmo Argon2id


## 🗃️ Diagrama de Base de Datos

![Data Base diagram](school_api/SQL/Diagram.png)


## 🛠️ Instalar paquetes y ejecutar el proyecto

Instalar paquetes nuget via terminal 

```bash
dotnet restore
```

Ejecutar el proyecto

```bash
dotnet run --project school_api/school_api.csproj
```