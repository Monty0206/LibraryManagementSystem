using System;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class AddBookForm : Form
    {
        public AddBookForm()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a book title.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTitle.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtAuthor.Text))
            {
                MessageBox.Show("Please enter an author name.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAuthor.Focus();
                return;
            }

            if (string.IsNullOrWhiteSpace(txtGenre.Text))
            {
                MessageBox.Show("Please enter a genre.", "Validation Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGenre.Focus();
                return;
            }

            try
            {
                string query = $@"
                    INSERT INTO books (title, author, genre, available)
                    VALUES ('{txtTitle.Text.Replace("'", "''")}', 
                            '{txtAuthor.Text.Replace("'", "''")}', 
                            '{txtGenre.Text.Replace("'", "''")}', 
                            1)";

                int result = DatabaseHelper.ExecuteNonQuery(query);

                if (result > 0)
                {
                    MessageBox.Show("Book added successfully!", "Success",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error adding book: " + ex.Message, "Error",
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
