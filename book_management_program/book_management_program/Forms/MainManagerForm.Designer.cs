
namespace book_management_program.Forms
{
    partial class MainManagerForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.logout_btn = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.issue_manager_btn = new System.Windows.Forms.Button();
            this.manager_label = new System.Windows.Forms.Label();
            this.memeber_manager_btn = new System.Windows.Forms.Button();
            this.book_manager_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Controls.Add(this.issue_manager_btn);
            this.panel2.Controls.Add(this.manager_label);
            this.panel2.Controls.Add(this.memeber_manager_btn);
            this.panel2.Controls.Add(this.book_manager_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 510);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logout_btn.Location = new System.Drawing.Point(16, 192);
            this.logout_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(85, 35);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "로그아웃";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 77);
            this.panelSlide.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(11, 35);
            this.panelSlide.TabIndex = 2;
            // 
            // issue_manager_btn
            // 
            this.issue_manager_btn.FlatAppearance.BorderSize = 0;
            this.issue_manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issue_manager_btn.Location = new System.Drawing.Point(16, 154);
            this.issue_manager_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.issue_manager_btn.Name = "issue_manager_btn";
            this.issue_manager_btn.Size = new System.Drawing.Size(85, 35);
            this.issue_manager_btn.TabIndex = 4;
            this.issue_manager_btn.Text = "이슈 관리";
            this.issue_manager_btn.UseVisualStyleBackColor = true;
            this.issue_manager_btn.Click += new System.EventHandler(this.issue_manager_btn_Click);
            // 
            // manager_label
            // 
            this.manager_label.AutoSize = true;
            this.manager_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manager_label.Location = new System.Drawing.Point(25, 28);
            this.manager_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.manager_label.Name = "manager_label";
            this.manager_label.Size = new System.Drawing.Size(56, 17);
            this.manager_label.TabIndex = 1;
            this.manager_label.Text = "관리자님";
            // 
            // memeber_manager_btn
            // 
            this.memeber_manager_btn.FlatAppearance.BorderSize = 0;
            this.memeber_manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memeber_manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memeber_manager_btn.Location = new System.Drawing.Point(16, 115);
            this.memeber_manager_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.memeber_manager_btn.Name = "memeber_manager_btn";
            this.memeber_manager_btn.Size = new System.Drawing.Size(85, 35);
            this.memeber_manager_btn.TabIndex = 3;
            this.memeber_manager_btn.Text = "회원 관리";
            this.memeber_manager_btn.UseVisualStyleBackColor = true;
            this.memeber_manager_btn.Click += new System.EventHandler(this.memeber_manager_btn_Click);
            // 
            // book_manager_btn
            // 
            this.book_manager_btn.FlatAppearance.BorderSize = 0;
            this.book_manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_manager_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_manager_btn.Location = new System.Drawing.Point(16, 77);
            this.book_manager_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.book_manager_btn.Name = "book_manager_btn";
            this.book_manager_btn.Size = new System.Drawing.Size(85, 35);
            this.book_manager_btn.TabIndex = 2;
            this.book_manager_btn.Text = "도서 관리";
            this.book_manager_btn.UseVisualStyleBackColor = true;
            this.book_manager_btn.Click += new System.EventHandler(this.book_manager_btn_Click);
            // 
            // MainManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(969, 510);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainManager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "main_manager";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainManager_FormClosing);
            this.Load += new System.EventHandler(this.main_manager_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button issue_manager_btn;
        private System.Windows.Forms.Label manager_label;
        private System.Windows.Forms.Button memeber_manager_btn;
        private System.Windows.Forms.Button book_manager_btn;
    }
}