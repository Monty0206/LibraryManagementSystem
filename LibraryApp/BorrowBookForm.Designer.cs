namespace LibraryManagementSystem
{
    partial class BorrowBookForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBook;
        private System.Windows.Forms.Label lblMember;
        private System.Windows.Forms.Label lblBorrowDate;
        private System.Windows.Forms.Label lblDueDate;
        private System.Windows.Forms.ComboBox cboBooks;
        private System.Windows.Forms.ComboBox cboMembers;
        private System.Windows.Forms.DateTimePicker dtpBorrowDate;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnBorrow;
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
            this.lblMember = new System.Windows.Forms.Label();
            this.lblBorrowDate = new System.Windows.Forms.Label();
            this.lblDueDate = new System.Windows.Forms.Label();
            this.cboBooks = new System.Windows.Forms.ComboBox();
            this.cboMembers = new System.Windows.Forms.ComboBox();
            this.dtpBorrowDate = new System.Windows.Forms.DateTimePicker();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnBorrow = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            
            // lblBook
            this.lblBook.AutoSize = true;
            this.lblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBook.Location = new System.Drawing.Point(30, 30);
            this.lblBook.Name = "lblBook";
            this.lblBook.Size = new System.Drawing.Size(53, 20);
            this.lblBook.TabIndex = 0;
            this.lblBook.Text = "Book:";
            
            // cboBooks
            this.cboBooks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboBooks.FormattingEnabled = true;
            this.cboBooks.Location = new System.Drawing.Point(150, 27);
            this.cboBooks.Name = "cboBooks";
            this.cboBooks.Size = new System.Drawing.Size(400, 28);
            this.cboBooks.TabIndex = 1;
            
            // lblMember
            this.lblMember.AutoSize = true;
            this.lblMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblMember.Location = new System.Drawing.Point(30, 75);
            this.lblMember.Name = "lblMember";
            this.lblMember.Size = new System.Drawing.Size(74, 20);
            this.lblMember.TabIndex = 2;
            this.lblMember.Text = "Member:";
            
            // cboMembers
            this.cboMembers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cboMembers.FormattingEnabled = true;
            this.cboMembers.Location = new System.Drawing.Point(150, 72);
            this.cboMembers.Name = "cboMembers";
            this.cboMembers.Size = new System.Drawing.Size(400, 28);
            this.cboMembers.TabIndex = 3;
            
            // lblBorrowDate
            this.lblBorrowDate.AutoSize = true;
            this.lblBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBorrowDate.Location = new System.Drawing.Point(30, 120);
            this.lblBorrowDate.Name = "lblBorrowDate";
            this.lblBorrowDate.Size = new System.Drawing.Size(109, 20);
            this.lblBorrowDate.TabIndex = 4;
            this.lblBorrowDate.Text = "Borrow Date:";
            
            // dtpBorrowDate
            this.dtpBorrowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpBorrowDate.Location = new System.Drawing.Point(150, 117);
            this.dtpBorrowDate.Name = "dtpBorrowDate";
            this.dtpBorrowDate.Size = new System.Drawing.Size(250, 26);
            this.dtpBorrowDate.TabIndex = 5;
            this.dtpBorrowDate.ValueChanged += new System.EventHandler(this.dtpBorrowDate_ValueChanged);
            
            // lblDueDate
            this.lblDueDate.AutoSize = true;
            this.lblDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblDueDate.Location = new System.Drawing.Point(30, 165);
            this.lblDueDate.Name = "lblDueDate";
            this.lblDueDate.Size = new System.Drawing.Size(86, 20);
            this.lblDueDate.TabIndex = 6;
            this.lblDueDate.Text = "Due Date:";
            
            // dtpDueDate
            this.dtpDueDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.dtpDueDate.Location = new System.Drawing.Point(150, 162);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(250, 26);
            this.dtpDueDate.TabIndex = 7;
            
            // btnBorrow
            this.btnBorrow.BackColor = System.Drawing.Color.LightBlue;
            this.btnBorrow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorrow.Location = new System.Drawing.Point(150, 220);
            this.btnBorrow.Name = "btnBorrow";
            this.btnBorrow.Size = new System.Drawing.Size(150, 40);
            this.btnBorrow.TabIndex = 8;
            this.btnBorrow.Text = "📤 Borrow";
            this.btnBorrow.UseVisualStyleBackColor = false;
            this.btnBorrow.Click += new System.EventHandler(this.btnBorrow_Click);
            
            // btnCancel
            this.btnCancel.BackColor = System.Drawing.Color.LightGray;
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnCancel.Location = new System.Drawing.Point(320, 220);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(120, 40);
            this.btnCancel.TabIndex = 9;
            this.btnCancel.Text = "❌ Cancel";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            
            // BorrowBookForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 291);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnBorrow);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.lblDueDate);
            this.Controls.Add(this.dtpBorrowDate);
            this.Controls.Add(this.lblBorrowDate);
            this.Controls.Add(this.cboMembers);
            this.Controls.Add(this.lblMember);
            this.Controls.Add(this.cboBooks);
            this.Controls.Add(this.lblBook);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BorrowBookForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Borrow a Book";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
