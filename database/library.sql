-- =====================================================
-- Library Management System Database
-- Student: Montell Boks
-- Database: SQL Server
-- =====================================================

-- Create the library database
CREATE DATABASE library;
GO

USE library;
GO

-- =====================================================
-- TABLE: books
-- Stores information about all books in the library
-- =====================================================
CREATE TABLE books (
    book_id INTEGER IDENTITY(0, 1) PRIMARY KEY,
    title VARCHAR(100) NOT NULL,
    author VARCHAR(100) NOT NULL,
    genre VARCHAR(50) NOT NULL,
    available BIT NULL
);
GO

-- =====================================================
-- TABLE: members
-- Stores information about library members
-- =====================================================
CREATE TABLE members (
    member_id INTEGER IDENTITY(0, 1) PRIMARY KEY,
    name VARCHAR(100) NOT NULL,
    email VARCHAR(50)
);
GO

-- =====================================================
-- TABLE: borrowrecords
-- Tracks all book borrowing transactions
-- =====================================================
CREATE TABLE borrowrecords (
    transaction_id INTEGER IDENTITY(0, 1) PRIMARY KEY,
    book_id INTEGER NOT NULL,
    member_id INTEGER NOT NULL,
    borrow_date DATE NOT NULL,
    due_date DATE NOT NULL,
    return_date DATE NULL
);
GO

-- =====================================================
-- SAMPLE DATA: Insert 10 books
-- =====================================================
INSERT INTO books (title, author, genre, available) VALUES
('To Kill a Mockingbird', 'Harper Lee', 'Fiction', 1),
('1984', 'George Orwell', 'Dystopian', 1),
('Pride and Prejudice', 'Jane Austen', 'Romance', 1),
('The Great Gatsby', 'F. Scott Fitzgerald', 'Classic', 1),
('Moby Dick', 'Herman Melville', 'Adventure', 1),
('The Catcher in the Rye', 'J.D. Salinger', 'Fiction', 1),
('The Hobbit', 'J.R.R. Tolkien', 'Fantasy', 1),
('War and Peace', 'Leo Tolstoy', 'Historical', 1),
('The Odyssey', 'Homer', 'Epic', 1),
('Brave New World', 'Aldous Huxley', 'Dystopian', 1);
GO

-- =====================================================
-- SAMPLE DATA: Insert 10 members (Famous CS pioneers!)
-- =====================================================
INSERT INTO members (name, email) VALUES
('Edsger Dijkstra', 'dijkstrae@gmail.com'),
('Haskell Curry', 'curryh@gmail.com'),
('Ada Lovelace', 'lovelacea@gmail.com'),
('John Conway', 'conwayj@gmail.com'),
('John Carmack', 'carmackj@gmail.com'),
('Donald Knuth', 'knuthd@gmail.com'),
('Dennis Ritchie', 'ritchied@gmail.com'),
('Linus Torvalds', 'torvaldsl@gmail.com'),
('Tony Hoare', 'hoaret@gmail.com'),
('Alan Turing', 'turinga@gmail.com');
GO
