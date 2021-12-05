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
            set { issueManager = value; }
        }

        /* 글 삭제 */
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

        /* 글 등록 */
        public void IssueInsert(Issue issue)
        {
            string sql = $"INSERT INTO issue(mem_no, issue_dt, issue_title, issue_text) VALUES ({issue.Mem_no}, '{System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}' , '{issue.Issue_title}' , '{issue.Issue_text}' ) ;";

            if (MySql_Util.Instance.Update_Sql(sql) == true)
            {
                MessageBox.Show("삽입 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삽입 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /* 전체 글 목록 조회 */
        public List<Issue> IssueList()
        {
            string sql = "SELECT issue_no, Issue_dt, mem_nm, Issue_title FROM issue,member where issue.mem_no=member.mem_no ORDER BY issue_no";

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
                    issue.Issue_dt = result.GetDateTime(1);
                    issue.Mem_nm = result.GetString(2);
                    issue.Issue_title = result.GetString(3);
                    issues.Add(issue);
                }
            }
            return issues;
        }

        /* 회원 글 목록 조회 */
        public List<Issue> IssueList(int mem_no)
        {
            string sql = $"SELECT issue_no, Issue_dt, mem_nm, Issue_title FROM issue,member where issue.mem_no=member.mem_no && issue.mem_no={mem_no} ORDER BY issue_no";

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
                    issue.Issue_dt = result.GetDateTime(1);
                    issue.Mem_nm = result.GetString(2);
                    issue.Issue_title = result.GetString(3);
                    issues.Add(issue);
                }
            }
            return issues;
        }

        /* 글 내용 보기 */
        public Issue IssueSelect(int issue_no)
        {
            Issue issue = new Issue();

            string sql = $"SELECT issue_no, mem_nm, issue_dt, issue_title, issue_text FROM issue,member where issue.mem_no=member.mem_no &&issue_no={issue_no}";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    issue.Issue_no = result.GetInt32(0);
                    issue.Mem_nm = result.GetString(1);
                    issue.Issue_dt = result.GetDateTime(2);
                    issue.Issue_title = result.GetString(3);
                    issue.Issue_text = result.GetString(4);
                }
            }
            return issue;
        }
    }
}
