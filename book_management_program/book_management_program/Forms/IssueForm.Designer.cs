
namespace book_management_program.Forms
{
    partial class IssueForm
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
            this.issue_label = new System.Windows.Forms.Label();
            this.issue_listView = new System.Windows.Forms.ListView();
            this.no = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.title = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.issue_write_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // issue_label
            // 
            this.issue_label.AutoSize = true;
            this.issue_label.Font = new System.Drawing.Font("한컴 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.issue_label.Location = new System.Drawing.Point(114, 61);
            this.issue_label.Name = "issue_label";
            this.issue_label.Size = new System.Drawing.Size(184, 42);
            this.issue_label.TabIndex = 0;
            this.issue_label.Text = "건의 및 이슈";
            // 
            // issue_listView
            // 
            this.issue_listView.BackColor = System.Drawing.Color.White;
            this.issue_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.date,
            this.title,
            this.id});
            this.issue_listView.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.issue_listView.GridLines = true;
            this.issue_listView.HideSelection = false;
            this.issue_listView.Location = new System.Drawing.Point(117, 120);
            this.issue_listView.Name = "issue_listView";
            this.issue_listView.Size = new System.Drawing.Size(1000, 650);
            this.issue_listView.TabIndex = 1;
            this.issue_listView.UseCompatibleStateImageBehavior = false;
            this.issue_listView.View = System.Windows.Forms.View.Details;
            // 
            // no
            // 
            this.no.Text = "No.";
            // 
            // date
            // 
            this.date.Text = "작성일";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 100;
            // 
            // title
            // 
            this.title.Text = "제목";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 740;
            // 
            // id
            // 
            this.id.Text = "작성자";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.id.Width = 100;
            // 
            // issue_write_btn
            // 
            this.issue_write_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_write_btn.Font = new System.Drawing.Font("한컴 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issue_write_btn.Location = new System.Drawing.Point(1005, 69);
            this.issue_write_btn.Name = "issue_write_btn";
            this.issue_write_btn.Size = new System.Drawing.Size(112, 45);
            this.issue_write_btn.TabIndex = 2;
            this.issue_write_btn.Text = "글작성";
            this.issue_write_btn.UseVisualStyleBackColor = true;
            this.issue_write_btn.Click += new System.EventHandler(this.issue_write_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("한컴 고딕", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(770, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "내가 작성한 글 보기";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1234, 844);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.issue_write_btn);
            this.Controls.Add(this.issue_listView);
            this.Controls.Add(this.issue_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "issue";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label issue_label;
        private System.Windows.Forms.ListView issue_listView;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Button issue_write_btn;
        private System.Windows.Forms.Button button1;
    }
}