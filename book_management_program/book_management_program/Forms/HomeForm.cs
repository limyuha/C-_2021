﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using book_management_program.Model;
using book_management_program.Manager;

namespace book_management_program.Forms
{
    public partial class HomeForm : Form
    {
        private List<Book> ranking; //대여 순위
        private List<Book> books; //도서 목록

        private int num = -1; //도서목록에서 선택된 행 번호

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            /* 도서 대여 랭킹 : ranking_listView */
            ranking = BookManager.Book.BookRentRanking();
            int r = 0;
            foreach (var book in ranking)
            {
                r++; //순위
                string[] row = { r.ToString(), book.Isbn, book.Book_nm, book.Author, book.Pub };
                var lvItem = new ListViewItem(row);
                this.ranking_listView.Items.Add(lvItem);
            }

            /* 장서량 */
            this.book_count_labels.Text = BookManager.Book.BookCount().ToString();

            /* 기간 대여량 */
            this.rent_avg_labels.Text = BookManager.Book.TermRentAvg().ToString();

            //
            updateView();

            //검색 타입 설정
            this.group_comboBox.SelectedIndex = 0;
        }

        
        private void updateView ()
        {
            //하루 대여량
            this.rent_sum_labels.Text = BookManager.Book.TodayRentSum().ToString();
            //책 정보 목록
            books = BookManager.Book.BookInfoList();
            BooksView(books);
        }

        private void BooksView(List<Book> books)
        {
            this.book_listView.Items.Clear();
            foreach (var book in books)
            {
                string[] row = { book.Isbn, book.Cat_nm, book.Author, book.Pub, book.Pub_dt.ToString("yyyy-MM-dd"), book.Book_nm, book.Stock.ToString() };
                var lvItem = new ListViewItem(row);
                this.book_listView.Items.Add(lvItem);
            }
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
        }

        private void book_listView_Click(object sender, EventArgs e)
        {
            if (this.book_listView.SelectedItems.Count > 0)
            {
                num = Convert.ToInt32(this.book_listView.SelectedIndices[0]);
                this.booknumber_textBox.Text = this.book_listView.SelectedItems[0].SubItems[0].Text;
                this.bookname_textBox.Text = this.book_listView.SelectedItems[0].SubItems[5].Text;
            }

            /* 대여중&예약중 상태 확인 - 추가 */
            //예약중 체크
            resv_checkBox.Checked = BookManager.Book.MemResvCheck(MainForm.Mem_no, this.booknumber_textBox.Text);
        }

        private void ClearTxt() //선택한 도서 정보 지우기
        {
            this.booknumber_textBox.Text = "";
            this.bookname_textBox.Text = "";
        }

        private void rent_btn_Click(object sender, EventArgs e)
        {
            if (this.booknumber_textBox.Text != "" && this.bookname_textBox.Text != "")
            {
                //BookManager.bookRentUpdate();
                //MemberManager.memRentListIn();
                MessageBox.Show("대여 완료되었습니다.\n대여기간 : " + DateTime.Now.ToString("yyyy-MM-dd")
                + " ~ " + (DateTime.Now.AddDays(7).ToString("yyyy-MM-dd")), "대여", MessageBoxButtons.OK);
                ClearTxt();
            } 
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "대여", MessageBoxButtons.OK);
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (this.booknumber_textBox.Text != "" && this.bookname_textBox.Text != "")
            {
                /* DB에서 해당 책이 대여 목록에 존재하는지 확인해야함! */
                //BookManager.bookReturnUpdate();
                //MemberManager.memRentListDel();
                MessageBox.Show("반납 완료되었습니다.", "반납", MessageBoxButtons.OK);
                ClearTxt();
            }
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "반납", MessageBoxButtons.OK);
            }
        }

        private void resv_btn_Click(object sender, EventArgs e)
        {
            if (this.booknumber_textBox.Text != "" && this.bookname_textBox.Text != "")
            {
                if (resv_checkBox.Checked)
                {
                    MessageBox.Show("이미 예약 된 도서입니다.");
                }
                else
                {
                    if (BookManager.Book.ResvListIn(MainForm.Mem_no, this.booknumber_textBox.Text))
                    {
                        // 1.회원 예약 목록에 추가
                        MessageBox.Show("예약 완료되었습니다.\n예약은 마이페이지에서 확인 및 취소 가능합니다.", "예약", MessageBoxButtons.OK);
                        ClearTxt();
                    }
                }
            }
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "예약", MessageBoxButtons.OK);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
            ClearTxt();

            string type=""; //검색 기준 : 도서명-book_nm, 저자-author, 출판사-pub
            string search = search_textBox.Text; //검색 입력
            List<Book> searchResults = new List<Book>(); //검색 결과
            if (group_comboBox.SelectedItem!=null)
            {
                switch (group_comboBox.SelectedItem.ToString())
                {
                    case "도서명":
                        type = "book_nm";
                        break;
                    case "저자":
                        type = "author";
                        break;
                    case "출판사":
                        type = "pub";
                        break;
                }
            }

            if (type!="" && string.IsNullOrWhiteSpace(search)==false)
            {
                books.Clear();

                books = BookManager.Book.BookSearch(type, search);
                BooksView(books);//검색 결과 리스트뷰에 결과 보여주기

            }
            else if (string.IsNullOrWhiteSpace(search))
            {
                books.Clear();

                books = BookManager.Book.BookInfoList();
                BooksView(books);//도서 목록 리스트뷰에 결과 보여주기
            }
            else
            {
                MessageBox.Show("타입 선택", "검색", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void all_btn_Click(object sender, EventArgs e)
        {
            ClearTxt();

            books.Clear();
            books = BookManager.Book.BookInfoList();
            BooksView(books);//도서 목록 리스트뷰에 결과 보여주기
        }
    }
}
