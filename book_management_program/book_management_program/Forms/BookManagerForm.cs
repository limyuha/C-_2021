﻿using System;
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
    public partial class book_manager_Form : Form
    {
        //private BookManager bookmanager = new BookManager();
        private List<Book> list = new List<Book>();
        private int rentSum = 0;

        public book_manager_Form()
        {
            InitializeComponent();
        }

        private void rent_btn_Click(object sender, EventArgs e)
        {
            if (this.book_number_textBox.Enabled == false)
            {
                this.book_number_textBox.Enabled = true;
                this.book_number_textBox.Clear();
                this.book_name_textBox.Clear();
                this.book_writer_textBox.Clear();
                this.book_publisher_textBox.Clear();
                this.book_stock_textBox.Clear();
            }
            else
            {
                Book book = new Book();

                book.Isbn = this.book_number_textBox.Text;
                book.Book_nm = this.book_name_textBox.Text;
                book.Author = this.book_writer_textBox.Text;
                book.Cat_no = 1;
                book.Pub = this.book_publisher_textBox.Text;
                book.Stock = int.Parse(this.book_stock_textBox.Text);
                book.Pub_dt = DateTime.Now.ToString("yyyy-MM-dd").ToString();
                BookManager.Book.BookInfoInsert(book);
            }
        }

        private void modify_btn_Click(object sender, EventArgs e)
        {
            Book book = new Book();

            book.Isbn = this.book_number_textBox.Text;
            book.Book_nm = this.book_name_textBox.Text;
            book.Author = this.book_writer_textBox.Text;
            book.Pub = this.book_publisher_textBox.Text;
            book.Stock = int.Parse(this.book_stock_textBox.Text);

            BookManager.Book.BookInfoUpdate(book);
        }

        private void book_delete_btn_Click(object sender, EventArgs e)
        {
            BookManager.Book.BookInfoDelete(this.book_number_textBox.Text);
        }

        private void book_listView_ItemActivate(object sender, EventArgs e)
        {
            int where = 0;
            if (book_listView.SelectedIndices.Count > 0)
            {
                where = book_listView.SelectedIndices[0];

                this.book_number_textBox.Text = book_listView.Items[where].SubItems[0].Text;
                this.book_name_textBox.Text = book_listView.Items[where].SubItems[5].Text;
                this.book_writer_textBox.Text = book_listView.Items[where].SubItems[2].Text;
                this.book_publisher_textBox.Text = book_listView.Items[where].SubItems[3].Text;
                this.book_stock_textBox.Text = book_listView.Items[where].SubItems[6].Text;

                this.book_number_textBox.Enabled = false;
            }

        }

        private void stock_add_btn_Click(object sender, EventArgs e)
        {

            string isbn = this.book_number_textBox.Text;
            int stock = int.Parse(this.book_stock_textBox.Text) + 1;


            BookManager.Book.StockAdd(isbn, stock);
            this.book_stock_textBox.Text = stock.ToString();

        }

        private void book_manager_Form_Load(object sender, EventArgs e)
        {
            this.book_listView.Items.Clear();
            list = BookManager.Book.BookInfoListM();

            MessageBox.Show("불러온 도서 개수 : " + list.Count().ToString() + "개");

            foreach (Book book in list)
            {
                rentSum = BookManager.Book.RentSum(book.Isbn);
                string[] row = { book.Isbn, book.Cat_nm, book.Author, book.Pub, book.Pub_dt.ToString(), book.Book_nm, book.Stock.ToString(), rentSum.ToString() };
                var lvItem = new ListViewItem(row);
                this.book_listView.Items.Add(lvItem);
            }
        }

        private void book_manager_Form_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}