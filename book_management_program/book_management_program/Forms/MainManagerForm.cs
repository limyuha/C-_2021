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
    public partial class MainManagerForm : Form
    {
        public MainManagerForm()
        {
            InitializeComponent();
        }
        private void movePanelSlide(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        Form formName = null;

        private void closeForm()
        {
            formName.Hide();
            formName.Close();
        }

        private void main_manager_Load(object sender, EventArgs e)
        {
            book_manager_Form book_manager = new book_manager_Form();
            book_manager.MdiParent = this;
            book_manager.Show();

            formName = book_manager;
        }

        private void book_manager_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(book_manager_btn);
            if (formName != null)
            {
                closeForm();
            }

            book_manager_Form book_manager = new book_manager_Form();
            book_manager.MdiParent = this;
            book_manager.Show();

            formName = book_manager;
        }

        private void memeber_manager_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(memeber_manager_btn);
            if (formName != null)
            {
                closeForm();
            }

            MemeberManagerForm memeber_manager = new MemeberManagerForm();
            memeber_manager.MdiParent = this;
            memeber_manager.Show();

            formName = memeber_manager;
        }

        private void issue_manager_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(issue_manager_btn);
            if (formName != null)
            {
                closeForm();
            }

            IssueManagerForm issue_manager = new IssueManagerForm();
            issue_manager.MdiParent = this;
            issue_manager.Show();

            formName = issue_manager;
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            Application.ExitThread(); //스레드 종료
            //Application.Exit() → FormClosing → FormClosed
        }

        private void MainManager_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread(); //스레드 종료
        }
    }
}
