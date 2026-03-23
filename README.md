# 💸 Expense Tracker (ASP.NET MVC + Dapper)

A simple yet well-structured **Expense Tracking Web Application** built with **ASP.NET Core MVC** and **Dapper**.
The project demonstrates clean architecture, separation of concerns, and practical CRUD operations with a relational database.

---

## 🚀 Features

* 📋 Manage expenses (Create, Read, Update, Delete)
* 🗂️ Manage categories (e.g., Food, Rent, Travel)
* 💳 Manage accounts (e.g., Cash, Card)
* 🔗 Link expenses to categories and accounts
* 🎯 User-friendly UI with dropdown selection
* ⚡ Fast data access using Dapper
* 🧱 Clean layered architecture

---

## 🧱 Architecture

The project follows a layered architecture:

```
Controller → Service → Repository → Database
```

### 🔹 Layers

* **Controllers** – Handle HTTP requests and responses
* **Services** – Contain business logic
* **Repositories** – Work with database (Dapper)
* **Models** – Represent database entities
* **DTOs** – Used for data transfer between layers
* **Views** – Razor UI pages

---

## 🛠️ Technologies Used

* **ASP.NET Core MVC (.NET 8)**
* **Dapper**
* **SQL Server (LocalDB)**
* **Bootstrap 5**
* **Razor Views**
* **Dependency Injection**

---

## 🗄️ Database Structure

### Categories

* Id
* Name

### Accounts

* Id
* Name
* Balance

### Expenses

* Id
* Title
* Amount
* CategoryId (FK)
* AccountId (FK)
* Date

---

## 🔄 Functionality

### 💸 Expenses

* Create expense with:

  * Title
  * Amount
  * Category (dropdown)
  * Account (dropdown)
  * Date
* View all expenses with:

  * Category name
  * Account name
* Edit and delete expenses

### 🗂️ Categories

* Create, edit, delete categories

### 💳 Accounts

* Create, edit, delete accounts

---

## 🎯 Key Concepts Implemented

* ✔ Repository Pattern
* ✔ Service Layer (Business Logic)
* ✔ Dependency Injection
* ✔ DTO usage (Create / Update / Details)
* ✔ Dapper for efficient SQL queries
* ✔ Clean separation of concerns
* ✔ MVC pattern

---

## 🔥 UI Improvements

* Bootstrap styling
* Navigation bar (Expenses / Categories / Accounts)
* Dropdowns instead of raw IDs (better UX)

---

## ⚙️ Setup & Run

1. Clone the repository:

```bash
git clone https://github.com/your-username/expense-tracker.git
```

2. Open in Visual Studio

3. Update connection string in `appsettings.json`:

```json
"ConnectionStrings": {
  "DefaultConnection": "Server=(localdb)\\MSSQLLocalDB;Database=ExpenseTracker;Trusted_Connection=True;"
}
```

4. Run SQL script to create database

5. Run the project 🚀

---

## 📌 Future Improvements

* 🔄 Update account balance after expense creation
* 📊 Dashboard with charts
* 🔍 Filtering (by date, category, account)
* 🔐 Authentication & authorization
* 📱 Responsive improvements

---

## 👨‍💻 Author

* Dmitry Hron
* ASP.NET Developer (Junior)

---

## ⭐ Summary

This project demonstrates:

* Real-world CRUD application
* Clean architecture
* Practical use of Dapper instead of EF Core
* Understanding of MVC and layered design

---
