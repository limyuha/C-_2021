using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using book_management_program.Model;
using book_management_program.Util;
using book_management_program.Manager;

namespace book_management_program.Forms
{
    public partial class book_manager : Form
    {
        private BookManager bookmanager = new BookManager();

        public book_manager()
        {
            InitializeComponent();
            ListViewConn();
        }

        private void ListViewConn()
        {
            List<Book> list = new List<Book>();
            BookManager bookmanager = new BookManager();

            list = bookmanager.BookInfoList();

            ListViewItem item;

            this.book_listView.Items.Clear();

            foreach (Book book in list)
            {
                item = new ListViewItem(book.Isbn.ToString());
                item.SubItems.Add(book.Book_nm.ToString());
                item.SubItems.Add(book.Author.ToString());
                item.SubItems.Add(book.Pub.ToString());
                item.SubItems.Add(book.Stock.ToString());

                this.book_listView.Items.Add(item);
            }
        }

        private void rent_btn_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            book.Isbn = this.book_number_textBox.Text;
            book.Book_nm = this.book_name_textBox.Text;
            book.Author = this.book_writer_textBox.Text;
            book.Pub = this.book_publisher_textBox.Text;
            book.Stock = int.Parse(this.book_stock_textBox.Text);

            bookmanager.BookInfoInsert(book);
            ListViewConn();
        }
    }
}