using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class BorrowBookForm : Form
    {
        public BorrowBookForm()
        {
            InitializeComponent();
            LoadAvailableBooks();
            LoadMembers();
        }

        private void LoadAvailableBooks()
        {
            try
            {
                string query = "SELECT book_id, title + ' by ' + author as DisplayText FROM books WHERE available = 1 ORDER BY title";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                
                cboBooks.DisplayMember = "DisplayText";
                cboBooks.ValueMember = "book_id";
                cboBooks.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading books: " + ex.Message);
            }
        }

        private void LoadMembers()
        {
            try
            {
                string query = "SELECT member_id, name + ' (' + email + ')' as DisplayText FROM members ORDER BY name";
                DataTable dt = DatabaseHelper.ExecuteQuery(query);
                
                cboMembers.DisplayMember = "DisplayText";
                cboMembers.ValueMember = "member_id";
                cboMembers.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading members: " + ex.Message);
            }
        }

        private void btnBorrow_Click(object sender, EventArgs e)
        {
            if (cboBooks.SelectedValue == null)
            {
                MessageBox.Show("Please select a book.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cboMembers.SelectedValue == null)
            {
                MessageBox.Show("Please select a member.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int bookId = Convert.ToInt32(cboBooks.SelectedValue);
                int memberId = Convert.ToInt32(cboMembers.SelectedValue);
                DateTime borrowDate = dtpBorrowDate.Value.Date;
                DateTime dueDate = dtpDueDate.Value.Date;

                // Validate dates
                if (dueDate <= borrowDate)
                {
                    MessageBox.Show("Due date must be after borrow date.", "Validation Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Insert borrow record
                string insertQuery = $@"
                    INSERT INTO borrowrecords (book_id, member_id, borrow_date, due_date)
                    VALUES ({bookId}, {memberId}, '{borrowDate:yyyy-MM-dd}', '{dueDate:yyyy-MM-dd}')";
                
                DatabaseHelper.ExecuteNonQuery(insertQuery);

                // Update book availability
                string updateQuery = $"UPDATE books SET available = 0 WHERE book_id = {bookId}";
                DatabaseHelper.ExecuteNonQuery(updateQuery);

                MessageBox.Show("Book borrowed successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error borrowing book: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void dtpBorrowDate_ValueChanged(object sender, EventArgs e)
        {
            // Automatically set due date to 14 days after borrow date
            dtpDueDate.Value = dtpBorrowDate.Value.AddDays(14);
        }
    }
}
