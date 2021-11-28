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
        public static string memberId //회원id
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
            memberId = id; //회원id 지정
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

        private void main_Load(object sender, EventArgs e)
        {
            //label1.Text = memName(memberId) + " 님";

            HomeForm home = new HomeForm();
            home.MdiParent = this;
            //home.WindowState = FormWindowState.Maximized;
            //this.WindowState = FormWindowState.Maximized;
            home.Show();

            formName = home;
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
