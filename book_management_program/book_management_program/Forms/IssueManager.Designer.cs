
namespace book_management_program.Forms
{
    partial class IssueManager
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
            this.issue_manager_listView = new System.Windows.Forms.ListView();
            this.no = new System.Windows.Forms.ColumnHeader();
            this.date = new System.Windows.Forms.ColumnHeader();
            this.title = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.issue_manager_label = new System.Windows.Forms.Label();
            this.issue_delete_btn = new System.Windows.Forms.Button();
            this.no_label = new System.Windows.Forms.Label();
            this.no_textBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // issue_manager_listView
            // 
            this.issue_manager_listView.BackColor = System.Drawing.Color.White;
            this.issue_manager_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.date,
            this.title,
            this.id});
            this.issue_manager_listView.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.issue_manager_listView.GridLines = true;
            this.issue_manager_listView.HideSelection = false;
            this.issue_manager_listView.Location = new System.Drawing.Point(117, 127);
            this.issue_manager_listView.Name = "issue_manager_listView";
            this.issue_manager_listView.Size = new System.Drawing.Size(1000, 650);
            this.issue_manager_listView.TabIndex = 5;
            this.issue_manager_listView.UseCompatibleStateImageBehavior = false;
            this.issue_manager_listView.View = System.Windows.Forms.View.Details;
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
            // issue_manager_label
            // 
            this.issue_manager_label.AutoSize = true;
            this.issue_manager_label.Font = new System.Drawing.Font("한컴 고딕", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.issue_manager_label.Location = new System.Drawing.Point(115, 68);
            this.issue_manager_label.Name = "issue_manager_label";
            this.issue_manager_label.Size = new System.Drawing.Size(252, 42);
            this.issue_manager_label.TabIndex = 4;
            this.issue_manager_label.Text = "건의 및 이슈 관리";
            // 
            // issue_delete_btn
            // 
            this.issue_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_delete_btn.Font = new System.Drawing.Font("한컴 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issue_delete_btn.Location = new System.Drawing.Point(1044, 86);
            this.issue_delete_btn.Name = "issue_delete_btn";
            this.issue_delete_btn.Size = new System.Drawing.Size(70, 33);
            this.issue_delete_btn.TabIndex = 6;
            this.issue_delete_btn.Text = "삭제";
            this.issue_delete_btn.UseVisualStyleBackColor = true;
            // 
            // no_label
            // 
            this.no_label.AutoSize = true;
            this.no_label.Font = new System.Drawing.Font("한컴 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.no_label.Location = new System.Drawing.Point(915, 89);
            this.no_label.Name = "no_label";
            this.no_label.Size = new System.Drawing.Size(49, 29);
            this.no_label.TabIndex = 21;
            this.no_label.Text = "No.";
            // 
            // no_textBox
            // 
            this.no_textBox.BackColor = System.Drawing.Color.White;
            this.no_textBox.Location = new System.Drawing.Point(964, 87);
            this.no_textBox.Name = "no_textBox";
            this.no_textBox.Size = new System.Drawing.Size(70, 31);
            this.no_textBox.TabIndex = 20;
            // 
            // IssueManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1234, 844);
            this.Controls.Add(this.no_label);
            this.Controls.Add(this.no_textBox);
            this.Controls.Add(this.issue_manager_listView);
            this.Controls.Add(this.issue_manager_label);
            this.Controls.Add(this.issue_delete_btn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IssueManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "issue_manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView issue_manager_listView;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader date;
        private System.Windows.Forms.ColumnHeader title;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.Label issue_manager_label;
        private System.Windows.Forms.Button issue_delete_btn;
        private System.Windows.Forms.Label no_label;
        private System.Windows.Forms.TextBox no_textBox;
    }
}