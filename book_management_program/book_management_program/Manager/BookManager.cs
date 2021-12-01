using book_management_program.Model;
using book_management_program.Util;
using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data.MySqlClient;

namespace book_management_program.Manager
{
    class BookManager : IBookManager
    {
        public int BookCount()
        {
            throw new NotImplementedException();
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
            string sql = "SELECT isbn, book_nm, author, pub, stock FROM bookinfo";

            List<Book> books = new List<Book>();

            Book book;

            MySqlDataReader result = MySql_Util.Instance.Select_Sql(sql);

            if (result.HasRows)
            {
                while (result.Read())
                {
                    book = new Book();
                    book.Isbn = result.GetString(0);
                    book.Book_nm = result.GetString(1);
                    book.Author = result.GetString(2);
                    book.Pub = result.GetString(3);
                    book.Stock = result.GetInt32(4);
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

        public void BookRent(string isbn)
        {
            throw new NotImplementedException();
        }

        public List<Book> BookRentRanking()
        {
            throw new NotImplementedException();
        }

        public void BookResvCancel(string isbn)
        {
            throw new NotImplementedException();
        }

        public void BookResvUpdate(string isbn)
        {
            throw new NotImplementedException();
        }

        public void BookReturn(string isbn)
        {
            throw new NotImplementedException();
        }

        public List<Book> BookSearch(string type, string search)
        {
            throw new NotImplementedException();
        }

        public string RentExtCheck(string mem_nm, string isbn)
        {
            throw new NotImplementedException();
        }

        public void RentExtUpdate(string mem_nm, string isbn)
        {
            throw new NotImplementedException();
        }

        public void RentListDel(string mem_nm, string isbn)
        {
            throw new NotImplementedException();
        }

        public void RentListIn(string mem_nm, string isbn)
        {
            throw new NotImplementedException();
        }

        public void ResvListDel(string mem_nm, string isbn)
        {
            throw new NotImplementedException();
        }

        public void ResvListIn(string mem_nm, string isbn)
        {
            throw new NotImplementedException();
        }

        public float TermRentAvg()
        {
            throw new NotImplementedException();
        }

        public int TodayRentSum()
        {
            throw new NotImplementedException();
        }
    }
}
