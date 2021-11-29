using System;
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
        private System.Timers.Timer TimerEvent; //하루 대여량 업데이트 Timer 생성
        private delegate void OnDelegateTodayrentsum(int sum);//하루 대여량 출력 delegate
        private OnDelegateTodayrentsum OnTodayRentSum = null;
        int trsum = 0;/*테스트용*/


        public static Thread BooksThread;//도서목록 업데이트
        //private delegate void BooksUpdateDelegate(List<Book> books); // 도서목록 출력 delegate
        private delegate void BooksUpdateDelegate(List<string[]> books); /*테스트용*/
        private BooksUpdateDelegate UpBooks = null;

        //BooksThread 제어
        private ManualResetEvent _pauseEvent = new ManualResetEvent(true);
        public void pause() //중지
        {
            _pauseEvent.Reset();
        }
        public void resume() //재시작
        {
            _pauseEvent.Set();
        }

        /*
        private List<Book> ranking; //대여 순위
        private List<Book> books; //도서 목록*/

        private int num = -1; //도서목록에서 선택된 행 번호

        public HomeForm()
        {
            InitializeComponent();
            //this.rent_sum_labels.Text = BookManager.todayRentSum();
            this.rent_sum_labels.Text = "0";/*테스트용*/
            OnTodayRentSum = new OnDelegateTodayrentsum(SumView);
            /*
            ranking = BookManager.bookRentRanking();
            books = BookManager.bookInfoList();*/
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {
            /* 도서 대여 랭킹 : ranking_listView 
            int r = 0;
            foreach (var book in ranking)
            {
                r++; //순위
                string[] row = { r.ToString(), book.도서번호, book.도서명, book.저자, book.출판사};
                var lvItem = new ListViewItem(row);
                this.ranking_listView.Items.Add(lvItem);
            }*/

            /* 장서량 */
            //this.book_count_labels.Text = BookManager.bookCount();

            /* 기간 대여량 */
            //this.rent_avg_labels.Text = BookManager.termRentAvg();

            /* 하루 대여량 - 3초 간격으로 업데이트*/
            TimerEvent = new System.Timers.Timer(3000);
            TimerEvent.AutoReset = false; //not stopping 방지
            TimerEvent.Elapsed += new ElapsedEventHandler(TodayRentsUpdate);
            TimerEvent.Start();

            /* 도서 목록 - 10초 간격으로 업데이트 */
            UpBooks = new BooksUpdateDelegate(BooksView);// 도서목록 출력
            BooksThread = new Thread(BookList);//도서목록 업데이트
            BooksThread.IsBackground = true; //BackgroundThread : 메인스레드 종료시 같이 종료됨
            BooksThread.Start();
        }

        /* 하루 대여량 */
        private void TodayRentsUpdate(object sender, ElapsedEventArgs e)
        {
            //rent_sum_labels.Text = todayRentSum();
            trsum += 50; /*테스트용*/
            Invoke(OnTodayRentSum, trsum);
        }
        private void SumView (int sum)
        {
            rent_sum_labels.Text = trsum.ToString();
            TimerEvent.Enabled = true; //반복 가능
        }

        /* 도서 목록 */
        private void BookList()
        {   int b = 0;
            while (_pauseEvent.WaitOne())
            {
                //books = BookManager.bookInfoList();
                List<string[]> books = new List<string[]>();
                string[] row1 = { "도서번호" + (++b), "도서명1", "저자1", "출판사1", "재고1", "대여중1" };
                string[] row2 = { "도서번호" + (++b), "도서명2", "저자2", "출판사2", "재고2", "대여중2" };
                books.Add(row1); books.Add(row2);
                if(IsHandleCreated)
                {
                    if(InvokeRequired)
                        Invoke(UpBooks, books);
                }
                Thread.Sleep(10000);
            }
        }
        private void BooksView(List<string[]> books)
        {
            this.book_listView.Items.Clear();
            foreach (var book in books)
            {
                var lvItem = new ListViewItem(book);
                this.book_listView.Items.Add(lvItem);
            }
        }

        private void HomeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (TimerEvent != null)
            {
                TimerEvent.Stop();
                TimerEvent.Dispose();
            }
              
            if (BooksThread != null)
            {
                pause();
                BooksThread.Join();
            }
                
        }

        private void book_listView_Click(object sender, EventArgs e)
        {
            if (this.book_listView.SelectedItems.Count > 0)
            {
                num = Convert.ToInt32(this.book_listView.SelectedIndices[0]);
                this.booknumber_textBox.Text = this.book_listView.SelectedItems[0].SubItems[0].Text;
                this.bookname_textBox.Text = this.book_listView.SelectedItems[0].SubItems[1].Text;
            }

            /* 대여중&예약중 상태 확인 - 추가 */
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
            if(this.booknumber_textBox.Text != "" && this.bookname_textBox.Text != "")
            {
                //BookManager.bookResvUpdate();
                //MemberManager.memResvListIn();
                MessageBox.Show("예약 완료되었습니다.\n예약은 마이페이지에서 확인 및 취소 가능합니다.", "예약", MessageBoxButtons.OK);
                ClearTxt();
            }
            else
            {
                MessageBox.Show("책 정보가 필요합니다.", "예약", MessageBoxButtons.OK);
            }
        }

        private void search_btn_Click(object sender, EventArgs e)
        {
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
                if (!(BooksThread == null)) //BooksThread 중단
                    pause();

                //BookManager.bookSearch(type, search);
                List<string[]> books = new List<string[]>();
                string[] row1 = { "테스트 도서 1", "도서명1", "저자1", "출판사1", "재고1", "대여중1" };
                string[] row2 = { "테스트 도서 1", "도서명2", "저자2", "출판사2", "재고2", "대여중2" };
                books.Add(row1); books.Add(row2);
                BooksView(books);//검색 결과 리스트뷰에 결과 보여주기

            }
            else if (string.IsNullOrWhiteSpace(search))
            {
                List<string[]> books = new List<string[]>();
                string[] row1 = { "재시작 도서 1", "도서명1", "저자1", "출판사1", "재고1", "대여중1" };
                string[] row2 = { "재시작 도서 1", "도서명2", "저자2", "출판사2", "재고2", "대여중2" };
                books.Add(row1); books.Add(row2);
                BooksView(books);//검색 결과 리스트뷰에 결과 보여주기

                resume(); //BooksThread 재시작
            }
        }
    }
}
