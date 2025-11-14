using System;
using System.Data;
using System.Windows.Forms;

namespace LibraryManagementSystem
{
    public partial class OverdueForm : Form
    {
        public OverdueForm(DataTable overdueData)
        {
            InitializeComponent();
            dgvOverdue.DataSource = overdueData;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
