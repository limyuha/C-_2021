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
        public int BookCount()
        {
            throw new NotImplementedException();
        }

        public void BookInfoDelete(string isbn)
        {
            throw new NotImplementedException();
        }

        // BookManager.cs 등록 버튼
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

        public List<Book> BookInfoList()
        {
            throw new NotImplementedException();
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
