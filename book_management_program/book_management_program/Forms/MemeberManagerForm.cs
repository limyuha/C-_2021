using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using book_management_program.Model;
using book_management_program.Manager;

namespace book_management_program.Forms
{
    public partial class MemeberManagerForm : Form
    {
        public MemeberManagerForm()
        {
            InitializeComponent();
            ListViewConn();
            this.no_textBox.Enabled = false;
        }

        // 회원 목록 
        private void ListViewConn()
        {
            List<Member> list = new List<Member>();
            list = MemberManager.Member.MemList(); //불러오기

            ListViewItem item;

            this.member_manager_listView.Items.Clear();

            this.member_manager_listView.BeginUpdate();
            foreach (Member member in list)
            {
                item = new ListViewItem(member.Mem_no.ToString());
                item.SubItems.Add(member.Mem_nm.ToString());
                item.SubItems.Add(member.Pw.ToString());
                item.SubItems.Add(member.Phone_no.ToString());
                if (member.Mem_grade.ToString()=="NOR")
                {
                    item.SubItems.Add("일반회원");
                }
                else
                {

                    item.SubItems.Add("관리자");
                }

                this.member_manager_listView.Items.Add(item);
            }
            this.member_manager_listView.EndUpdate();
            Invalidate();
        }

        //회원 추가
        private void member_add_btn_Click(object sender, EventArgs e)
        {
            if (this.id_textBox.Enabled == false)
            {
                this.no_textBox.Clear();
                this.id_textBox.Clear();
                this.pw_textBox.Clear();
                this.tel_textBox.Clear();

                this.id_textBox.Enabled = true;
                this.pw_textBox.Enabled = true;
                this.tel_textBox.Enabled = true;
            }
            else
            {
                if (string.IsNullOrWhiteSpace(this.id_textBox.Text) || string.IsNullOrWhiteSpace(this.pw_textBox.Text) || string.IsNullOrWhiteSpace(this.tel_textBox.Text))
                {

                    MessageBox.Show("정보를 입력해주세요", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    if (MemberManager.Member.IdReCheck(this.id_textBox.Text))
                    {
                        Member member = new Member();

                        //member.Mem_no = Int32.Parse(this.no_textBox.Text);
                        member.Mem_nm = this.id_textBox.Text;
                        member.Pw = this.pw_textBox.Text;
                        //member.Mem_grade = "NOR";
                        member.Phone_no = this.tel_textBox.Text;

                        MemberManager.Member.MemInfoInsert(member);
                        this.no_textBox.Clear();
                        this.id_textBox.Clear();
                        this.pw_textBox.Clear();
                        this.tel_textBox.Clear();
                    }
                }
            }

            ListViewConn();
        }

        //회원 삭제
        private void member_delete_btn_Click(object sender, EventArgs e)
        {
            if (MemberManager.Member.MemInfoDelete(Int32.Parse(this.no_textBox.Text)))
            {
                this.no_textBox.Clear();
                this.id_textBox.Clear();
                this.pw_textBox.Clear();
                this.tel_textBox.Clear();
                ListViewConn();
            }
        }

        /*
        private void member_manager_listView_ItemActivate(object sender, EventArgs e)
        {
            if (member_manager_listView.SelectedIndices.Count > 0)
            {

                int where = member_manager_listView.SelectedIndices[0];
                if (member_manager_listView.Items[where].SubItems[0].Text == this.no_textBox.Text)
                {
                    this.no_textBox.Clear();
                    this.id_textBox.Clear();
                    this.pw_textBox.Clear();
                    this.tel_textBox.Clear();
                    this.no_textBox.Enabled = true;
                    this.id_textBox.Enabled = true;
                    this.pw_textBox.Enabled = true;
                    this.tel_textBox.Enabled = true;
                    this.member_add_btn.Enabled = true;
                }
                else
                {
                    this.no_textBox.Text = member_manager_listView.Items[where].SubItems[0].Text;
                    this.id_textBox.Text = member_manager_listView.Items[where].SubItems[1].Text;
                    this.pw_textBox.Text = member_manager_listView.Items[where].SubItems[2].Text;
                    this.tel_textBox.Text = member_manager_listView.Items[where].SubItems[3].Text;
                    this.no_textBox.Enabled = false;
                    this.id_textBox.Enabled = false;
                    this.pw_textBox.Enabled = false;
                    this.tel_textBox.Enabled = false;
                    this.member_add_btn.Enabled = false;
                }

            }
        }*/

        //회원 선택
        private void member_manager_listView_ItemActivate_1(object sender, EventArgs e)
        {
            int where = 0;

            if (member_manager_listView.SelectedIndices.Count > 0)
            {
                where = member_manager_listView.SelectedIndices[0];

                this.no_textBox.Text = member_manager_listView.Items[where].SubItems[0].Text;
                this.id_textBox.Text = member_manager_listView.Items[where].SubItems[1].Text;
                this.pw_textBox.Text = member_manager_listView.Items[where].SubItems[2].Text;
                this.tel_textBox.Text = member_manager_listView.Items[where].SubItems[3].Text;

                this.id_textBox.Enabled = false;
                this.pw_textBox.Enabled = false;
                this.tel_textBox.Enabled = false;
            }
        }

        //지우기 버튼
        private void label4_DoubleClick(object sender, EventArgs e)
        {
            this.no_textBox.Clear();
            this.id_textBox.Clear();
            this.pw_textBox.Clear();
            this.tel_textBox.Clear();

            this.id_textBox.Enabled = true;
            this.pw_textBox.Enabled = true;
            this.tel_textBox.Enabled = true;
        }
    }
}
