using book_management_program.Manager;
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
    public partial class JoinForm : Form
    {
        public JoinForm()
        {
            InitializeComponent();
        }

        private void close_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private Model.Member member = new Model.Member();

        private void join_btn_Click(object sender, EventArgs e)
        {
            String id = id_textBox.Text;
            String pwd = pw_textBox.Text;
            if(id!="" && pwd != "")
            {
                if (MemberManager.MemInfoInsert(member))
                {
                    MessageBox.Show("회원가입이 완료되었습니다.", "", MessageBoxButtons.OK);
                }
                else
                {
                    MessageBox.Show("회원가입에 실패했습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("정보를 입력해주세요", "", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
    }
}
