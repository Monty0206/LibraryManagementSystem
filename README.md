# 📚 Library Management System

**Developer:** Montell Boks  
**Date:** November 2025

---

## 📋 Project Overview

A complete **Library Management System** built with **C# Windows Forms** and **SQL Server**. This application provides a professional GUI for managing books, library members, and borrowing transactions with full CRUD operations and advanced querying capabilities.

---

## 🎯 Two Ways to Use This Project

### 1️⃣ **SQL Queries Only** (Console/SSMS)
Run the SQL scripts in SQL Server Management Studio to practice queries.

### 2️⃣ **Windows Forms Application** (Full GUI) ⭐ RECOMMENDED
Open the complete C# Windows Forms app in Visual Studio for a professional GUI!

**Quick Start:**
```powershell
cd C:\Users\monte\LibraryProject\LibraryApp
# Open LibraryManagementSystem.csproj in Visual Studio
# Press F5 to run!
```

---

## 🗄️ Database Structure

### **Tables**

#### 1. **books**
Stores information about all books in the library.

| Column | Type | Description |
|--------|------|-------------|
| `book_id` | INTEGER (PK, Auto-increment) | Unique book identifier |
| `title` | VARCHAR(100) | Book title |
| `author` | VARCHAR(100) | Book author |
| `genre` | VARCHAR(50) | Book genre/category |
| `available` | BIT | Availability status (1=available, 0=borrowed) |

**Sample Data:** 10 classic books from various genres

---

#### 2. **members**
Stores information about library members.

| Column | Type | Description |
|--------|------|-------------|
| `member_id` | INTEGER (PK, Auto-increment) | Unique member identifier |
| `name` | VARCHAR(100) | Member full name |
| `email` | VARCHAR(50) | Member email address |

**Sample Data:** 10 famous computer scientists (Dijkstra, Turing, Lovelace, etc.)

---

#### 3. **borrowrecords**
Tracks all book borrowing transactions.

| Column | Type | Description |
|--------|------|-------------|
| `transaction_id` | INTEGER (PK, Auto-increment) | Unique transaction identifier |
| `book_id` | INTEGER (FK) | Reference to books table |
| `member_id` | INTEGER (FK) | Reference to members table |
| `borrow_date` | DATE | Date book was borrowed |
| `due_date` | DATE | Date book is due for return |
| `return_date` | DATE (nullable) | Date book was returned (NULL if still borrowed) |

---

## 📁 Project Structure

```
LibraryProject/
│
├── database/
│   └── library.sql                 # Complete database creation script
│
├── queries/
│   ├── 01_basic_select_queries.sql # Basic SELECT operations
│   ├── 02_borrow_operations.sql    # Borrow/return operations
│   ├── 03_advanced_queries.sql     # Complex JOINs and analytics
│   └── 04_crud_operations.sql      # Full CRUD examples
│
├── README.md                        # This file
└── ASSIGNMENT_NOTES.md             # Assignment requirements & solutions
```

---

## 🚀 Features Demonstrated

### ✅ **Basic Operations**
- SELECT queries with WHERE clauses
- Filtering and sorting
- COUNT and GROUP BY aggregations
- LIKE pattern matching

### ✅ **Borrow Management**
- Record book borrowing
- Track return dates
- Mark books as available/unavailable
- View currently borrowed books
- Identify overdue books

### ✅ **Advanced Queries**
- INNER JOIN (multiple tables)
- LEFT JOIN (including null records)
- Subqueries
- CASE statements
- Aggregate functions (COUNT, SUM, AVG)
- Date calculations (DATEDIFF, GETDATE)
- Window functions

### ✅ **CRUD Operations**
- CREATE: INSERT new records
- READ: SELECT with various conditions
- UPDATE: Modify existing records
- DELETE: Remove records safely
- TRANSACTIONS: Ensure data integrity

---

## 💡 Key Concepts Demonstrated

### **Database Design**
- Primary Keys (IDENTITY)
- Foreign Keys (relationships)
- Proper data types
- NULL vs NOT NULL constraints

### **Data Integrity**
- Referential integrity (books ↔ borrowrecords ↔ members)
- Transaction management (BEGIN/COMMIT/ROLLBACK)
- Cascading updates

### **Business Logic**
- Availability tracking
- Overdue detection
- Member borrowing history
- Popular book analytics
- Genre popularity analysis

---

## 📊 Sample Queries

### **View Available Books**
```sql
SELECT title, author, genre 
FROM books 
WHERE available = 1;
```

### **Find Overdue Books**
```sql
SELECT 
    b.title,
    m.name as member_name,
    br.due_date,
    DATEDIFF(day, br.due_date, GETDATE()) as days_overdue
FROM borrowrecords br
INNER JOIN books b ON br.book_id = b.book_id
INNER JOIN members m ON br.member_id = m.member_id
WHERE br.return_date IS NULL 
  AND br.due_date < GETDATE();
```

### **Member Borrowing Statistics**
```sql
SELECT 
    m.name,
    COUNT(br.transaction_id) as total_borrowed,
    SUM(CASE WHEN br.return_date IS NULL THEN 1 ELSE 0 END) as currently_has
FROM members m
LEFT JOIN borrowrecords br ON m.member_id = br.member_id
GROUP BY m.name;
```

---

## 🛠️ How to Run

### **Option 1: SQL Server Management Studio (SSMS)**
1. Open SSMS
2. Connect to your SQL Server instance
3. Open `database/library.sql`
4. Execute to create database and populate data
5. Run queries from the `queries/` folder

### **Option 2: Azure Data Studio**
1. Open Azure Data Studio
2. Create new connection
3. Open and run `library.sql`
4. Execute query files as needed

### **Option 3: Command Line (sqlcmd)**
```bash
sqlcmd -S localhost -i database\library.sql
```

---

## 📝 Notes

- All queries are tested and working
- Sample data includes 10 books and 10 members
- Foreign key relationships properly defined
- Queries demonstrate progressive complexity
- Code is well-commented for understanding

---

## 🛠️ Technologies Used

- **Language:** C# (.NET Framework 4.7.2)
- **UI Framework:** Windows Forms
- **Database:** SQL Server / LocalDB
- **IDE:** Visual Studio
- **Key Skills:** Database design, SQL queries, GUI development, CRUD operations

---

## 💡 Key Features

This project demonstrates:
1. **Database Design:** Proper normalization and relationships
2. **SQL Mastery:** From basic to advanced queries
3. **Business Logic:** Real-world library operations
4. **Data Integrity:** Transactions and constraints
5. **Windows Forms:** Professional desktop application development

---

## 📧 Contact

**Developer:** Montell Boks  
**GitHub:** [Your GitHub Profile]

---

*A professional library management solution demonstrating C# and SQL Server expertise*
