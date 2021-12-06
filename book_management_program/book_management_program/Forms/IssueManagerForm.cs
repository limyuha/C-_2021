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
    public partial class IssueManagerForm : Form
    {
        public IssueManagerForm()
        {
            InitializeComponent();

            List<Issue> issues = IssueManager.Issue.IssueList();
            IssueListView(issues);
        }
        private void IssueListView(List<Issue> issues)
        {
            this.issue_manager_listView.Items.Clear();
            foreach (var issue in issues)
            {
                string[] row = { issue.Issue_no.ToString(), issue.Issue_dt.ToString("yyyy-MM-dd HH:mm:ss"), issue.Issue_title, issue.Mem_nm };
                var lvItem = new ListViewItem(row);
                this.issue_manager_listView.Items.Add(lvItem);
            }
        }
        /* 선택된 글 내용 보기 */
        private void issue_manager_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.issue_manager_listView.SelectedItems.Count > 0)
            {
                MessageBox.Show(this.issue_manager_listView.SelectedItems[0].SubItems[0].ToString());
                int num = int.Parse(this.issue_manager_listView.SelectedItems[0].SubItems[0].Text); // issue_no
                IssueDetailForm issueDetailForm = new IssueDetailForm(num);
                issueDetailForm.ShowDialog();
            }
        }

        private void issue_delete_btn_Click(object sender, EventArgs e)
        {
            IssueManager manager = new IssueManager();
            manager.IssueDelete(int.Parse(no_textBox.Text));
            List<Issue> issues = IssueManager.Issue.IssueList();
            IssueListView(issues);
        }

        //no_textBox





    }
}
