using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class ReturnBookForm : Form
    {
        public ReturnBookForm()
        {
            InitializeComponent();
            LoadBorrowedBooks();
        }

        private void LoadBorrowedBooks()
        {
            try
            {
                string query = @"
                    SELECT 
                        br.transaction_id,
                        b.title + ' (borrowed by ' + m.name + ')' as DisplayText,
                        b.book_id
                    FROM borrowrecords br
                    INNER JOIN books b ON br.book_id = b.book_id
                    INNER JOIN members m ON br.member_id = m.member_id
                    WHERE br.return_date IS NULL
                    ORDER BY b.title";
                
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                
                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("No books are currently borrowed.", "Information",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();
                    return;
                }
                
                cboBorrowedBooks.DisplayMember = "DisplayText";
                cboBorrowedBooks.ValueMember = "transaction_id";
                cboBorrowedBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading borrowed books: " + ex.Message);
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            if (cboBorrowedBooks.SelectedValue == null)
            {
                MessageBox.Show("Please select a book to return.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int transactionId = Convert.ToInt32(cboBorrowedBooks.SelectedValue);
                DateTime returnDate = dtpReturnDate.Value.Date;

                // Get book_id for this transaction
                string getBookQuery = $"SELECT book_id FROM borrowrecords WHERE transaction_id = {transactionId}";
                object bookIdObj = DatabaseHelper.ExecuteScalar(getBookQuery);
                int bookId = Convert.ToInt32(bookIdObj);

                // Update borrow record with return date
                string updateRecordQuery = $@"
                    UPDATE borrowrecords 
                    SET return_date = '{returnDate:yyyy-MM-dd}' 
                    WHERE transaction_id = {transactionId}";
                
                DatabaseHelper.ExecuteNonQuery(updateRecordQuery);

                // Update book availability
                string updateBookQuery = $"UPDATE books SET available = 1 WHERE book_id = {bookId}";
                DatabaseHelper.ExecuteNonQuery(updateBookQuery);

                // Check if the book was returned late
                string checkOverdueQuery = $@"
                    SELECT DATEDIFF(day, due_date, '{returnDate:yyyy-MM-dd}') 
                    FROM borrowrecords 
                    WHERE transaction_id = {transactionId}";
                
                object daysLate = DatabaseHelper.ExecuteScalar(checkOverdueQuery);
                int daysLateInt = Convert.ToInt32(daysLate);

                if (daysLateInt > 0)
                {
                    MessageBox.Show($"Book returned successfully!\n\n⚠️ This book was {daysLateInt} day(s) overdue.", 
                        "Success - Late Return", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("Book returned successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error returning book: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
