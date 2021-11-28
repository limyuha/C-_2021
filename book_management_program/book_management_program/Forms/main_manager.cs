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
    public partial class main_manager : Form
    {
        public main_manager()
        {
            InitializeComponent();
        }
        private void movePanelSlide(Control btn)
        {
            panelSlide.Top = btn.Top;
            panelSlide.Height = btn.Height;
        }

        Form formName = null;

        private void main_manager_Load(object sender, EventArgs e)
        {
            book_manager book_manager = new book_manager();
            book_manager.MdiParent = this;
            book_manager.Show();

            formName = book_manager;
        }

        private void book_manager_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(book_manager_btn);
            if (formName != null)
            {
                formName.Close();
            }

            book_manager book_manager = new book_manager();
            book_manager.MdiParent = this;
            book_manager.Show();

            formName = book_manager;
        }

        private void memeber_manager_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(memeber_manager_btn);
            if (formName != null)
            {
                formName.Close();
            }

            memeber_manager memeber_manager = new memeber_manager();
            memeber_manager.MdiParent = this;
            memeber_manager.Show();

            formName = memeber_manager;
        }

        private void issue_manager_btn_Click(object sender, EventArgs e)
        {
            movePanelSlide(issue_manager_btn);
            if (formName != null)
            {
                formName.Close();
            }

            issue_manager issue_manager = new issue_manager();
            issue_manager.MdiParent = this;
            issue_manager.Show();

            formName = issue_manager;
        }
    }
}
