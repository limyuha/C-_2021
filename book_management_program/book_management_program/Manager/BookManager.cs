using book_management_program.Model;
using book_management_program.Util;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace book_management_program.Manager
{
    class BookManager : IBookManager
    {
        private static BookManager bookManager = new BookManager();
        public static BookManager Book
        {
            get { return bookManager; }
            set { bookManager = value; }
        }

        public int BookCount()
        {
            string sql = "SELECT stock FROM bookinfo ;";
            int count = 0;

            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    count += result.GetInt32(0);
                }

            }
            return count;
        }

        // BookManager.cs 도서 삭제 버튼 기능
        public void BookInfoDelete(string isbn)
        {
            string sql = "DELETE FROM bookinfo WHERE isbn = " + isbn;

            if (MySql_Util.Instance.Delete_Sql(sql) == true)
            {
                MessageBox.Show("삭제 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("삭제 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        // BookManager.cs 도서 등록 버튼 기능
        public void BookInfoInsert(Book book)
        {
            string sql = "INSERT INTO bookinfo (isbn, book_nm, author, pub, stock) VALUES ('"
                + book.Isbn + "', '"
                + book.Book_nm + "', '"
                + book.Author + "', '"
                + book.Pub + "', '"
                + book.Stock + "')";

            if (MySql_Util.Instance.Insert_Sql(sql) == true)
            {
                MessageBox.Show("등록 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("등록 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // BookManager.cs 도서 리스트 기능
        public List<Book> BookInfoList()
        {
            string sql = "SELECT isbn, cat_nm, author, pub, pub_dt, book_nm, stock FROM bookinfo,category WHERE bookinfo.cat_no = category.cat_no;";

            List<Book> books = new List<Book>();

            Book book;

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
                    book.Stock = result.GetInt32(6);
                    books.Add(book);
                }
            }
            return books;
        }

        public void BookInfoUpdate(Book book)
        {
            string sql = "UPDATE bookinfo SET book_nm = '" +
                book.Book_nm + "', author = '" +
                book.Author + "', pub = '" +
                book.Pub + "', stock = '" +
                book.Stock + "' WHERE isbn = '" + book.Isbn + "'";

            if (MySql_Util.Instance.Update_Sql(sql) == true)
            {
                MessageBox.Show("수정 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("수정 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        public void BookRent(int mem_no, string isbn)
        {

            //재고 -1 update  , rental테이블에 insert
            //한번에 여러개 대여는?

            string sql = $"INSERT INTO rental VALUES(NULL , '{isbn}' , {mem_no} , '{System.DateTime.Today.ToShortDateString()}', NULL , 'N' ;";
            List<Book> books = BookSearch("isbn", isbn);
            string temp = books[6].ToString();
            int stock = int.Parse(temp) - 1;
            string sql2 = $"UPDATE bookinfo SET stock={stock} WHERE  isbn= '{isbn}'; ";

            if (MySql_Util.Instance.Insert_Sql(sql) == true && MySql_Util.Instance.Update_Sql(sql2) == true)
            {
                MessageBox.Show("반납 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("반납 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Book> BookRentRanking()
        {
            string sql = $"SELECT count(*) count , isbn,book_nm,author,pub FROM bookinfo group by isbn order by count ; ";

            List<Book> books = new List<Book>();
            Book book;
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    book = new Book();

                    book.Isbn = result.GetString(1);
                    book.Book_nm = result.GetString(2);
                    book.Author = result.GetString(3);
                    book.Pub = result.GetString(4);
                    books.Add(book);

                }

            }
            return books;
        }

        /*
        public void BookResvCancel(string mem_no, string isbn)
        {
            string sql = $"DELETE FROM reserve WHERE mem_no ='{mem_no}' && isbn='{isbn}' ;  ";

            if (MySql_Util.Instance.Delete_Sql(sql) == true)
            {
                MessageBox.Show("취소 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("취소 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/

        /*
        public void BookResvUpdate(string mem_no, string isbn)
        {

            string sql = $"UPDATE reserve SET res_dt='{System.DateTime.Now}' WHERE mem_no = '{mem_no}' , isbn= '{isbn}'; ";

            if (MySql_Util.Instance.Update_Sql(sql) == true)
            {
                MessageBox.Show("수정 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("수정 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }*/

        public void BookReturn(int mem_no, string isbn)
        {
            //rental update , bookinfo 재고 + 1
            //의논필요
            string sql = $"UPDATE rental SET return_dt='{System.DateTime.Today.ToShortDateString()}' WHERE mem_no = {mem_no} , isbn= '{isbn}' ; ";
            List<Book> books = BookSearch("isbn", isbn);
            string temp = books[6].ToString();
            int stock = int.Parse(temp) + 1;
            string sql2 = $"UPDATE bookinfo SET stock={stock} WHERE  isbn= '{isbn}'; ";


            if (MySql_Util.Instance.Update_Sql(sql) == true && MySql_Util.Instance.Update_Sql(sql2) == true)
            {
                MessageBox.Show("반납 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("반납 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public List<Book> BookSearch(string type, string search)
        {
            List<Book> books = new List<Book>();
            Book book;

            string sql = $"SELECT isbn,cat_nm,author,pub,pub_dt,book_nm,stock FROM bookinfo,category WHERE {type} LIKE '%{search}%' && bookinfo.cat_no = category.cat_no;";


            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);
            MessageBox.Show(""+ result.HasRows);
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
                    book.Stock = result.GetInt32(6);
                    /*
                    //대여량
                    string sql2 = $"SELECT COUNT(rent_dt) FROM rental WHERE isbn = (SELECT isbn FROM bookinfo WHERE isbn = '{book.Isbn}' )  ;";
                    MySqlDataReader result2 = MySql_Util.Instance.Select_Sql(sql2);

                    if (result2.HasRows)
                    {
                        while (result2.Read())
                        {
                            book.Rent_cnt = result2.GetInt32(0);
                        }
                    }*/
                    books.Add(book);
                }

            }
            return books;
        }

        public string RentExtCheck(int mem_no, string isbn)
        {
            throw new NotImplementedException();
        }

        public void RentExtUpdate(int mem_no, string isbn)
        {
            //rental ext update
            string sql = $"UPDATE rental SET ext='Y' WHERE mem_no = {mem_no} , isbn= '{isbn}'; ";
            if (MySql_Util.Instance.Update_Sql(sql) == true)
            {
                MessageBox.Show("수정 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("수정 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void RentListDel(int mem_no, string isbn)
        {
            throw new NotImplementedException();
            //db에 삭제하면서 validate로 새로고침해도될듯?
        }

        public void RentListIn(int mem_no, string isbn)
        {
            List<Book> rentBooks = new List<Book>();
            Book book;

            string sql = $"SELECT isbn,cat_nm,author,pub,pub_dt,book_nm,rent_dt,return_dt " +
                $"FROM bookinfo,category,rental WHERE bookinfo.mem_no={mem_no} && rental.mem_no= {mem_no}" +
                $"&& rental.isbn = '{isbn}' &&bookinfo.cat_no = category.cat_no ;";


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
        }

        public bool ResvListDel(int mem_no, string isbn)
        {
            string sql = $"DELETE FROM reserve WHERE mem_no = {mem_no} && isbn='{isbn}' ;  ";

            if (MySql_Util.Instance.Delete_Sql(sql) == true)
            {
                MessageBox.Show("취소 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("취소 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            //db에 삭제하면서 validate로 새로고침해도될듯?
        }

        public bool MemResvCheck(int mem_no, string isbn)
        {
            /* 도서 예약 여부 확인 */
            String sql_listcheck = $"SELECT isbn FROM reserve WHERE mem_no={mem_no} && isbn='{isbn}';";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_listcheck);
            if (result.HasRows)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool ResvListIn(int mem_no, string isbn)
        {
            if(MemResvCheck(mem_no, isbn))
            {
                return false;
            }
            else
            {
                String strDt = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                string sql = $"INSERT INTO reserve VALUES({mem_no},'{isbn}', '{strDt}');";
                if (MySql_Util.Instance.Insert_Sql(sql))
                {
                    MessageBox.Show("예약 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("삽입 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            
        }

        public float TermRentAvg()
        {
            string dt1Mm = DateTime.Now.AddMonths(-1).ToShortDateString();
            string sql = $"SELECT rent_dt FROM rental  ; ";
            float rentAvg = 0;


            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    string cp2 = result.GetString(0);
                    if (string.Compare(cp2, dt1Mm) >= 0) //한달전(30일전)부터 지금까지중에 대여일자가 있으면
                    {
                        rentAvg += 1;
                    }
                }
                rentAvg = rentAvg / 30;
            }
            return rentAvg;
        }

        public int TodayRentSum()
        {
            string sql = $"SELECT COUNT(*) FROM rental WHERE rent_dt = '{System.DateTime.Today.ToShortDateString()}' ; ";
            int rentSum = 0;


            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    rentSum = result.GetInt32(0);
                }
            }
            return rentSum;
        }
    }
}
