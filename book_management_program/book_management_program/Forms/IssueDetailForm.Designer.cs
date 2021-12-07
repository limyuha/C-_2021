
namespace book_management_program.Forms
{
    partial class IssueDetailForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.context_textBox = new System.Windows.Forms.TextBox();
            this.context_label = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.title_label = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.context_textBox);
            this.panel1.Location = new System.Drawing.Point(88, 153);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 523);
            this.panel1.TabIndex = 9;
            // 
            // context_textBox
            // 
            this.context_textBox.BackColor = System.Drawing.Color.White;
            this.context_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.context_textBox.Location = new System.Drawing.Point(0, 0);
            this.context_textBox.Multiline = true;
            this.context_textBox.Name = "context_textBox";
            this.context_textBox.ReadOnly = true;
            this.context_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.context_textBox.Size = new System.Drawing.Size(802, 523);
            this.context_textBox.TabIndex = 3;
            // 
            // context_label
            // 
            this.context_label.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.context_label.ForeColor = System.Drawing.Color.Black;
            this.context_label.Location = new System.Drawing.Point(88, 117);
            this.context_label.Name = "context_label";
            this.context_label.Size = new System.Drawing.Size(58, 31);
            this.context_label.TabIndex = 7;
            this.context_label.Text = "내용";
            // 
            // title_textBox
            // 
            this.title_textBox.BackColor = System.Drawing.Color.White;
            this.title_textBox.Location = new System.Drawing.Point(88, 63);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.ReadOnly = true;
            this.title_textBox.Size = new System.Drawing.Size(802, 31);
            this.title_textBox.TabIndex = 6;
            // 
            // title_label
            // 
            this.title_label.Font = new System.Drawing.Font("한컴 고딕", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_label.ForeColor = System.Drawing.Color.Black;
            this.title_label.Location = new System.Drawing.Point(88, 29);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(58, 31);
            this.title_label.TabIndex = 5;
            this.title_label.Text = "제목";
            // 
            // IssueDetailForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(978, 744);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.context_label);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.title_label);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssueDetailForm";
            this.Text = "issue_detail";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox context_textBox;
        private System.Windows.Forms.Label context_label;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Label title_label;
    }
}