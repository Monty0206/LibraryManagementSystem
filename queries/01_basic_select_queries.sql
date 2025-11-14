-- =====================================================
-- BASIC SELECT QUERIES
-- Demonstrating fundamental SQL SELECT operations
-- =====================================================

USE library;
GO

-- Query 1: View all books in the library
SELECT * FROM books;

-- Query 2: View all available books
SELECT book_id, title, author, genre 
FROM books 
WHERE available = 1;

-- Query 3: View all members
SELECT * FROM members;

-- Query 4: Count total books by genre
SELECT genre, COUNT(*) as total_books
FROM books
GROUP BY genre
ORDER BY total_books DESC;

-- Query 5: Find books by specific author
SELECT title, author, genre, available
FROM books
WHERE author = 'George Orwell';

-- Query 6: Search for books with 'The' in the title
SELECT title, author, genre
FROM books
WHERE title LIKE '%The%';

-- Query 7: List all fiction books
SELECT title, author
FROM books
WHERE genre = 'Fiction' OR genre = 'Dystopian';

-- Query 8: Count available vs borrowed books
SELECT 
    CASE 
        WHEN available = 1 THEN 'Available'
        ELSE 'Borrowed'
    END as status,
    COUNT(*) as count
FROM books
GROUP BY available;
