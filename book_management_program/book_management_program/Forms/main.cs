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

        //List<String> formName = new List<string>();
        Form formName = null;

        private void home_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(home_btn);

            if (formName != null)
            {
                formName.Close();
            }
        }
        private void mypage_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(mypage_btn);

            Point parentPoint = this.Location; //main 폼 시작 위치 값

            mypage mypage = new mypage();
            mypage.StartPosition = FormStartPosition.Manual;
            //mypage.Location = new Point(parentPoint.X+150, parentPoint.Y+45);
            mypage.Location = new Point(parentPoint.X + 155, parentPoint.Y + 45);
            mypage.Show();
            

            formName = mypage;
        }
        private void issue_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(issue_btn);

            Point parentPoint = this.Location; //main 폼 시작 위치 값

            issue issue = new issue();
            issue.StartPosition = FormStartPosition.Manual;
            issue.Location = new Point(parentPoint.X + 155, parentPoint.Y + 45);
            issue.WindowState = FormWindowState.Minimized;
            issue.Show();

            formName = issue;
        }
        private void search_form_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(search_form_btn);

            Point parentPoint = this.Location; //main 폼 시작 위치 값

            search_form search = new search_form();
            search.StartPosition = FormStartPosition.Manual;
            search.Location = new Point(parentPoint.X + 155, parentPoint.Y + 45);
            search.Show();
        }
        private void help_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(help_btn);

            Point parentPoint = this.Location; //main 폼 시작 위치 값

            help help = new help();
            help.StartPosition = FormStartPosition.Manual;
            help.Location = new Point(parentPoint.X + 155, parentPoint.Y + 45);
            help.Show();
        }

    }
}
