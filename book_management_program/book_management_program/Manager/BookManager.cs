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

        public int BookCount()
        {
            string sql = "SELECT stock FROM bookinfo ;";
            string sql2 = $"SELECT COUNT(*) FROM rental;";
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

        public int RentStockCheck(string isbn)
        {
            /* 도서 재고 확인 */
            String sql_stockcheck = $"SELECT stock FROM bookinfo WHERE isbn='{isbn}';";
            MySqlDataReader stockresult = MySql_Util.Instance.Select_Sql(sql_stockcheck);
            if (stockresult.HasRows)
            {
                while(stockresult.Read())
                {
                    if (stockresult.GetInt32(0) > 0)
                    {
                        //재고 있을 때
                        //MessageBox.Show("stockresult.GetInt32(0)=" + stockresult.GetInt32(0));
                        return stockresult.GetInt32(0);
                    }
                    else
                    {
                        //MessageBox.Show("stockresult.GetInt32(0)=" + stockresult.GetInt32(0));
                        
                    }
                }
                return 0;
            }
            else
            {
                //MessageBox.Show("stockresult.HasRows = false");
                return 0;
            }
        }

            
        public bool BookRent(int mem_no, string isbn)
        {
            //재고 -1 update  , rental테이블에 insert
            //한번에 여러개 대여는?
            //MessageBox.Show("mem_no="+ mem_no + ", isbn="+ isbn);
            if(RentStockCheck(isbn)>0)
            { 
                //재고 있을 때 대여 가능
                String rentDt = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
                String returnDt = System.DateTime.Now.AddDays(7).ToString("yyyy-MM-dd HH:mm:ss");
                //MessageBox.Show("rentDt=" + rentDt + "~ returnDt=" + returnDt);
                string sql = $"INSERT INTO rental(isbn, mem_no, rent_dt, return_dt, ext) VALUES('{isbn}' , {mem_no} , '{rentDt}', '{returnDt}', 'N') ;";
                //MessageBox.Show("sql=" + sql);

                int stock= RentStockCheck(isbn)-1;
                //MessageBox.Show("stock=" + stock);
                string sql2 = $"UPDATE bookinfo SET stock={stock} WHERE isbn= '{isbn}'; ";
                //MessageBox.Show("sql2=" + sql2);
                if (MySql_Util.Instance.Insert_Sql(sql) && MySql_Util.Instance.Update_Sql(sql2))
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

        public bool MemRentCheck(int mem_no, string isbn)
        {
            /* 도서 대여 여부 확인 */
            String sql_listcheck = $"SELECT rent_no FROM rental WHERE mem_no={mem_no} && isbn='{isbn}' ORDER BY rent_dt ASC;";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_listcheck);
            if (result.HasRows)
            {   
                //대여중
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool BookReturn(int mem_no, string isbn)
        {
            //rental update , bookinfo 재고 + 1
            //의논필요
            //String rentDt = System.DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
            //string sql = $"UPDATE rental SET return_dt='{System.DateTime.Today.ToShortDateString()}' WHERE mem_no = {mem_no} , isbn= '{isbn}' ; ";
            bool isSuccess = false; 
            if (MemRentCheck(mem_no, isbn))
            {
                //대여중일 때
                String sql_listcheck = $"SELECT rent_no FROM rental WHERE mem_no={mem_no} && isbn='{isbn}' ORDER BY rent_dt ASC ;";
                MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_listcheck);
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        //가장 먼저 대여한 것 하나만 반납
                        string sql = $"DELETE FROM rental WHERE rent_no = {result.GetString(0)};";
                        if (MySql_Util.Instance.Update_Sql(sql))
                        {
                            MessageBox.Show("반납 완료 : 삭제", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            isSuccess = true;
                            break;
                        }
                        else
                        {
                            MessageBox.Show("반납 에러 : 삭제", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            isSuccess = false;
                            break;
                        }
                    }
                }

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

        public string RentExtCheck(int rent_no)
        {
            /* 도서 대여 연장 여부 확인 */
            string extcheck = "";
            String sql_listcheck = $"SELECT ext FROM rental WHERE rent_no={rent_no};";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_listcheck);
            if (result.HasRows)
            {
                extcheck=result.GetString(0);
                return extcheck;
            }
            else
            {
                return null;
            }
        }

        public bool RentExtUpdate(int mem_no, string isbn)
        {
            //rental ext update
            /* 도서 연장 가능 여부 확인 */
            String sql_extcheck = $"SELECT rent_no, ext FROM rental WHERE mem_no={mem_no} && isbn='{isbn}' ORDER BY rent_dt ASC;";
            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql_extcheck);
            if (result.HasRows)
            {
                while (result.Read())
                {
                    if (result.GetString(1)=="N")
                    {
                        string sql = $"UPDATE rental SET ext='Y' WHERE rent_no = {result.GetInt32(0)}; ";
                        if (MySql_Util.Instance.Update_Sql(sql) == true)
                        {
                            MessageBox.Show("연장 완료", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return true;
                        }
                    }
                }
                MessageBox.Show("연장 불가", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
            {
                MessageBox.Show("연장 조회 에러", "관리 메시지", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        /*
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
        }*/

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
                    if (string.Compare(cp2, dt1Mm) >= 1) //한달전(30일전)부터 오늘까지중에 대여일자가 있으면
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

        public string RentExtCheck(int mem_no, string isbn)
        {
            throw new NotImplementedException();
        }
    }
}
