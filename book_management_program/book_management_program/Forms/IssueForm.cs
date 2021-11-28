using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_management_program.Forms
{
    public partial class IssueForm : Form
    {
        public IssueForm()
        {
            InitializeComponent();
        }

        private void issue_write_btn_Click(object sender, EventArgs e)
        {
            IssueWriteForm issue_write = new IssueWriteForm();
            issue_write.ShowDialog();
        }
    }
}
