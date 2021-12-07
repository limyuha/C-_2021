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
    public partial class IssueWriteForm : Form
    {
        

        public IssueWriteForm()
        {
            InitializeComponent();

        }

        /* 등록 버튼 */
        private void add_btn_Click(object sender, EventArgs e)
        {
            string title = title_textBox.Text; //제목
            string content = context_textBox.Text; //내용

            if (!string.IsNullOrWhiteSpace(title) && !string.IsNullOrWhiteSpace(content)) 
            {
                Issue issue = new Issue();
                issue.Mem_no = MainForm.Mem_no;
                issue.Issue_title = title.TrimStart();
                issue.Issue_text = content;
                IssueManager.Issue.IssueInsert(issue);

                this.DialogResult = DialogResult.OK; 

                this.Close();
            }
            else
            {
                MessageBox.Show("제목과 내용 작성할 것");
            }
        }
    }
}
