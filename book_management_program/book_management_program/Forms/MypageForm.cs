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
    public partial class MypageForm : Form
    {
        //아이디
        private int memberNo = MainForm.Mem_no; 

        /*
        private List<Book> rents; //대여 목록
        private List<Book> resevs; //예약 목록*/

        private int num = -1; //도서목록에서 선택된 행 번호

        public MypageForm()
        {
            InitializeComponent();
        }

        private void MypageForm_Load(object sender, EventArgs e)
        {
            RentListView();//대여 목록 불러오기
            ResvListView(); //예약목록 불러오기
        }


        /* 대여 목록 */
        public void RentListView()
        {
            this.rent_listView.Items.Clear();
            List<Book> rentbooks = MemberManager.Member.MemRentList(MainForm.Mem_no); //대여목록 불러오기
                foreach (var book in rentbooks)
            {
                string[] row = { book.Rent_no.ToString(), book.Isbn, book.Cat_nm, book.Author, book.Pub, book.Pub_dt.ToString("yyyy-MM-dd"), book.Book_nm, book.Rent_dt.ToString("yyyy-MM-dd") };
                var lvItem = new ListViewItem(row);
                this.rent_listView.Items.Add(lvItem);
            }
        }

        /* 대여 도서 선택 */
        private void rent_listView_Click(object sender, EventArgs e)
        {
            if (this.rent_listView.SelectedItems.Count > 0)
            {
                num = Convert.ToInt32(this.rent_listView.SelectedIndices[0]);
                this.rent_booknumber_textBox.Text = this.rent_listView.SelectedItems[0].SubItems[1].Text;
                this.rent_bookname_textBox.Text = this.rent_listView.SelectedItems[0].SubItems[6].Text;
            }
        }

        /* 대여 연장 버튼 */
        private void rent_extend_btn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.rent_booknumber_textBox.Text)==false && string.IsNullOrWhiteSpace(rent_booknumber_textBox.Text) == false)
            {
                if (MainForm.IsOverdued) //대여 가능도 체크
                {
                    string isbn = rent_booknumber_textBox.Text;
                    BookManager.Book.RentExtUpdate(MainForm.Mem_no, isbn);
                }
                else
                {
                    MessageBox.Show("연체 중, 대여 불가", "연장", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "연장", MessageBoxButtons.OK);
            }
        }

        /* 반납 버튼 */
        private void return_btn_Click(object sender, EventArgs e)
        {
            if (this.rent_booknumber_textBox.Text != "" && this.rent_bookname_textBox.Text != "")
            {
                //반납 처리
                bool returnresult = BookManager.Book.BookReturn(MainForm.Mem_no, this.rent_booknumber_textBox.Text);
                //선택한 대여 도서 정보 지우기
                this.rent_booknumber_textBox.Text = "";
                this.rent_bookname_textBox.Text = "";
                //도서목록 다시 불러오기
                RentListView();
            }
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "반납", MessageBoxButtons.OK);
            }
        }


        /* 예약 목록 */
        private void ResvListView()
        {
            this.resv_listView.Items.Clear();
            List<Book> resrvbooks = MemberManager.Member.MemResvList(MainForm.Mem_no); //예약목록 불러오기
            foreach (var book in resrvbooks)
            {
                string[] row = {book.Isbn, book.Cat_nm, book.Author, book.Pub, book.Pub_dt.ToString("yyyy-MM-dd"), book.Book_nm, book.Rent_ck };
                var lvItem = new ListViewItem(row);
                this.resv_listView.Items.Add(lvItem);
            }
        }

        /* 예약 도서 선택 */
        private void resv_listView_Click(object sender, EventArgs e)
        {
            if (this.resv_listView.SelectedItems.Count > 0)
            {
                num = Convert.ToInt32(this.resv_listView.SelectedIndices[0]);
                this.resv_booknumber_textBox.Text = this.resv_listView.SelectedItems[0].SubItems[0].Text;
                this.resv_bookname_textBox.Text = this.resv_listView.SelectedItems[0].SubItems[5].Text;
                if (this.resv_listView.SelectedItems[0].SubItems[4].Text == "대여불가")
                {
                    rent_btn.BackColor= Color.FromArgb(255, 192, 192);
                }
                else
                {
                    rent_btn.BackColor = Color.FromArgb(255, 128, 128);
                }
            }
        }

        /* 대여 버튼 */
        private void rent_btn_Click(object sender, EventArgs e)
        {
            if (this.resv_booknumber_textBox.Text != "" && this.resv_bookname_textBox.Text != "")
            {
                if (this.resv_listView.SelectedItems[0].SubItems[4].Text == "대여불가")
                {
                    MessageBox.Show("현재 대여가 불가합니다.", "예약", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MainForm.IsOverdued) // 연체 중 : true-대여 가능 / false-대여불가
                    {
                        if (BookManager.Book.BookRent(MainForm.Mem_no, this.resv_booknumber_textBox.Text))
                        {
                            BookManager.Book.ResvListDel(MainForm.Mem_no, this.resv_booknumber_textBox.Text);
                            MessageBox.Show("대여기간 : " + DateTime.Now.ToString("yyyy-MM-dd")
                                            + " ~ " + (DateTime.Now.AddDays(7).ToString("yyyy-MM-dd")), "대여", MessageBoxButtons.OK);
                            //선택한 대여 도서 정보 지우기
                            this.resv_booknumber_textBox.Text = "";
                            this.resv_bookname_textBox.Text = "";
                            //대여-예약 도서 목록 다시 불러오기
                            RentListView();
                            ResvListView();
                        }
                    }
                    else
                    {
                        MessageBox.Show("연체 중, 대여 불가", "대여", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "예약", MessageBoxButtons.OK);
            }
        }

        /* 예약 삭제 버튼 */
        private void resvDel_btn_Click(object sender, EventArgs e)
        {
            if (this.resv_booknumber_textBox.Text != "" && this.resv_bookname_textBox.Text != "")
            {
                BookManager.Book.ResvListDel(MainForm.Mem_no, this.resv_booknumber_textBox.Text);
                //예약 도서 목록 다시 불러오기
                ResvListView();
            }
        }

        private void resv_listView_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
