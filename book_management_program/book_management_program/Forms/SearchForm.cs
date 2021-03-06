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
    public partial class SearchForm : Form
    {

        private List<Book> list = new List<Book>();

        public SearchForm()
        {
            InitializeComponent();

            //검색 타입 설정
            this.group_comboBox.SelectedIndex = 0;
        }

        private void BooksView(List<Book> books)
        {
            this.search_listView.Items.Clear();
            foreach (var book in books)
            {
                string[] row = { book.Isbn, book.Cat_nm, book.Author, book.Pub, book.Pub_dt.ToString(), book.Book_nm, book.Stock.ToString() };
                var lvItem = new ListViewItem(row);
                this.search_listView.Items.Add(lvItem);
            }
        }

        /* 검색 버튼 */
        private void search_btn_Click(object sender, EventArgs e)
        {
            string type = ""; //검색 기준 : 도서명-book_nm, 저자-author, 출판사-pub
            string search = search_textBox.Text; //검색 입력
            List<Book> searchResults = new List<Book>(); //검색 결과
            if (group_comboBox.SelectedItem != null)
            {
                switch (group_comboBox.SelectedItem.ToString())
                {
                    case "ISBN":
                        type = "bookinfo.isbn";
                        break;
                    case "도서명":
                        type = "book_nm";
                        break;
                    case "저자":
                        type = "author";
                        break;
                    case "분류":
                        type = "cat_nm";
                        break;
                }
            }

            if (!string.IsNullOrWhiteSpace(type) && !string.IsNullOrWhiteSpace(search))
            {
                //books.Clear();

                List<Book> books = BookManager.Book.BookSearch(type, search.TrimStart());
                BooksView(books);//검색 결과 리스트뷰에 결과 보여주기

            }
            else if (string.IsNullOrWhiteSpace(search))
            {
                //books.Clear();

                List<Book> books = BookManager.Book.BookInfoList();
                BooksView(books);//도서 목록 리스트뷰에 결과 보여주기
            }
            else
            {
                MessageBox.Show("타입 선택", "검색", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void BooksList()
        {
            this.search_listView.Items.Clear();

            list = BookManager.Book.BookInfoListM();

            foreach (var book in list)
            {
                string[] row = { book.Isbn, book.Cat_nm, book.Author, book.Pub, book.Pub_dt.ToString(), book.Book_nm, book.Stock.ToString() };
                var lvItem = new ListViewItem(row);
                this.search_listView.Items.Add(lvItem);
            }
        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            BooksList();
        }

        private void all_btn_Click(object sender, EventArgs e)
        {
            search_textBox.Clear();
            BooksList();
        }
    }
}
