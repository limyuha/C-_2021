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

        private void mypage_btn_Click(object sender, EventArgs e)
        {
            Point parentPoint = this.Location; //main 폼 시작 위치 값

            mypage mypage = new mypage();
            mypage.StartPosition = FormStartPosition.Manual;
            //mypage.Location = new Point(parentPoint.X+150, parentPoint.Y+45);
            mypage.Location = new Point(parentPoint.X + 155, parentPoint.Y + 45);
            mypage.Show();
        }
        private void issue_btn_Click(object sender, EventArgs e)
        {
            
        }
        private void search_form_btn_Click(object sender, EventArgs e)
        {
            Point parentPoint = this.Location; //main 폼 시작 위치 값

            search_form search = new search_form();
            search.StartPosition = FormStartPosition.Manual;
            search.Location = new Point(parentPoint.X + 155, parentPoint.Y + 45);
            search.Show();
        }

    }
}
