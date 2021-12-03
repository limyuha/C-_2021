using book_management_program.Forms;
using book_management_program.Manager;
using book_management_program.Util;
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
    public partial class LoginForm : Form
    {
        

        public LoginForm()
        {
            InitializeComponent();
            this.id_textBox.Text = "";
            this.pw_textBox.Text = "";
        }

        private string id, pwd; //사용자 입력 아이디, 비밀번호

        private void login_btn_Click(object sender, EventArgs e)
        {
            id = this.id_textBox.Text;
            pwd = this.pw_textBox.Text;

            if (id != "" && pwd != "")
            {   //회원 로그인 체크
                if (MemberManager.Member.MemLogin(id,pwd))
                {
                    MainForm mainform = new MainForm(id);
                    this.Hide(); //1.login 폼 숨김
                    mainform.ShowDialog(); //2. main 폼 보이기
                    this.Close(); //3. login 폼 닫기
                }
                else
                {
                    MessageBox.Show("로그인에 실패했습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("로그인 정보를 입력해주세요", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void join_btn_Click(object sender, EventArgs e)
        {
            JoinForm join = new JoinForm();
            join.ShowDialog();
        }

        private void manager_btn_Click(object sender, EventArgs e)
        {
            id = this.id_textBox.Text;
            pwd = this.pw_textBox.Text;

            if (id != "" && pwd != "")
            {   //관리자 로그인 체크
                if (MemberManager.Member.MemLogin(id, pwd))
                {
                    MainManager main_manager = new MainManager();
                    this.Hide(); //1.login 폼 숨김
                    main_manager.ShowDialog(); //2. main_manager 폼 보이기
                    this.Close(); //3. login 폼 닫기
                }
                else
                {
                    MessageBox.Show("로그인에 실패했습니다.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("로그인 정보를 입력해주세요", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
