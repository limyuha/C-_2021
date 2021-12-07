using book_management_program.Manager;
using book_management_program.Model;
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
    public partial class IssueDetailForm : Form
    {
        public IssueDetailForm(int num)
        {
            InitializeComponent();

            Issue issue = IssueManager.Issue.IssueSelect(num);
            title_textBox.Text = issue.Issue_title;
            context_textBox.Text = issue.Issue_text;
        }
    }
}
