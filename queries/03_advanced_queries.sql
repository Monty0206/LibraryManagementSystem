-- =====================================================
-- ADVANCED QUERIES
-- Complex joins, aggregations, and analytics
-- =====================================================

USE library;
GO

-- =====================================================
-- MEMBER BORROWING HISTORY
-- =====================================================

-- View complete borrowing history for a specific member
SELECT 
    m.name as member_name,
    b.title,
    b.author,
    br.borrow_date,
    br.due_date,
    br.return_date,
    CASE 
        WHEN br.return_date IS NULL THEN 'Currently Borrowed'
        WHEN br.return_date > br.due_date THEN 'Returned Late'
        ELSE 'Returned On Time'
    END as status
FROM borrowrecords br
INNER JOIN members m ON br.member_id = m.member_id
INNER JOIN books b ON br.book_id = b.book_id
WHERE m.member_id = 0
ORDER BY br.borrow_date DESC;

-- =====================================================
-- POPULAR BOOKS (Most Borrowed)
-- =====================================================

SELECT 
    b.book_id,
    b.title,
    b.author,
    b.genre,
    COUNT(br.transaction_id) as times_borrowed
FROM books b
LEFT JOIN borrowrecords br ON b.book_id = br.book_id
GROUP BY b.book_id, b.title, b.author, b.genre
ORDER BY times_borrowed DESC;

-- =====================================================
-- MEMBER STATISTICS
-- =====================================================

SELECT 
    m.member_id,
    m.name,
    m.email,
    COUNT(br.transaction_id) as total_books_borrowed,
    SUM(CASE WHEN br.return_date IS NULL THEN 1 ELSE 0 END) as currently_borrowed,
    SUM(CASE WHEN br.return_date > br.due_date THEN 1 ELSE 0 END) as late_returns
FROM members m
LEFT JOIN borrowrecords br ON m.member_id = br.member_id
GROUP BY m.member_id, m.name, m.email
ORDER BY total_books_borrowed DESC;

-- =====================================================
-- BOOKS NEVER BORROWED
-- =====================================================

SELECT 
    b.book_id,
    b.title,
    b.author,
    b.genre
FROM books b
LEFT JOIN borrowrecords br ON b.book_id = br.book_id
WHERE br.transaction_id IS NULL;

-- =====================================================
-- GENRE POPULARITY ANALYSIS
-- =====================================================

SELECT 
    b.genre,
    COUNT(DISTINCT b.book_id) as total_books,
    COUNT(br.transaction_id) as total_borrows,
    CASE 
        WHEN COUNT(DISTINCT b.book_id) > 0 
        THEN CAST(COUNT(br.transaction_id) AS FLOAT) / COUNT(DISTINCT b.book_id)
        ELSE 0 
    END as avg_borrows_per_book
FROM books b
LEFT JOIN borrowrecords br ON b.book_id = br.book_id
GROUP BY b.genre
ORDER BY avg_borrows_per_book DESC;

-- =====================================================
-- MONTHLY BORROWING TRENDS
-- =====================================================

SELECT 
    YEAR(borrow_date) as year,
    MONTH(borrow_date) as month,
    COUNT(*) as total_borrows
FROM borrowrecords
GROUP BY YEAR(borrow_date), MONTH(borrow_date)
ORDER BY year DESC, month DESC;
