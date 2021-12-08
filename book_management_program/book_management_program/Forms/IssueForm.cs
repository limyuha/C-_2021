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
    public partial class IssueForm : Form
    {
        int isChecked = 0; //1:전체, 0:내가 쓴 글 불러오기

        public IssueForm()
        {
            InitializeComponent();

            List<Issue>  issues = IssueManager.Issue.IssueList();
            IssueListView(issues);
        }

        /* 게시글 불러오기 */
        private void IssueListView(List<Issue> issues)
        {
            this.issue_listView.Items.Clear();
            foreach (var issue in issues)
            {
                string[] row = { issue.Issue_no.ToString(), issue.Issue_dt.ToString("yyyy-MM-dd HH:mm:ss"), issue.Mem_nm.ToString(), issue.Issue_title };
                var lvItem = new ListViewItem(row);
                this.issue_listView.Items.Add(lvItem);
            }
        }

        /* 글 작성 버튼 */
        private void issue_write_btn_Click(object sender, EventArgs e)
        {
            IssueWriteForm issue_write = new IssueWriteForm();
            if (issue_write.ShowDialog() == DialogResult.OK)
            {
                //회원 게시글 불러오기
                List<Issue> issues = MemberManager.Member.MemIssueList(MainForm.Mem_no);
                IssueListView(issues);

                button1.Text = "전체 글 보기";
                isChecked = 0;
            }
        }

        /* 내가 작성한 글 보기 버튼 */
        private void button1_Click(object sender, EventArgs e)
        {

            if (isChecked == 0)
            {
                //회원 게시글 불러오기
                List<Issue> issues = MemberManager.Member.MemIssueList(MainForm.Mem_no);
                IssueListView(issues);

                button1.Text = "전체 글 보기";
                isChecked = 1;
            }
            else
            {
                //전체 게시글 불러오기
                List<Issue> issues = IssueManager.Issue.IssueList();
                IssueListView(issues);

                button1.Text = "내가 작성한 글 보기";
                isChecked = 0;
            }
        }

        /* 선택된 글 내용 보기 */
        private void issue_listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.issue_listView.SelectedItems.Count > 0)
            {
                //MessageBox.Show(this.issue_listView.SelectedItems[0].SubItems[0].ToString() );
                int num = int.Parse (this.issue_listView.SelectedItems[0].SubItems[0].Text); // issue_no
                IssueDetailForm issueDetailForm = new IssueDetailForm(num);
                issueDetailForm.ShowDialog();
            }
        }
    }
}
