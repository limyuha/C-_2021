using book_management_program.Model;
using book_management_program.Manager;
using System;
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

        private void join_btn_Click(object sender, EventArgs e)
        {
            String id = id_textBox.Text;
            String pwd = pw_textBox.Text;
            if(id!="" && pwd != "")
            {
                Member member = new Member();
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
