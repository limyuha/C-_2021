using book_management_program.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_management_program
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            MainForm main = new MainForm();
            main.ShowDialog();
            this.Close(); //main 폼 닫으면 로그인 폼도 닫기
            /*
            using (main main_form = new main())
            {
                main_form.ShowDialog();
            }
            */
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            JoinForm join = new JoinForm();
            join.ShowDialog();
        }

        private void manager_btn_Click(object sender, EventArgs e)
        {
            MainManager main_manager = new MainManager();
            main_manager.ShowDialog();
            this.Close();
        }
    }
}
