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
        private Book book = new Model.Book();
        private BookManager bookmanager = new BookManager();

        public book_manager()
        {
            InitializeComponent();
        }

        private void rent_btn_Click(object sender, EventArgs e)
        {
            book.Isbn = this.book_number_textBox.Text;
            book.Book_nm = this.book_name_textBox.Text;
            book.Author = this.book_writer_textBox.Text;
            book.Pub = this.book_publisher_textBox.Text;
            book.Stock = int.Parse(this.book_stock_textBox.Text);

            bookmanager.BookInfoInsert(book);
        }
    }
}