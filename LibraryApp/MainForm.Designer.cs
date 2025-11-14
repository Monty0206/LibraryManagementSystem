namespace LibraryManagementSystem
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabBooks;
        private System.Windows.Forms.TabPage tabMembers;
        private System.Windows.Forms.TabPage tabBorrowRecords;
        private System.Windows.Forms.DataGridView dgvBooks;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.DataGridView dgvBorrowRecords;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnAddMember;
        private System.Windows.Forms.Button btnBorrowBook;
        private System.Windows.Forms.Button btnReturnBook;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Label lblTotalBooks;
        private System.Windows.Forms.Label lblAvailableBooks;
        private System.Windows.Forms.Label lblBorrowedBooks;
        private System.Windows.Forms.Label lblTotalMembers;
        private System.Windows.Forms.Panel panelStats;
        private System.Windows.Forms.TextBox txtSearchBooks;
        private System.Windows.Forms.Button btnSearchBooks;
        private System.Windows.Forms.Button btnViewOverdue;

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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabBooks = new System.Windows.Forms.TabPage();
            this.tabMembers = new System.Windows.Forms.TabPage();
            this.tabBorrowRecords = new System.Windows.Forms.TabPage();
            this.dgvBooks = new System.Windows.Forms.DataGridView();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.dgvBorrowRecords = new System.Windows.Forms.DataGridView();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnAddMember = new System.Windows.Forms.Button();
            this.btnBorrowBook = new System.Windows.Forms.Button();
            this.btnReturnBook = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.lblTotalBooks = new System.Windows.Forms.Label();
            this.lblAvailableBooks = new System.Windows.Forms.Label();
            this.lblBorrowedBooks = new System.Windows.Forms.Label();
            this.lblTotalMembers = new System.Windows.Forms.Label();
            this.panelStats = new System.Windows.Forms.Panel();
            this.txtSearchBooks = new System.Windows.Forms.TextBox();
            this.btnSearchBooks = new System.Windows.Forms.Button();
            this.btnViewOverdue = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabBooks.SuspendLayout();
            this.tabMembers.SuspendLayout();
            this.tabBorrowRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRecords)).BeginInit();
            this.panelStats.SuspendLayout();
            this.SuspendLayout();
            
            // Main Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panelStats);
            this.Name = "MainForm";
            this.Text = "Library Management System - Montell Boks";
            this.Load += new System.EventHandler(this.MainForm_Load);
            
            // Statistics Panel
            this.panelStats.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panelStats.Controls.Add(this.lblTotalBooks);
            this.panelStats.Controls.Add(this.lblAvailableBooks);
            this.panelStats.Controls.Add(this.lblBorrowedBooks);
            this.panelStats.Controls.Add(this.lblTotalMembers);
            this.panelStats.Controls.Add(this.btnRefresh);
            this.panelStats.Controls.Add(this.btnViewOverdue);
            this.panelStats.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelStats.Location = new System.Drawing.Point(0, 0);
            this.panelStats.Name = "panelStats";
            this.panelStats.Size = new System.Drawing.Size(1200, 80);
            this.panelStats.TabIndex = 0;
            
            // Statistics Labels
            this.lblTotalBooks.AutoSize = true;
            this.lblTotalBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalBooks.Location = new System.Drawing.Point(20, 15);
            this.lblTotalBooks.Name = "lblTotalBooks";
            this.lblTotalBooks.Size = new System.Drawing.Size(120, 20);
            this.lblTotalBooks.TabIndex = 0;
            this.lblTotalBooks.Text = "Total Books: 0";
            
            this.lblAvailableBooks.AutoSize = true;
            this.lblAvailableBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblAvailableBooks.Location = new System.Drawing.Point(20, 45);
            this.lblAvailableBooks.Name = "lblAvailableBooks";
            this.lblAvailableBooks.Size = new System.Drawing.Size(100, 20);
            this.lblAvailableBooks.TabIndex = 1;
            this.lblAvailableBooks.Text = "Available: 0";
            
            this.lblBorrowedBooks.AutoSize = true;
            this.lblBorrowedBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.lblBorrowedBooks.Location = new System.Drawing.Point(250, 45);
            this.lblBorrowedBooks.Name = "lblBorrowedBooks";
            this.lblBorrowedBooks.Size = new System.Drawing.Size(180, 20);
            this.lblBorrowedBooks.TabIndex = 2;
            this.lblBorrowedBooks.Text = "Currently Borrowed: 0";
            
            this.lblTotalMembers.AutoSize = true;
            this.lblTotalMembers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblTotalMembers.Location = new System.Drawing.Point(250, 15);
            this.lblTotalMembers.Name = "lblTotalMembers";
            this.lblTotalMembers.Size = new System.Drawing.Size(150, 20);
            this.lblTotalMembers.TabIndex = 3;
            this.lblTotalMembers.Text = "Total Members: 0";
            
            // Refresh Button
            this.btnRefresh.BackColor = System.Drawing.Color.LightGreen;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnRefresh.Location = new System.Drawing.Point(1050, 15);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(120, 50);
            this.btnRefresh.TabIndex = 4;
            this.btnRefresh.Text = "🔄 Refresh";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            
            // View Overdue Button
            this.btnViewOverdue.BackColor = System.Drawing.Color.LightCoral;
            this.btnViewOverdue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnViewOverdue.Location = new System.Drawing.Point(900, 15);
            this.btnViewOverdue.Name = "btnViewOverdue";
            this.btnViewOverdue.Size = new System.Drawing.Size(130, 50);
            this.btnViewOverdue.TabIndex = 5;
            this.btnViewOverdue.Text = "⚠️ View Overdue";
            this.btnViewOverdue.UseVisualStyleBackColor = false;
            this.btnViewOverdue.Click += new System.EventHandler(this.btnViewOverdue_Click);
            
            // Tab Control
            this.tabControl1.Controls.Add(this.tabBooks);
            this.tabControl1.Controls.Add(this.tabMembers);
            this.tabControl1.Controls.Add(this.tabBorrowRecords);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.tabControl1.Location = new System.Drawing.Point(0, 80);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1200, 620);
            this.tabControl1.TabIndex = 1;
            
            // Books Tab
            this.tabBooks.Controls.Add(this.dgvBooks);
            this.tabBooks.Controls.Add(this.txtSearchBooks);
            this.tabBooks.Controls.Add(this.btnSearchBooks);
            this.tabBooks.Controls.Add(this.btnAddBook);
            this.tabBooks.Location = new System.Drawing.Point(4, 29);
            this.tabBooks.Name = "tabBooks";
            this.tabBooks.Padding = new System.Windows.Forms.Padding(3);
            this.tabBooks.Size = new System.Drawing.Size(1192, 587);
            this.tabBooks.TabIndex = 0;
            this.tabBooks.Text = "📚 Books";
            this.tabBooks.UseVisualStyleBackColor = true;
            
            // Books DataGridView
            this.dgvBooks.AllowUserToAddRows = false;
            this.dgvBooks.AllowUserToDeleteRows = false;
            this.dgvBooks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBooks.Location = new System.Drawing.Point(10, 60);
            this.dgvBooks.Name = "dgvBooks";
            this.dgvBooks.ReadOnly = true;
            this.dgvBooks.RowHeadersWidth = 51;
            this.dgvBooks.RowTemplate.Height = 24;
            this.dgvBooks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBooks.Size = new System.Drawing.Size(1170, 460);
            this.dgvBooks.TabIndex = 0;
            
            // Search Books TextBox
            this.txtSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtSearchBooks.Location = new System.Drawing.Point(10, 15);
            this.txtSearchBooks.Name = "txtSearchBooks";
            this.txtSearchBooks.Size = new System.Drawing.Size(300, 26);
            this.txtSearchBooks.TabIndex = 1;
            this.txtSearchBooks.Text = "Search books...";
            
            // Search Books Button
            this.btnSearchBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.btnSearchBooks.Location = new System.Drawing.Point(320, 12);
            this.btnSearchBooks.Name = "btnSearchBooks";
            this.btnSearchBooks.Size = new System.Drawing.Size(100, 32);
            this.btnSearchBooks.TabIndex = 2;
            this.btnSearchBooks.Text = "🔍 Search";
            this.btnSearchBooks.UseVisualStyleBackColor = true;
            this.btnSearchBooks.Click += new System.EventHandler(this.btnSearchBooks_Click);
            
            // Add Book Button
            this.btnAddBook.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBook.Location = new System.Drawing.Point(10, 530);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(150, 45);
            this.btnAddBook.TabIndex = 3;
            this.btnAddBook.Text = "➕ Add Book";
            this.btnAddBook.UseVisualStyleBackColor = false;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            
            // Members Tab
            this.tabMembers.Controls.Add(this.dgvMembers);
            this.tabMembers.Controls.Add(this.btnAddMember);
            this.tabMembers.Location = new System.Drawing.Point(4, 29);
            this.tabMembers.Name = "tabMembers";
            this.tabMembers.Padding = new System.Windows.Forms.Padding(3);
            this.tabMembers.Size = new System.Drawing.Size(1192, 587);
            this.tabMembers.TabIndex = 1;
            this.tabMembers.Text = "👥 Members";
            this.tabMembers.UseVisualStyleBackColor = true;
            
            // Members DataGridView
            this.dgvMembers.AllowUserToAddRows = false;
            this.dgvMembers.AllowUserToDeleteRows = false;
            this.dgvMembers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Location = new System.Drawing.Point(10, 15);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.ReadOnly = true;
            this.dgvMembers.RowHeadersWidth = 51;
            this.dgvMembers.RowTemplate.Height = 24;
            this.dgvMembers.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMembers.Size = new System.Drawing.Size(1170, 505);
            this.dgvMembers.TabIndex = 0;
            
            // Add Member Button
            this.btnAddMember.BackColor = System.Drawing.Color.LightGreen;
            this.btnAddMember.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddMember.Location = new System.Drawing.Point(10, 530);
            this.btnAddMember.Name = "btnAddMember";
            this.btnAddMember.Size = new System.Drawing.Size(150, 45);
            this.btnAddMember.TabIndex = 1;
            this.btnAddMember.Text = "➕ Add Member";
            this.btnAddMember.UseVisualStyleBackColor = false;
            this.btnAddMember.Click += new System.EventHandler(this.btnAddMember_Click);
            
            // Borrow Records Tab
            this.tabBorrowRecords.Controls.Add(this.dgvBorrowRecords);
            this.tabBorrowRecords.Controls.Add(this.btnBorrowBook);
            this.tabBorrowRecords.Controls.Add(this.btnReturnBook);
            this.tabBorrowRecords.Location = new System.Drawing.Point(4, 29);
            this.tabBorrowRecords.Name = "tabBorrowRecords";
            this.tabBorrowRecords.Size = new System.Drawing.Size(1192, 587);
            this.tabBorrowRecords.TabIndex = 2;
            this.tabBorrowRecords.Text = "📖 Borrow Records";
            this.tabBorrowRecords.UseVisualStyleBackColor = true;
            
            // Borrow Records DataGridView
            this.dgvBorrowRecords.AllowUserToAddRows = false;
            this.dgvBorrowRecords.AllowUserToDeleteRows = false;
            this.dgvBorrowRecords.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvBorrowRecords.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBorrowRecords.Location = new System.Drawing.Point(10, 15);
            this.dgvBorrowRecords.Name = "dgvBorrowRecords";
            this.dgvBorrowRecords.ReadOnly = true;
            this.dgvBorrowRecords.RowHeadersWidth = 51;
            this.dgvBorrowRecords.RowTemplate.Height = 24;
            this.dgvBorrowRecords.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvBorrowRecords.Size = new System.Drawing.Size(1170, 505);
            this.dgvBorrowRecords.TabIndex = 0;
            
            // Borrow Book Button
            this.btnBorrowBook.BackColor = System.Drawing.Color.LightBlue;
            this.btnBorrowBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnBorrowBook.Location = new System.Drawing.Point(10, 530);
            this.btnBorrowBook.Name = "btnBorrowBook";
            this.btnBorrowBook.Size = new System.Drawing.Size(150, 45);
            this.btnBorrowBook.TabIndex = 1;
            this.btnBorrowBook.Text = "📤 Borrow Book";
            this.btnBorrowBook.UseVisualStyleBackColor = false;
            this.btnBorrowBook.Click += new System.EventHandler(this.btnBorrowBook_Click);
            
            // Return Book Button
            this.btnReturnBook.BackColor = System.Drawing.Color.LightCoral;
            this.btnReturnBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btnReturnBook.Location = new System.Drawing.Point(180, 530);
            this.btnReturnBook.Name = "btnReturnBook";
            this.btnReturnBook.Size = new System.Drawing.Size(150, 45);
            this.btnReturnBook.TabIndex = 2;
            this.btnReturnBook.Text = "📥 Return Book";
            this.btnReturnBook.UseVisualStyleBackColor = false;
            this.btnReturnBook.Click += new System.EventHandler(this.btnReturnBook_Click);
            
            this.tabControl1.ResumeLayout(false);
            this.tabBooks.ResumeLayout(false);
            this.tabBooks.PerformLayout();
            this.tabMembers.ResumeLayout(false);
            this.tabBorrowRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBooks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBorrowRecords)).EndInit();
            this.panelStats.ResumeLayout(false);
            this.panelStats.PerformLayout();
            this.ResumeLayout(false);
        }
    }
}
