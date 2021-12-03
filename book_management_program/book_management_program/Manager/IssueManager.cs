using book_management_program.Model;
using book_management_program.Util;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_management_program.Manager
{
    class IssueManager : IIssueManager
    {
        private static IssueManager issueManager = new IssueManager();
        public static IssueManager Issue
        {
            get { return issueManager; }
            set { Issue = issueManager; }
        }

        public void IssueDelete(int issue_no)
        {
            string sql = $"DELETE FROM issue WHERE issue_no ='{issue_no}' ;  ";

            if (MySql_Util.Instance.Delete_Sql(sql) == true)
            {
                MessageBox.Show("삭제 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void IssueInsert(Issue issue)
        {
            string sql = $"INSERT INTO issue VALUES ( '{issue.Issue_no}' , '{issue.Mem_nm}' , '{System.DateTime.Now.ToShortDateString()}' , " +
                $"'{issue.Issue_sub}' , '{issue.Issue_text}' ) ;";

            if (MySql_Util.Instance.Update_Sql(sql) == true)
            {
                MessageBox.Show("삽입 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삽입 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Issue> IssueList()
        {
            string sql = "SELECT isbn, book_nm, author, pub, stock FROM bookinfo";

            List<Issue> issues = new List<Issue>();

            Issue issue;
            Member member = new Member();

            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    issue = new Issue();
                    issue.Issue_no = result.GetInt32(0);
                    issue.Mem_nm = result.GetString(1);
                    issue.Issue_dt = result.GetDateTime(2);
                    issue.Issue_sub = result.GetString(3);
                    issue.Issue_text = result.GetString(4);
                    issues.Add(issue);
                }
            }
            return issues;
        }
    }
}
