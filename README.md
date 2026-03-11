# 🏪 Store Management System

A **Store Management System** built with **C# and Windows Forms**, designed using a **multi-layer architecture**.
The system allows store employees to manage customers, products, promotions, and orders at the checkout while maintaining inventory and performing advanced searches and sorting.

The project follows **SOLID design principles** and implements a clear separation between business logic, data access, and user interface layers.

---

## 📋 Overview

This project demonstrates structured .NET development using a layered architecture.
It includes business logic management, multiple data access implementations, logging mechanisms, and XML-based data persistence.

The application supports store operations such as product management, customer management, promotions, checkout orders, and inventory tracking.

---

## 🏗️ Project Structure

```
Store-Management-System/
├── BL/              # Business Logic Layer
├── BlTest/          # Business Logic Tests
├── DalFacade/       # Data Access Layer Interface
├── DalList/         # In-Memory List Implementation
├── DalXml/          # XML File Implementation
├── DalTest/         # Data Access Tests
├── Tools/           # Utility classes and helpers
├── UI/              # Windows Forms User Interface
├── xml/             # XML data files
├── bin/             # Binary output
└── StoreManagementSystem.sln
```

---

## ✨ Features

* **Store Management**

  * Manage products, customers, and promotions
  * Create orders at the checkout

* **Full CRUD Operations**

  * Create, read, update, and delete for all entities

* **Search and Sorting**

  * Advanced search capabilities
  * Multiple sorting options

* **Inventory Management**

  * Track and manage store stock

* **Logging System**

  * Logs stored in a dedicated folder
  * Organized by date

* **XML Data Persistence**

  * Data stored using `DataContractSerializer`

---

## 💻 Tech Stack

* **Language:** C#
* **Framework:** .NET
* **UI:** Windows Forms
* **Data Storage:** XML
* **Queries:** LINQ
* **Serialization:** DataContractSerializer
* **Architecture:** Layered Architecture
* **Design Principles:** SOLID, Single Responsibility Principle

---

## 🛠️ Installation

### Prerequisites

* .NET SDK
* Visual Studio 2022 or later
* Windows OS

### Setup

1. Clone the repository

```
git clone https://github.com/your-username/Store-Management-System.git
```

2. Open the solution file

```
StoreManagementSystem.sln
```

3. Build the solution

```
dotnet build
```

---

## 🚀 Running the Application

### Using Visual Studio

1. Open the solution file
2. Set the **UI project** as the startup project
3. Press **F5** to run the application

---

## 🧪 Running Tests

Run all tests:

```
dotnet test
```

Run specific test projects:

```
dotnet test BlTest
dotnet test DalTest
```

---

## 📊 Data Storage

The project supports two storage mechanisms:

* **In-Memory Storage (DalList)** – useful for testing and development
* **XML Files (DalXml)** – persistent storage located in the `xml/` directory
