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

        private string memberId = MainForm.memberId; //아이디

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
            RentList(); //대여목록 불러오기
            ResvList(); //예약목록 불러오기
        }

        /* 대여 */
        private void RentList()
        {

            //this.rent_listView.Items.Clear();
            //rents = MemberManager.memRentList(memberId);
            List<string[]> books = new List<string[]>();
            string[] row1 = { "도서번호1", "도서명1", "저자1", "출판사1", "대여일", "반납일" };
            string[] row2 = { "도서번호2", "도서명2", "저자2", "출판사2", "대여일", "반납일" };
            books.Add(row1); books.Add(row2);

            foreach (var book in books)
            {
                var lvItem = new ListViewItem(book);
                this.rent_listView.Items.Add(lvItem);
            }

        }
        private void RentListDel()
        {
            this.rent_listView.Items.Clear();
            //rents = MemberManager.memRentList(memberId);
            List<string[]> books = new List<string[]>();
            string[] row1 = { "도서번호1", "도서명1", "저자1", "출판사1", "대여일", "반납일" };
            books.Add(row1);

            foreach (var book in books)
            {
                var lvItem = new ListViewItem(book);
                this.rent_listView.Items.Add(lvItem);
            }

        }

        private void rent_listView_Click(object sender, EventArgs e)
        {
            if (this.rent_listView.SelectedItems.Count > 0)
            {
                num = Convert.ToInt32(this.rent_listView.SelectedIndices[0]);
                this.rent_booknumber_textBox.Text = this.rent_listView.SelectedItems[0].SubItems[0].Text;
                this.rent_bookname_textBox.Text = this.rent_listView.SelectedItems[0].SubItems[1].Text;
            }
        }

        private void return_btn_Click(object sender, EventArgs e)
        {
            if (this.rent_booknumber_textBox.Text != "" && this.rent_bookname_textBox.Text != "")
            {
                /* DB에서 해당 책이 대여 목록에 존재하는지 확인해야함! */
                //BookManager.bookReturnUpdate();
                //MemberManager.memRentListDel(memberId, bookId);
                MessageBox.Show("반납 완료되었습니다.", "반납", MessageBoxButtons.OK);
                //선택한 대여 도서 정보 지우기
                this.rent_booknumber_textBox.Text = "";
                this.rent_bookname_textBox.Text = "";
                //도서목록 다시 불러오기
                RentListDel();
            }
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "반납", MessageBoxButtons.OK);
            }
        }


        /* 예약 */
        private void ResvList()
        {
            this.resv_listView.Items.Clear();
            //resvs = MemberManager.memResvList(memberId);
            List<string[]> books = new List<string[]>();
            string[] row1 = { "도서번호1", "도서명1", "저자1", "출판사1", "대여가능" };
            string[] row2 = { "도서번호2", "도서명2", "저자2", "출판사2", "대여불가" };
            books.Add(row1); books.Add(row2);

            foreach (var book in books)
            {
                var lvItem = new ListViewItem(book);
                this.resv_listView.Items.Add(lvItem);
            }
        }
        private void ResvListDel()
        {
            this.resv_listView.Items.Clear();
            //resvs = MemberManager.memResvList(memberId);
            List<string[]> books = new List<string[]>();
            string[] row2 = { "도서번호2", "도서명2", "저자2", "출판사2", "대여불가" };
            books.Add(row2);

            foreach (var book in books)
            {
                var lvItem = new ListViewItem(book);
                this.resv_listView.Items.Add(lvItem);
            }
        }

        private void resv_listView_Click(object sender, EventArgs e)
        {
            if (this.resv_listView.SelectedItems.Count > 0)
            {
                num = Convert.ToInt32(this.resv_listView.SelectedIndices[0]);
                this.resv_booknumber_textBox.Text = this.resv_listView.SelectedItems[0].SubItems[0].Text;
                this.resv_bookname_textBox.Text = this.resv_listView.SelectedItems[0].SubItems[1].Text;
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
                    //BookManager.bookReturnUpdate();
                    //MemberManager.memRentListDel(memberId, bookId);
                    MessageBox.Show("대여 되었습니다.", "예약", MessageBoxButtons.OK);
                    //선택한 대여 도서 정보 지우기
                    this.resv_booknumber_textBox.Text = "";
                    this.resv_bookname_textBox.Text = "";
                    //도서목록 다시 불러오기
                    ResvListDel();
                }
            }
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "예약", MessageBoxButtons.OK);
            }
        }

    }
}
