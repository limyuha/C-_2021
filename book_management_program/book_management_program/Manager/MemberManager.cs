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

        /* 회원 가입 */
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


        /* 회원 정보 조회 */
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

        /* 회원의 작성 글 목록 */
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
                    issue.Mem_no = result.GetInt32(1);
                    issue.Issue_dt = result.GetDateTime(2);
                    issue.Issue_title = result.GetString(3);
                    issue.Issue_text = result.GetString(4);
                    issues.Add(issue);
                }
            }
            return issues;
        }

        /* 회원 목록 */
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

        /* 회원 로그인 */
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

        /* 회원의 대여 도서 목록 */
        public List<Book> MemRentList(int mem_no)
        {
            List<Book> rentBooks = new List<Book>();
            Book book;

            string sql = $"SELECT rent_no, rental.isbn, cat_nm, author, pub,pub_dt, book_nm, rent_dt, return_dt " +
                $"FROM bookinfo,category,rental WHERE rental.mem_no= {mem_no}" +
                $"&& rental.isbn = bookinfo.isbn &&bookinfo.cat_no = category.cat_no &&rental.return_dt='2000-01-01';";



            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    book = new Book();
                    book.Rent_no = result.GetInt32(0);
                    book.Isbn = result.GetString(1);
                    book.Cat_nm = result.GetString(2);
                    book.Author = result.GetString(3);
                    book.Pub = result.GetString(4);
                    book.Pub_dt = result.GetDateTime(5);
                    book.Book_nm = result.GetString(6);
                    book.Rent_dt = result.GetDateTime(7);
                    book.Return_dt = result.GetDateTime(8);


                    rentBooks.Add(book);
                }

            }
            return rentBooks;
        }

        /* 회원 대여 도서 개수 */
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

        /* 회원 예약 도서 목록 */
        public List<Book> MemResvList(int mem_no)
        {
            List<Book> resvBooks = new List<Book>();
            Book book;

            string sql = $"SELECT reserve.isbn,cat_nm,author,pub,pub_dt,book_nm,stock " +
                $"FROM bookinfo,category,reserve WHERE reserve.mem_no={mem_no}" +
                $"&& reserve.isbn = bookinfo.isbn&& bookinfo.cat_no = category.cat_no ;";


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
                        book.Rent_ck = "대여불가";
                    }
                    else
                    {
                        book.Rent_ck = "재고있음";
                    }

                    resvBooks.Add(book);
                }

            }
            return resvBooks;
        }

        /* 회원 예약 도서 개수 */
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


        /* 1. 회원 대여 목록 연체 검사 - 처리 >> 로그인 시, 반납 시 */
        public void MemOverdueCheck(int mem_no)
        {
            MessageBox.Show("회원번호 : " + mem_no, "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //return_dt 반납일이 if ("2000-01-01 오전 12:00:00" != result.GetString(0)) 기본값이 아니면 "반납 완료"
            //기본값 2000-01-01 "대여중" 일 때
            //2.연체된 책 검사
            //그중 가장 오래된 연체로 연체일 지정

            String todayDt = System.DateTime.Now.ToString("yyyy-MM-dd"); //오늘 날짜
            MessageBox.Show("오늘 날짜 : " + todayDt, "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);

            int over = 0; //연체 일 수
            //도서 대여 목록 - rent_dt & return_dt 목록 가져오기
            String sql_overcheck = $"SELECT rent_no, rent_dt, return_dt FROM rental WHERE mem_no={mem_no};";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_overcheck);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    String rentDt = result.GetString(1); //대여 날짜
                    MessageBox.Show("대여 번호 : " + result.GetString(0) + "대여 날짜 : " + rentDt + ", 반납 여부 : " + result.GetString(2));

                    if ("2000-01-01 오전 12:00:00" == result.GetString(2)) //"대여중"인 도서에서 == "반납 안한" 도서 
                    {
                        /* 연체일 체크 */
                        String sql_over = $"SELECT TIMESTAMPDIFF(DAY, '{rentDt}', '{todayDt}');"; // if(결과 > 0) = 연체일
                        MySqlDataReader overresult = MySql_Util.Instance.Select_Sql(sql_over);
                        if (overresult.HasRows)
                        {
                            while (overresult.Read())
                            {
                                if (overresult.GetInt32(0) - 7 > over)
                                {
                                    over = overresult.GetInt32(0) - 7;
                                    MessageBox.Show("연체일 검사 : " + over);
                                }
                            }
                        }
                    }
                }
                MessageBox.Show("*최종 반납 연체일 : " + over, "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (over > 0) // 도서목록에 연체 있음
            {
                /* 회원 연체일 업데이트 */
                String overdueDt = System.DateTime.Now.AddDays(over).ToString("yyyy-MM-dd");

                //현재 회원 연체일 조회
               String sql_memoverdue = $"SELECT overdue FROM member WHERE mem_no={mem_no};";
                MySqlDataReader result2 = MySql_Util.Instance.Select_Sql(sql_memoverdue);
                if (result2.HasRows)
                {
                    while (result2.Read())
                    {
                        MessageBox.Show("기존 회원 연체일 : " + result2.GetString(0) + "\n변경 연체일 : " + overdueDt);
                        /* 회원 연체일 업데이트 */
                        // 현재 연채일 < 새로운 연체일
                        if (string.Compare(result2.GetString(0), overdueDt) < 0)
                        {
                            String sql = $"Update member Set overdue='{overdueDt}' where mem_no={mem_no}";
                            MySql_Util.Instance.Update_Sql(sql);
                            MessageBox.Show("연체일 변경\n연체일 : " + overdueDt, "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
        }

        /* 2. 회원 연체 상태 체크 >> 로그인 시, 대여 시 */
        public bool MemOverdueUpdate(int mem_no)
        {
            bool isOver = false;

            String sql_overcheck = $"SELECT overdue FROM member WHERE mem_no={mem_no};";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_overcheck);
            if (result.HasRows) //NullReferenceException
            {
                while (result.Read())
                {
                    MessageBox.Show(result.GetString(0));

                    if ("2000-01-01 오전 12:00:00" == result.GetString(0))
                    {
                        isOver = true; //연체 아님 - 대여 가능
                        break;
                    }
                    else
                    {
                        //연체중 - 대여 불가
                        /* overdue 업데이트 검사 */
                        String todayDt = System.DateTime.Now.ToString("yyyy-MM-dd"); //오늘 날짜
                        if (string.Compare(todayDt, result.GetString(0)) > 0) // 연체일 < 현재 : 연체 풀림 true
                        {
                            string sql = $"UPDATE member SET overdue='2000-01-01' WHERE mem_no = {mem_no}; ";
                            if (MySql_Util.Instance.Update_Sql(sql))
                            {
                                MessageBox.Show("연체 풀림", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                isOver = true;
                                break;
                            }
                            else
                            {
                                MessageBox.Show("연체 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else //연체일 > 현재 : 연체 중 false
                        {
                            MessageBox.Show("연체중", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isOver = false;
                            break;
                        }
                    }
                }
                return isOver;
            }
            else
            {
                return isOver;
            }
        }


    }
}
