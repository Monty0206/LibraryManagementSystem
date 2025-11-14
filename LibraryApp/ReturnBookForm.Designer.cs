namespace LibraryManagementSystem
{
    partial class ReturnBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblReturnDate;
        private System.Windows.Forms.ComboBox cboBorrowedBooks;
        private System.Windows.Forms.DateTimePicker dtpReturnDate;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblBook = new System.Windows.Forms.Label();
            this.lblReturnDate = new System.Windows.Forms.Label();
            this.cboBorrowedBooks = new System.Windows.Forms.ComboBox();
            this.dtpReturnDate = new System.Windows.Forms.DateTimePicker();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // lblBook
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBook.Location = new System.Drawing.Point(30, 30);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(123, 20);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Borrowed Book:";
            
            // cboBorrowedBooks
            this.cboBorrowedBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboBorrowedBooks.FormattingEnabled = true;
            this.cboBorrowedBooks.Location = new System.Drawing.Point(170, 27);
            this.cboBorrowedBooks.Name = "cboBorrowedBooks";
            this.cboBorrowedBooks.Size = new System.Drawing.Size(400, 28);
            this.cboBorrowedBooks.TabIndex = 1;
            
            // lblReturnDate
            this.lblReturnDate.AutoSize = true;
            this.lblReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblReturnDate.Location = new System.Drawing.Point(30, 80);
            this.lblReturnDate.Name = "lblReturnDate";
            this.lblReturnDate.Size = new System.Drawing.Size(106, 20);
            this.lblReturnDate.TabIndex = 2;
            this.lblReturnDate.Text = "Return Date:";
            
            // dtpReturnDate
            this.dtpReturnDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpReturnDate.Location = new System.Drawing.Point(170, 77);
            this.dtpReturnDate.Name = "dtpReturnDate";
            this.dtpReturnDate.Size = new System.Drawing.Size(250, 26);
            this.dtpReturnDate.TabIndex = 3;
            
            // btnReturn
            this.btnReturn.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturn.Location = new System.Drawing.Point(170, 135);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 40);
            this.btnReturn.TabIndex = 4;
            this.btnReturn.Text = "📥 Return";
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            
            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(340, 135);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "❌ Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            // ReturnBookForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 206);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.dtpReturnDate);
            this.Controls.Add(this.lblReturnDate);
            this.Controls.Add(this.cboBorrowedBooks);
            this.Controls.Add(this.lblBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReturnBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Return a Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
