# 🏀 WebApplicationNBA

![.NET](https://img.shields.io/badge/.NET-8.0-blue)
![Status](https://img.shields.io/badge/status-active-success)
![Tests](https://img.shields.io/badge/tests-NUnit%20%7C%20Playwright%20%7C%20Selenium-green)
![License](https://img.shields.io/badge/license-MIT-lightgrey)

API REST desarrollada con ASP.NET Core 8, Entity Framework Core, JWT, Docker y testing automatizado completo.

Gestiona jugadores y equipos NBA mediante una API segura, documentada con Swagger y preparada para despliegue.

---

# 🚀 Tecnologías usadas

- ASP.NET Core 8
- Entity Framework Core
- SQL Server
- JWT Authentication
- Swagger / OpenAPI
- Docker
- NUnit (Testing)
- Playwright (E2E Testing)
- Selenium (E2E Testing)

---

# 📦 Funcionalidades

## 👤 Auth
- Login con JWT
- Protección de endpoints

### Login
POST /api/Auth/login

Pasos:
1. Obtener token
2. Copiar token
3. En Swagger usar:
   Authorize → Bearer TU_TOKEN

---

## 🏀 Players
- GET /api/Players
- POST /api/Players
- PUT /api/Players/{id}
- DELETE /api/Players/{id}

---

## 🏀 Teams
- CRUD básico de equipos

---

# 🐳 Docker

## Build imagen
docker build -t nba-api .

## Ejecutar contenedor
docker run -d -p 8090:8080 nba-api

## Swagger
http://localhost:8090/swagger

---

# 🖥️ Ejecutar en local
https://localhost:44350/swagger

---

# 📂 Arquitectura

Controllers → API endpoints  
Models → Entidades (Players, Teams)  
Data → DbContext (EF Core)  
Program.cs → Configuración del proyecto  

---

# 🧪 Testing

Este proyecto incluye testing completo en varios niveles.

## 🧪 NUnit (Unit / Integration Tests)
Test de endpoints de la API  
Ejemplo: GET /api/Players

---

## 🌐 Playwright (E2E UI Testing)
Automatiza navegador Chromium  
Abre Swagger UI  
Verifica carga de la interfaz  

Ejemplo:
await page.GotoAsync("https://localhost:44350/swagger/index.html");

---

## 🖥️ Selenium (E2E UI Testing)
Usa Chrome real  
Simula usuario  
Valida Swagger UI  

---

## ▶️ Ejecutar tests
dotnet test

Ejecutar test específico:
dotnet test --filter "FullyQualifiedName~PlayersTests"

---

# 📊 CI / Testing Status

✔ NUnit tests  
✔ Playwright E2E  
✔ Selenium E2E  

---

# 📸 Swagger UI

Swagger disponible en:
http://localhost:8090/swagger

---

# 👨‍💻 Autor

Proyecto desarrollado como práctica de backend con ASP.NET Core, JWT, Docker y Testing automatizado.

---

# 🚀 Estado del proyecto

✔ API funcional  
✔ Seguridad JWT  
✔ Swagger documentado  
✔ Tests automatizados completos  
✔ Preparado para CI/CD  

---

# ⭐ Objetivo

Demostrar arquitectura backend profesional con:

- API REST limpia  
- Seguridad JWT  
- Testing completo (Unit + E2E)  
- Automatización de navegador  
- Despliegue con Docker  
