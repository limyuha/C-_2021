
namespace book_management_program.Forms
{
    partial class main_manager
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
            this.label1 = new System.Windows.Forms.Label();
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
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.memeber_manager_btn);
            this.panel2.Controls.Add(this.book_manager_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 850);
            this.panel2.TabIndex = 1;
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logout_btn.Location = new System.Drawing.Point(23, 320);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(121, 58);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "로그아웃";
            this.logout_btn.UseVisualStyleBackColor = true;
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(0, 128);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(16, 58);
            this.panelSlide.TabIndex = 2;
            // 
            // issue_manager_btn
            // 
            this.issue_manager_btn.FlatAppearance.BorderSize = 0;
            this.issue_manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_manager_btn.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issue_manager_btn.Location = new System.Drawing.Point(23, 256);
            this.issue_manager_btn.Name = "issue_manager_btn";
            this.issue_manager_btn.Size = new System.Drawing.Size(121, 58);
            this.issue_manager_btn.TabIndex = 4;
            this.issue_manager_btn.Text = "이슈 관리";
            this.issue_manager_btn.UseVisualStyleBackColor = true;
            this.issue_manager_btn.Click += new System.EventHandler(this.issue_manager_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(36, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "관리자님";
            // 
            // memeber_manager_btn
            // 
            this.memeber_manager_btn.FlatAppearance.BorderSize = 0;
            this.memeber_manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memeber_manager_btn.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.memeber_manager_btn.Location = new System.Drawing.Point(23, 192);
            this.memeber_manager_btn.Name = "memeber_manager_btn";
            this.memeber_manager_btn.Size = new System.Drawing.Size(121, 58);
            this.memeber_manager_btn.TabIndex = 3;
            this.memeber_manager_btn.Text = "회원 관리";
            this.memeber_manager_btn.UseVisualStyleBackColor = true;
            this.memeber_manager_btn.Click += new System.EventHandler(this.memeber_manager_btn_Click);
            // 
            // book_manager_btn
            // 
            this.book_manager_btn.FlatAppearance.BorderSize = 0;
            this.book_manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_manager_btn.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_manager_btn.Location = new System.Drawing.Point(23, 128);
            this.book_manager_btn.Name = "book_manager_btn";
            this.book_manager_btn.Size = new System.Drawing.Size(121, 58);
            this.book_manager_btn.TabIndex = 2;
            this.book_manager_btn.Text = "도서 관리";
            this.book_manager_btn.UseVisualStyleBackColor = true;
            this.book_manager_btn.Click += new System.EventHandler(this.book_manager_btn_Click);
            // 
            // main_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1384, 850);
            this.Controls.Add(this.panel2);
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "main_manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "main_manager";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button memeber_manager_btn;
        private System.Windows.Forms.Button book_manager_btn;
    }
}