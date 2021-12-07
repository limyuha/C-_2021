
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
            this.writer = new System.Windows.Forms.ColumnHeader();
            this.title = new System.Windows.Forms.ColumnHeader();
            this.issue_write_btn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // issue_label
            // 
            this.issue_label.AutoSize = true;
            this.issue_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.issue_label.Location = new System.Drawing.Point(167, 148);
            this.issue_label.Name = "issue_label";
            this.issue_label.Size = new System.Drawing.Size(162, 37);
            this.issue_label.TabIndex = 0;
            this.issue_label.Text = "건의 및 이슈";
            // 
            // issue_listView
            // 
            this.issue_listView.BackColor = System.Drawing.Color.White;
            this.issue_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.date,
            this.writer,
            this.title});
            this.issue_listView.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.issue_listView.FullRowSelect = true;
            this.issue_listView.GridLines = true;
            this.issue_listView.HideSelection = false;
            this.issue_listView.Location = new System.Drawing.Point(167, 199);
            this.issue_listView.Name = "issue_listView";
            this.issue_listView.Size = new System.Drawing.Size(1700, 1044);
            this.issue_listView.TabIndex = 1;
            this.issue_listView.UseCompatibleStateImageBehavior = false;
            this.issue_listView.View = System.Windows.Forms.View.Details;
            this.issue_listView.SelectedIndexChanged += new System.EventHandler(this.issue_listView_SelectedIndexChanged);
            // 
            // no
            // 
            this.no.Text = "No.";
            // 
            // date
            // 
            this.date.Text = "작성일";
            this.date.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.date.Width = 300;
            // 
            // writer
            // 
            this.writer.Text = "작성자";
            this.writer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.writer.Width = 200;
            // 
            // title
            // 
            this.title.Text = "제목";
            this.title.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.title.Width = 1130;
            // 
            // issue_write_btn
            // 
            this.issue_write_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_write_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issue_write_btn.Location = new System.Drawing.Point(1752, 140);
            this.issue_write_btn.Name = "issue_write_btn";
            this.issue_write_btn.Size = new System.Drawing.Size(111, 45);
            this.issue_write_btn.TabIndex = 2;
            this.issue_write_btn.Text = "글작성";
            this.issue_write_btn.UseVisualStyleBackColor = true;
            this.issue_write_btn.Click += new System.EventHandler(this.issue_write_btn_Click);
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(1516, 140);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(229, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "내가 작성한 글 보기";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // IssueForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(2034, 1443);
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
        private System.Windows.Forms.Button issue_write_btn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColumnHeader writer;
    }
}