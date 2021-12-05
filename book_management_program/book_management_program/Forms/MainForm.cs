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
    public partial class MainForm : Form
    {
        private Member member;
        private bool isOverdued; 
        public static int Mem_no //회원id
        {
            get; set;
        }
        public static bool IsOverdued //연체중 : true-대여 가능 / false-대여불가
        {
            get; set;
        }


        public MainForm()
        {
            InitializeComponent();
        }

        public MainForm(string id)
        {
            InitializeComponent();

            member = MemberManager.Member.MemInfoLookup(id); //회원 정보 조회
            Mem_no = member.Mem_no;

            MemberManager.Member.MemOverdueCheck(Mem_no); //대여 목록 연체 검사
            IsOverdued = MemberManager.Member.MemOverdueUpdate(Mem_no); //회원 연체 상태 체크
            MessageBox.Show("회원 연체 상태"+ IsOverdued);

        }

        private void main_Load(object sender, EventArgs e)
        {
            id_name_label.Text = member.Mem_nm + " 님";

            HomeForm home = new HomeForm();
            home.MdiParent = this;
            //home.WindowState = FormWindowState.Maximized;
            //this.WindowState = FormWindowState.Maximized;
            home.Show();

            formName = home;
        }

        private void movePanelSlide(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        Form formName = null;

        private void home_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(home_btn);

            if (formName != null)
            {
                formName.Hide();
                formName.Close();
            }

            HomeForm home = new HomeForm();
            home.MdiParent = this;
            home.Show();

            formName = home;
        }
        private void mypage_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(mypage_btn);

            if (formName != null)
            {
                formName.Hide();
                formName.Close();
            }

            //Point parentPoint = this.Location; //main 폼 시작 위치 값

            MypageForm mypage = new MypageForm();
            //mypage.TopLevel = false;

            //Wmypage.StartPosition = FormStartPosition.Manual;
            mypage.MdiParent = this;
            //mypage.Location = new Point(parentPoint.X+150, parentPoint.Y+45);
            //mypage.Location = new Point(parentPoint.X + 155, parentPoint.Y + 45);
            mypage.Show();

            formName = mypage;
        }
        private void issue_btn_Click(object sender, EventArgs e)
        {
            if (formName != null)
            {
                formName.Hide();
                formName.Close();
            }

            movePanelSlide(issue_btn);

            IssueForm issue = new IssueForm();
            issue.MdiParent = this;
            issue.Show();

            formName = issue;
        }
        private void search_form_btn_Click(object sender, EventArgs e)
        {
            if (formName != null)
            {
                formName.Hide();
                formName.Close();
            }

            movePanelSlide(search_form_btn);

            SearchForm search_form = new SearchForm();
            search_form.MdiParent = this;
            search_form.Show();

            formName = search_form;
        }
        private void help_btn_Click(object sender, EventArgs e)
        {
            if (formName != null)
            {
                formName.Hide();
                formName.Close();
            }

            movePanelSlide(help_btn);

            HelpForm help = new HelpForm();
            help.MdiParent = this;
            help.Show();

            formName = help;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            Application.ExitThread(); //스레드 종료
            //Application.Exit() → FormClosing → FormClosed
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); //스레드 종료
        }

    }
}
