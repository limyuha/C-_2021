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
            String phone = tel_textBox.Text;
            if (string.IsNullOrWhiteSpace(id) || string.IsNullOrWhiteSpace(pwd) || string.IsNullOrWhiteSpace(phone))
            {

                MessageBox.Show("정보를 입력해주세요", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Member member = new Member();
                member.Mem_nm = id;
                member.Pw = pwd;
                member.Phone_no = phone;

                MemberManager.Member.MemInfoInsert(member);
                this.Close();
            }
        }
    }
}
