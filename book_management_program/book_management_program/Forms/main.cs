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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
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
                formName.Close();
            }

            home home = new home();
            home.MdiParent = this;
            home.Show();

            formName = home;
        }
        private void mypage_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(mypage_btn);

            if (formName != null)
            {
                formName.Close();
            }

            //Point parentPoint = this.Location; //main 폼 시작 위치 값

            mypage mypage = new mypage();
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
                formName.Close();
            }

            movePanelSlide(issue_btn);

            issue issue = new issue();
            issue.MdiParent = this;
            issue.Show();

            formName = issue;
        }
        private void search_form_btn_Click(object sender, EventArgs e)
        {
            if (formName != null)
            {
                formName.Close();
            }

            movePanelSlide(search_form_btn);

            search_form search_form = new search_form();
            search_form.MdiParent = this;
            search_form.Show();

            formName = search_form;
        }
        private void help_btn_Click(object sender, EventArgs e)
        {
            if (formName != null)
            {
                formName.Close();
            }

            movePanelSlide(help_btn);

            help help = new help();
            help.MdiParent = this;
            help.Show();

            formName = help;
        }

        private void main_Load(object sender, EventArgs e)
        {
            home home = new home();
            home.MdiParent = this;
            //home.WindowState = FormWindowState.Maximized;
            //this.WindowState = FormWindowState.Maximized;
            home.Show();

            formName = home;
        }
    }
}
