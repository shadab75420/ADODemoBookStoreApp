# BookStore Application using ASP.NET Core MVC and ADO.NET

## Project Overview

The BookStore Application is an ASP.NET Core MVC application developed using ADO.NET for database connectivity and CRUD operations. The project demonstrates secure interaction with a SQL Server database using ADO.NET concepts such as SqlConnection, SqlCommand, SqlDataReader, SqlDataAdapter, DataSet, and DataTable.

This project was developed as part of the Wipro NGA .NET Cohort Daily Coding Assignment.

---

# Features Implemented

## 1. Book Management System

- Add new books
- View all books
- Edit existing books
- Delete books

---

## 2. Database Connectivity

- SQL Server integration using ADO.NET
- Connected architecture using SqlDataReader
- Disconnected architecture using DataSet and DataTable
- Data retrieval using SqlDataAdapter

---

## 3. SQL Injection Prevention

- Secure database operations using parameterized queries
- Input validation and sanitization
- Safe execution of SQL commands

---

## 4. Stored Procedures

- Stored procedures for:
  - Adding books
  - Updating books
  - Deleting books

---

## 5. Data Handling

- Data retrieval using SqlDataReader
- Data management using DataSet and DataTable
- Updating records using SqlDataAdapter

---

# Technologies Used

- ASP.NET Core MVC
- ADO.NET
- SQL Server
- C#
- Razor Views

---

# Project Structure

```text
BookStoreApp
│
├── Controllers
│   └── BookController.cs
│
├── DAL
│   └── BookDAL.cs
│
├── Models
│   └── Book.cs
│
├── Views
│   └── Book
│       ├── Index.cshtml
│       ├── Create.cshtml
│       ├── Edit.cshtml
│       └── Delete.cshtml
│
├── SQL Files
│   ├── BookStoreApp.sql
│   └── BookStoreApp2.sql
│
├── Output
│   └── Output.png
│
├── appsettings.json
├── Program.cs
└── BookStoreApp.csproj
```

---

# Functionalities

## View Books

Displays all books stored in the database.

---

## Add Book

Allows users to insert new book records into the database.

---

## Edit Book

Enables updating existing book information.

---

## Delete Book

Allows removal of books from the database.

---

# Database Connectivity

The application connects to SQL Server using ADO.NET components and maintains efficient database communication for CRUD operations.

---

# SQL Injection Prevention

The application uses parameterized queries and proper input handling to ensure security against SQL injection attacks.

---

# Stored Procedures

Stored procedures are used for:

- Inserting records
- Updating records
- Deleting records

This improves security, maintainability, and performance.

---

# DataSet and DataTable

The application demonstrates disconnected architecture using:

- DataSet
- DataTable
- SqlDataAdapter

These are used for managing and updating data efficiently.

---

# Best Practices Followed

- Layered Architecture
- Separate DAL Layer
- Secure Database Access
- Parameterized Queries
- Stored Procedures
- Error Handling
- Maintainable Code Structure

---

# How to Run the Project

1. Open the project in Visual Studio 2022
2. Configure SQL Server connection string
3. Execute the SQL files in SQL Server
4. Build the solution
5. Run the application using:

```text
Ctrl + F5
```

---

# Application Pages

## Book Pages

- `/Book/Index`
- `/Book/Create`
- `/Book/Edit`
- `/Book/Delete`

---

# Assignment Outcome

This project demonstrates practical implementation of:

- ADO.NET Database Connectivity
- CRUD Operations
- Stored Procedures
- SQL Injection Prevention
- SqlDataReader
- SqlDataAdapter
- DataSet and DataTable
- ASP.NET Core MVC Architecture

---
