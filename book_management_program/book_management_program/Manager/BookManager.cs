using book_management_program.Model;
using book_management_program.Util;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Collections;

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

        /* 카테고리명 가져오기 - 도서관리폼 */
        public List<string> CategoryList()
        {
            List<string> catList = new List<string>();
            
            string sql = "SELECT cat_nm FROM category ;";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    catList.Add(result.GetString(0));
                }

            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return catList;
        }

        /* 장서량 */
        public int BookCount()
        {
            string sql = "SELECT stock FROM bookinfo ;";
            string sql2 = $"SELECT COUNT(*) FROM rental WHERE return_dt = '2000-01-01';";
            int count = 0;

            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    count += result.GetInt32(0);
                }

            }
            MySqlDataReader result2 = MySql_Util.Instance.Select_Sql(sql2);
            if (result2.HasRows)
            {
                while (result2.Read())
                {
                    count += result2.GetInt32(0);
                }

            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return count;
        }

        // BookManager.cs 도서 삭제 버튼 기능
        public bool BookInfoDelete(string isbn)
        {
            bool isDel = false;

            string sql = "DELETE FROM bookinfo WHERE isbn = " + isbn; //도서 정보 삭제
            String sql_listcheck = $"SELECT rent_no FROM rental WHERE isbn='{isbn}' && return_dt='2000-01-01';"; //대여 중 확인
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_listcheck);
            if (result.HasRows)
            {
                MessageBox.Show("삭제 에러 : 대여 중인 도서가 있습니다.", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                var msg = MessageBox.Show("삭제할까요? [ ISBN ] : " + isbn, "관리 메시지", MessageBoxButtons.YesNo);
                if (msg == DialogResult.Yes)
                {
                    if (MySql_Util.Instance.Update_Sql(sql))
                    {
                        MessageBox.Show("삭제 완료 : [ ISBN ] " + isbn, "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        isDel = true;
                    }
                    else
                    {
                        MessageBox.Show("삭제 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return isDel;
        }

        // BookManager.cs 도서 등록 버튼 기능
        public void BookInfoInsert(Book book)
        {
            string sql = $"INSERT INTO bookinfo (isbn,cat_no,book_nm,author,pub,pub_dt,stock) VALUES (" +
                $"'{book.Isbn}','{book.Cat_no}','{book.Book_nm}','{book.Author}','{book.Pub}','{System.DateTime.Now.ToString("yyyy-MM-dd")}','{book.Stock}'); ";

            if (MySql_Util.Instance.Update_Sql(sql) == true)
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
            string sql = "SELECT isbn, cat_nm, author, pub, pub_dt, book_nm, stock FROM bookinfo,category WHERE bookinfo.cat_no = category.cat_no order by book_nm;";

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
                    book.Pub_dt = result.GetString(4);
                    book.Book_nm = result.GetString(5);
                    book.Stock = result.GetInt32(6);
                    books.Add(book);
                }
            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            MySql_Util.Instance.sqlConn.Close();
            return books;
        }

        public List<Book> BookInfoListM()
        {
            string sql = "SELECT bookinfo.isbn, cat_nm, author, pub, pub_dt, book_nm, stock, COUNT(rent .isbn) FROM bookinfo left OUTER JOIN (SELECT * FROM rental where return_dt like '2000-01-01') rent ON bookinfo.isbn = rent.isbn INNER JOIN category ON bookinfo.cat_no = category.cat_no GROUP BY bookinfo.isbn, cat_nm, author, pub, pub_dt, book_nm, stock order by book_nm";

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
                    book.Pub_dt = result.GetString(4);
                    book.Book_nm = result.GetString(5);
                    book.Stock = result.GetInt32(6);
                    book.Rent_sum = result.GetInt32(7);
                    books.Add(book);
                }
            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return books;
        }


        //도서 정보 수정
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

        /* 도서 재고 확인 */
        public int RentStockCheck(string isbn)
        {
            int sum = 0;
            String sql_stockcheck = $"SELECT stock FROM bookinfo WHERE isbn='{isbn}';";
            MySqlDataReader stockresult = MySql_Util.Instance.Select_Sql(sql_stockcheck);
            if (stockresult.HasRows)
            {
                while (stockresult.Read())
                {
                    if (stockresult.GetInt32(0) > 0)
                    {
                        sum = stockresult.GetInt32(0);
                    }
                }
            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return sum;
        }

        /* 도서 대여 */
        public bool BookRent(int mem_no, string isbn)
        {
            //재고 -1 update  , rental테이블에 insert

            /* 재고 있을 때, 대여 가능 */
            if (RentStockCheck(isbn) > 0)
            {

                String todayDt = System.DateTime.Now.ToString("yyyy-MM-dd"); // 오늘 날짜
                string sql = $"INSERT INTO rental(isbn, mem_no, rent_dt, return_dt, ext) VALUES('{isbn}' , {mem_no} , '{todayDt}', '2000-01-01', 'N') ;";
               
                int stock = RentStockCheck(isbn) - 1; // 재고 -1
                string sql2 = $"UPDATE bookinfo SET stock={stock} WHERE isbn= '{isbn}'; ";
                if (MySql_Util.Instance.Update_Sql(sql) && MySql_Util.Instance.Update_Sql(sql2))
                {
                    MessageBox.Show("대여 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("대여 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("대여 에러 : 재고 없음", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /* 회원의 도서 대여 여부 확인 */
        public int MemRentCheck(int mem_no, string isbn)
        {
            int rent = 0;
            String sql_listcheck = $"SELECT rent_no FROM rental WHERE mem_no={mem_no} && isbn='{isbn}' && return_dt='2000-01-01' ORDER BY rent_dt ASC;";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_listcheck);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    //대여중
                    rent = result.GetInt32(0);
                    break;
                }
            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return rent;
        }

        /* 도서 반납 */
        public bool BookReturn(int mem_no, string isbn)
        {
            //rental update , bookinfo 재고 + 1

            String todayDt = System.DateTime.Now.ToString("yyyy-MM-dd"); // 오늘 날짜

            bool isSuccess = false;

            /* 반납 처리 */
            int rent_no = MemRentCheck(mem_no, isbn);
            if (rent_no > 0) //대여중일 때
            {
                //'가장 먼저 대여한 것' 하나만 반납
                string sql = $"UPDATE rental SET return_dt='{todayDt}'  WHERE rent_no = {rent_no}; ";
                if (MySql_Util.Instance.Update_Sql(sql))
                {
                    MessageBox.Show("반납 완료\n반납일 : " + todayDt, "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    isSuccess = true;
                }
                else
                {
                    MessageBox.Show("반납 에러 : sql", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    isSuccess = false;
                }

                /* 재고 처리 */
                int stock = RentStockCheck(isbn)+1;
                string sql2 = $"UPDATE bookinfo SET stock={stock} WHERE  isbn= '{isbn}'; ";

                if (isSuccess && MySql_Util.Instance.Update_Sql(sql2) == true)
                {
                    MessageBox.Show("반납 완료 : 재고 추가", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return true;
                }
                else
                {
                    MessageBox.Show("반납 에러 : 재고", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                MessageBox.Show("반납 에러 : 대여 정보 없음", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /* 도서 대여 순위 */
        public List<Book> BookRentRanking()
        {
            string sql = $"SELECT count(*) count , isbn,book_nm,author,pub FROM bookinfo group by isbn order by count limit 5; ";

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
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return books;
        }

        /* 도서 검색 */
        public List<Book> BookSearch(string type, string search)
        {
            List<Book> books = new List<Book>();
            Book book;

            string sql = $"SELECT isbn,cat_nm,author,pub,pub_dt,book_nm,stock FROM bookinfo,category WHERE {type} LIKE '%{search}%' && bookinfo.cat_no = category.cat_no;";

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
                    book.Pub_dt = result.GetString(4);
                    book.Book_nm = result.GetString(5);
                    book.Stock = result.GetInt32(6);
                    books.Add(book);
                }

            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return books;
        }

        /* 도서 대여 연장 */
        public bool RentExtUpdate(int mem_no, string isbn)
        {
            bool check = false;

            //rental ext update
            // 도서 연장 가능 여부 확인
            String sql_extcheck = $"SELECT rent_no, ext FROM rental WHERE mem_no={mem_no} && isbn='{isbn}' ORDER BY rent_dt ASC;";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_extcheck);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (result.GetString(1)=="N")
                    {
                        String todayDt = System.DateTime.Now.ToString("yyyy-MM-dd"); // 오늘 날짜
                        string sql = $"UPDATE rental SET ext='Y', rent_dt='{todayDt}' WHERE rent_no = {result.GetInt32(0)}; ";
                        if (MySql_Util.Instance.Update_Sql(sql) == true)
                        {
                            MessageBox.Show("연장 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
                            return true;
                        }
                    }
                }
                MessageBox.Show("연장 불가", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("연장 조회 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return check;
        }


        /* 예약 취소 */
        public bool ResvListDel(int mem_no, string isbn)
        {
            string sql = $"DELETE FROM reserve WHERE mem_no = {mem_no} && isbn='{isbn}' ;  ";

            if (MySql_Util.Instance.Update_Sql(sql) == true)
            {
                MessageBox.Show("취소 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return true;
            }
            else
            {
                MessageBox.Show("취소 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /* 도서 예약 여부 확인 */
        public bool MemResvCheck(int mem_no, string isbn)
        {
            String sql_listcheck = $"SELECT isbn FROM reserve WHERE mem_no={mem_no} && isbn='{isbn}';";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_listcheck);
            if (result.HasRows)
            {
                MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
                return true;
            }
            else
            {
                MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
                return false;
            }
        }

        /* 도서 예약 */
        public bool ResvListIn(int mem_no, string isbn)
        {
            if(MemResvCheck(mem_no, isbn))
            {
                return false;
            }
            else
            {
                String resvDt = System.DateTime.Now.ToString("yyyy-MM-dd");
                string sql = $"INSERT INTO reserve VALUES({mem_no},'{isbn}', '{resvDt}');";
                if (MySql_Util.Instance.Update_Sql(sql))
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

        /* 기간 내 도서 대여량 평균 */
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
                    if (string.Compare(cp2, dt1Mm) >= 1) //한달전(30일전)부터 오늘까지중에 대여일자가 있으면
                    {
                        rentAvg += 1;
                    }
                }
                rentAvg = rentAvg / 30;
            }
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return rentAvg;
        }

        /* 오늘 도서 대여량 */
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
            MySql_Util.Instance.sqlConn.ClearAllPoolsAsync();
            return rentSum;
        }


        public void StockAdd(string isbn, int stock)
        {
            string sql = $"UPDATE bookinfo SET stock={stock} WHERE isbn = '{isbn}';  ";
            MySql_Util.Instance.Update_Sql(sql);

        }

    }
}
