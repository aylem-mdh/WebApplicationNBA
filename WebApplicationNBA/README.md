🏀 WebApplicationNBA
API REST desarrollada con ASP.NET Core 8, Entity Framework Core, JWT y Docker

Gestiona jugadores y equipos NBA mediante una API REST segura, documentada con Swagger y preparada para despliegue con Docker.



# 🏀 WebApplicationNBA - ASP.NET Core API

API RESTful para la gestión de jugadores y equipos NBA con autenticación JWT, documentación Swagger y despliegue en Docker.

---

## 🚀 Tecnologías usadas

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger / OpenAPI
- Docker

---

## 📦 Funcionalidades

### 👤 Auth
- Login con JWT
- Protección de endpoints

### 🏀 Players
- GET /api/Players
- POST /api/Players
- PUT /api/Players/{id}
- DELETE /api/Players/{id}

### 🏀 Teams
- CRUD básico de equipos

---

## 🔐 Autenticación JWT

Para acceder a endpoints protegidos:

1. Ejecuta login:

POST /api/Auth/login

2. Copia el token recibido

3. En Swagger:
- Click en **Authorize**
- Escribe:

Bearer TU_TOKEN_AQUI

---

## 🐳 Ejecutar con Docker

### 1. Build de la imagen

docker build -t nba-api .

### 2. Ejecutar contenedor

docker run -d -p 8090:8080 nba-api

### 3. Abrir Swagger

http://localhost:8090/swagger

---

## 🖥️ Ejecutar en local (Visual Studio)

https://localhost:44350/swagger

---

## 📂 Arquitectura del proyecto

- Controllers → lógica de la API
- Models → entidades (Players, Teams, User)
- Data → DbContext (EF Core)
- Program.cs → configuración del proyecto

---


## 👨‍💻 Autor

Proyecto desarrollado como práctica de backend con ASP.NET Core, JWT y Docker.



## 📸 Swagger UI

![Swagger UI](swagger-home.png)