using static book_management_program.Util.MySql_Util;
using System;
using book_management_program.Model;
using book_management_program.Util;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;

namespace book_management_program.Manager
{
    class MemberManager : IMemberManager
    {

        private static MemberManager memberManager = new MemberManager();
        public static MemberManager Member
        {
            get { return memberManager; }
            set { memberManager = value; }
        }

        public void MemInfoInsert(Member member)
        {

            string sql = "INSERT INTO member (mem_nm, pw, phone_no, overdue) VALUES ('"
                + member.Mem_nm + "', '"
                + member.Pw + "', '"
                + member.Phone_no + "', '"
                + "2000-01-01"
                + "')";


            if (Instance.Insert_Sql(sql) == true)
            {
                MessageBox.Show("삽입 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삽입 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        public Member MemInfoLookup(string mem_nm)
        {
            Member member = new Member();
            string sql = $"SELECT mem_no, mem_nm FROM member WHERE mem_nm = '{mem_nm}' ;";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    member.Mem_no = result.GetInt32(0);
                    member.Mem_nm = result.GetString(1);
                }
            }
            return member;
        }

        public List<Issue> MemIssueList(int mem_no)
        {
            string sql = $"SELECT issue_no, mem_nm , issue_dt , issue_sub , issue_text FROM member WHERE mem_nm = '{mem_no}' ;";

            List<Issue> issues = new List<Issue>();

            Issue issue;

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

        public List<Member> MemList()
        {
            string sql = $"SELECT mem_nm, pw, mem_grade, phone_no FROM member ;";

            List<Member> members = new List<Member>();

            Member member;

            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    member = new Member();
                    member.Mem_nm = result.GetString(0);
                    member.Pw = result.GetString(1);
                    member.Mem_grade = result.GetString(2);
                    member.Phone_no = result.GetString(3);
                    members.Add(member);
                }
            }
            return members;
        }

        public bool MemLogin(string id, string password)
        {
            bool islogin = false;

            try
            {
                Member member = new Member();
                string sql = $"SELECT mem_nm, pw FROM member WHERE mem_nm = '{id}' ;";
                /*
                MySqlDataReader result = Instance.Select_Sql(sql);
                MessageBox.Show("id: " + id + "==" + result.GetString(0));
                MessageBox.Show("password: " + password + "==" + result.GetString(1));
                if (result.HasRows)
                {
                    MessageBox.Show("id: " + id + "==" + result.GetString(0));
                    MessageBox.Show("password: " + password + "==" + result.GetString(1));
                    if (id.Equals(result.GetString(0)) && password.Equals(result.GetString(1)))
                    {
                        member.Mem_nm = id;
                        member.Pw = password;
                        islogin = true;
                    }
                    else
                    {
                        islogin = false;
                    }
                }*/

                DataSet ds = MySql_Util.Instance.Select_Sqlw(sql);
                foreach (DataRow row in ds.Tables[0].Rows)
                {
                    if(password.Equals(row["pw"])) islogin = true;
                }
                return islogin;
            }
            catch(Exception e)
            {
                MessageBox.Show(e.ToString());
                return islogin;
            }

        }

        public List<Book> MemRentList(int mem_no)
        {
            List<Book> rentBooks = new List<Book>();
            Book book;

            string sql = $"SELECT isbn,cat_nm,author,pub,pub_dt,book_nm,rent_dt,return_dt " +
                $"FROM bookinfo,category,rental WHERE bookinfo.mem_nm={mem_no} && rental.mem_no= {mem_no} " +
                $" &&bookinfo.cat_no = category.cat_no ;";


            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    book = new Book();
                    book.Isbn = result.GetString(0);
                    book.Cat_nm = result.GetString(1);
                    book.Author = result.GetString(2);
                    book.Pub = result.GetString(3);
                    book.Pub_dt = result.GetDateTime(4);
                    book.Book_nm = result.GetString(5);
                    book.Rent_dt = result.GetDateTime(6);
                    book.Return_dt = result.GetDateTime(7);


                    rentBooks.Add(book);
                }

            }
            return rentBooks;
        }

        public int MemRentListCnt(int mem_no)
        {
            int count = 0;
            string sql = $" SELECT count(*) FROM rental WHERE mem_no = {mem_no} && return_dt IS NULL ;";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);
            if (result.HasRows)
            {
                count = result.GetInt32(0);
            }
            return count;
        }

        public List<Book> MemResvList(int mem_no)
        {
            List<Book> resvBooks = new List<Book>();
            Book book;

            string sql = $"SELECT isbn,cat_nm,author,pub,pub_dt,book_nm,stock " +
                $"FROM bookinfo,category WHERE bookinfo.mem_no={mem_no}  " +
                $"&& bookinfo.cat_no = category.cat_no ;";


            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    book = new Book();
                    book.Isbn = result.GetString(0);
                    book.Cat_nm = result.GetString(1);
                    book.Author = result.GetString(2);
                    book.Pub = result.GetString(3);
                    book.Pub_dt = result.GetDateTime(4);
                    book.Book_nm = result.GetString(5);
                    if (result.GetInt32(6) == 0)
                    {
                        book.Rent_ck = "No";
                    }
                    else
                    {
                        book.Rent_ck = "Yes";
                    }

                    resvBooks.Add(book);
                }

            }
            return resvBooks;
        }

        public int memResvListcnt(int mem_no)
        {
            int count = 0;
            string sql = $" SELECT count(*) FROM reserve WHERE mem_no = {mem_no}  ;";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);
            if (result.HasRows)
            {
                count = result.GetInt32(0);
            }
            return count;
        }


        //string sql = "SELECT * FROM conntest;"
        //MySql_Util.Instance.Select_Sql(sql);

    }
}
