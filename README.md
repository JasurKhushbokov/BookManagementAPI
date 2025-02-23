# BookManagementAPI
Book Management API

Overview

The Book Management API is a RESTful API built using ASP.NET Core Web API (.NET 8) that allows users to manage books. It supports CRUD operations, authentication, and optional features like tracking book views and popularity scores.

Features

Create, Read, Update, and Delete (CRUD) books

API documentation using Swagger

Technologies Used

Programming Language: C#

Framework: .NET 8

Database: SQL Server (Entity Framework Core)

Architecture: 3-layered architecture (Models, Data Access, API)

Getting Started

Prerequisites

Ensure you have the following installed:

.NET 8 SDK

SQL Server

Visual Studio 2022 or any preferred IDE

Installation

Clone the repository:

git clone https://github.com/JasurKhushbokov/BookManagementAPI.git
cd BookManagementAPI

Install dependencies:

dotnet restore

Set up the database:

Update the connection string in appsettings.json:

"ConnectionStrings": {
  "DefaultConnection": "Server=YOUR_SERVER_NAME;Database=BookDB;Trusted_Connection=True;TrustServerCertificate=True;"
}

Run the migration:

dotnet ef database update

Running the API

To run the API locally:

dotnet run

The API will be available at:

https://localhost:7262/api/books

API Endpoints

Method

Endpoint

Description

GET

/api/books

Get all books

GET

/api/books/{id}

Get book by ID

POST

/api/books

Add a new book

PUT

/api/books/{id}

Update an existing book

DELETE

/api/books/{id}

Delete a book

Swagger API Documentation

Swagger is enabled for API documentation. After running the project, open:

License

This project is licensed under the MIT License.
