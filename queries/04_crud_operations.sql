-- =====================================================
-- CRUD OPERATIONS (Create, Read, Update, Delete)
-- Complete examples of database manipulation
-- =====================================================

USE library;
GO

-- =====================================================
-- CREATE (INSERT) OPERATIONS
-- =====================================================

-- Add a new book to the library
INSERT INTO books (title, author, genre, available)
VALUES ('The Lord of the Rings', 'J.R.R. Tolkien', 'Fantasy', 1);

-- Add a new member
INSERT INTO members (name, email)
VALUES ('Grace Hopper', 'hopperg@gmail.com');

-- Add multiple books at once
INSERT INTO books (title, author, genre, available) VALUES
('Harry Potter and the Sorcerer''s Stone', 'J.K. Rowling', 'Fantasy', 1),
('The Da Vinci Code', 'Dan Brown', 'Mystery', 1),
('The Alchemist', 'Paulo Coelho', 'Fiction', 1);

-- =====================================================
-- READ (SELECT) OPERATIONS
-- =====================================================

-- Simple read - get all books
SELECT * FROM books;

-- Read with condition
SELECT * FROM books WHERE genre = 'Fantasy';

-- Read with sorting
SELECT title, author, genre FROM books ORDER BY title ASC;

-- Read with limit (Top N)
SELECT TOP 5 title, author FROM books ORDER BY book_id;

-- Read with JOIN
SELECT 
    m.name,
    b.title,
    br.borrow_date
FROM borrowrecords br
INNER JOIN members m ON br.member_id = m.member_id
INNER JOIN books b ON br.book_id = b.book_id;

-- =====================================================
-- UPDATE OPERATIONS
-- =====================================================

-- Update a single field
UPDATE books
SET available = 0
WHERE book_id = 1;

-- Update multiple fields
UPDATE members
SET name = 'Ada Augusta Lovelace',
    email = 'ada.lovelace@gmail.com'
WHERE member_id = 2;

-- Update based on condition
UPDATE books
SET genre = 'Science Fiction'
WHERE genre = 'Dystopian';

-- Update with calculation
UPDATE books
SET title = UPPER(title)
WHERE genre = 'Fantasy';

-- =====================================================
-- DELETE OPERATIONS
-- =====================================================

-- Delete a specific record
DELETE FROM borrowrecords
WHERE transaction_id = 0;

-- Delete based on condition
DELETE FROM books
WHERE available = 0 AND book_id NOT IN (SELECT book_id FROM borrowrecords);

-- Delete all records from a table (CAUTION!)
-- DELETE FROM borrowrecords; -- Uncomment to use

-- Delete with JOIN (remove members with no borrow history)
DELETE FROM members
WHERE member_id NOT IN (SELECT DISTINCT member_id FROM borrowrecords);

-- =====================================================
-- TRANSACTION EXAMPLE (All or Nothing)
-- =====================================================

BEGIN TRANSACTION;

-- Try to borrow a book
UPDATE books SET available = 0 WHERE book_id = 5;
INSERT INTO borrowrecords (book_id, member_id, borrow_date, due_date, return_date)
VALUES (5, 3, '2025-11-14', '2025-11-28', NULL);

-- If everything worked, commit
COMMIT;

-- If there was an error, rollback
-- ROLLBACK;
