-- =====================================================
-- BORROW & RETURN OPERATIONS
-- Managing book borrowing transactions
-- =====================================================

USE library;
GO

-- =====================================================
-- BORROW A BOOK
-- =====================================================

-- Step 1: Check if book is available
SELECT book_id, title, author, available
FROM books
WHERE book_id = 0 AND available = 1;

-- Step 2: Record the borrow transaction
-- Example: Edsger Dijkstra (member_id=0) borrows "To Kill a Mockingbird" (book_id=0)
INSERT INTO borrowrecords (book_id, member_id, borrow_date, due_date, return_date)
VALUES (0, 0, '2025-11-14', '2025-11-28', NULL);

-- Step 3: Mark book as borrowed
UPDATE books
SET available = 0
WHERE book_id = 0;

-- =====================================================
-- RETURN A BOOK
-- =====================================================

-- Step 1: Record the return date
UPDATE borrowrecords
SET return_date = '2025-11-20'
WHERE transaction_id = 0 AND return_date IS NULL;

-- Step 2: Mark book as available again
UPDATE books
SET available = 1
WHERE book_id = 0;

-- =====================================================
-- VIEW CURRENT BORROWED BOOKS
-- =====================================================
SELECT 
    br.transaction_id,
    b.title,
    b.author,
    m.name as member_name,
    br.borrow_date,
    br.due_date,
    DATEDIFF(day, GETDATE(), br.due_date) as days_until_due
FROM borrowrecords br
INNER JOIN books b ON br.book_id = b.book_id
INNER JOIN members m ON br.member_id = m.member_id
WHERE br.return_date IS NULL
ORDER BY br.due_date;

-- =====================================================
-- VIEW OVERDUE BOOKS
-- =====================================================
SELECT 
    br.transaction_id,
    b.title,
    m.name as member_name,
    m.email,
    br.borrow_date,
    br.due_date,
    DATEDIFF(day, br.due_date, GETDATE()) as days_overdue
FROM borrowrecords br
INNER JOIN books b ON br.book_id = b.book_id
INNER JOIN members m ON br.member_id = m.member_id
WHERE br.return_date IS NULL 
  AND br.due_date < GETDATE()
ORDER BY days_overdue DESC;
