# Pokemon
PokeAPI example

**Technologies Used**
- ASP.NET Core (.NET 5) Web API
- MediatR for .NET 5
- Fluent Validation for .NET 5
- SwaggerUI
- HTTP Client
- Angular 13 (Client)
- Bootstrap 4 (CSS Framework)
- Nginx (Proxy)
- Docker Compose
- Visual studio 2022

**How do I get started with Docker Compose?**
To get started, follow the below steps:

* Install .NET 5 SDK
* Install the latest NodeJS
* Install Docker Desktop (for Windows) / Docker (for Linux/Mac)
* Clone the Solution into your Local Directory
* On the Repository root you can find the docker-compose.yml file
* Run the below command to build and run the solution in Docker (requires a working Docker installation)

```
docker-compose build --force-rm --no-cache && docker-compose up
```

Once the containers start successfully navigate to http://localhost

First run dotnet application in Visual Studion (v2019 or later)

Check the port and set enviromets variable inside Adecco.Pokemon.Client

run angular application with: 

>ng serve --o
