using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            LoadData();
        }
        
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Test database connection
            if (!DatabaseHelper.TestConnection())
            {
                MessageBox.Show("Could not connect to database. Please check your connection string.",
                    "Connection Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadData()
        {
            try
            {
                // Load Books
                LoadBooks();
                // Load Members
                LoadMembers();
                // Load Borrow Records
                LoadBorrowRecords();
                // Update Statistics
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading data: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadBooks()
        {
            string query = "SELECT book_id, title, author, genre, " +
                          "CASE WHEN available = 1 THEN 'Yes' ELSE 'No' END as Available " +
                          "FROM books ORDER BY title";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvBooks.DataSource = dt;
        }

        private void LoadMembers()
        {
            string query = "SELECT member_id, name, email FROM members ORDER BY name";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvMembers.DataSource = dt;
        }

        private void LoadBorrowRecords()
        {
            string query = @"
                SELECT 
                    br.transaction_id,
                    b.title as Book,
                    m.name as Member,
                    br.borrow_date as 'Borrow Date',
                    br.due_date as 'Due Date',
                    br.return_date as 'Return Date',
                    CASE 
                        WHEN br.return_date IS NULL THEN 'Borrowed'
                        ELSE 'Returned'
                    END as Status
                FROM borrowrecords br
                INNER JOIN books b ON br.book_id = b.book_id
                INNER JOIN members m ON br.member_id = m.member_id
                ORDER BY br.borrow_date DESC";
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvBorrowRecords.DataSource = dt;
        }

        private void UpdateStatistics()
        {
            try
            {
                // Total Books
                object totalBooks = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM books");
                lblTotalBooks.Text = $"Total Books: {totalBooks}";

                // Available Books
                object availableBooks = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM books WHERE available = 1");
                lblAvailableBooks.Text = $"Available: {availableBooks}";

                // Borrowed Books
                object borrowedBooks = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM borrowrecords WHERE return_date IS NULL");
                lblBorrowedBooks.Text = $"Currently Borrowed: {borrowedBooks}";

                // Total Members
                object totalMembers = DatabaseHelper.ExecuteScalar("SELECT COUNT(*) FROM members");
                lblTotalMembers.Text = $"Total Members: {totalMembers}";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error updating statistics: " + ex.Message);
            }
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            AddBookForm form = new AddBookForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
                UpdateStatistics();
            }
        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            AddMemberForm form = new AddMemberForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMembers();
                UpdateStatistics();
            }
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
            BorrowBookForm form = new BorrowBookForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
                LoadBorrowRecords();
                UpdateStatistics();
            }
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
            ReturnBookForm form = new ReturnBookForm();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadBooks();
                LoadBorrowRecords();
                UpdateStatistics();
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Data refreshed successfully!", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnSearchBooks_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearchBooks.Text.Trim();
            if (string.IsNullOrEmpty(searchTerm))
            {
                LoadBooks();
                return;
            }

            string query = $@"
                SELECT book_id, title, author, genre, 
                       CASE WHEN available = 1 THEN 'Yes' ELSE 'No' END as Available 
                FROM books 
                WHERE title LIKE '%{searchTerm}%' 
                   OR author LIKE '%{searchTerm}%' 
                   OR genre LIKE '%{searchTerm}%'
                ORDER BY title";
            
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            dgvBooks.DataSource = dt;
        }

        private void btnViewOverdue_Click(object sender, EventArgs e)
        {
            string query = @"
                SELECT 
                    b.title as Book,
                    m.name as Member,
                    m.email as Email,
                    br.due_date as 'Due Date',
                    DATEDIFF(day, br.due_date, GETDATE()) as 'Days Overdue'
                FROM borrowrecords br
                INNER JOIN books b ON br.book_id = b.book_id
                INNER JOIN members m ON br.member_id = m.member_id
                WHERE br.return_date IS NULL 
                  AND br.due_date < GETDATE()
                ORDER BY br.due_date";
            
            DataTable dt = DatabaseHelper.ExecuteQuery(query);
            
            if (dt.Rows.Count == 0)
            {
                MessageBox.Show("No overdue books!", "Information",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                OverdueForm form = new OverdueForm(dt);
                form.ShowDialog();
            }
        }
    }
}
