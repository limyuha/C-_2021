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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            main m = new main();
            m.ShowDialog();
            this.Close(); //로그인 폼 닫기
            /*
            using (main main_form = new main())
            {
                main_form.ShowDialog();
            }
            */
        }
    }
}
