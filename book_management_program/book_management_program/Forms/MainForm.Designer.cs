
namespace book_management_program.Forms
{
    partial class MainForm
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
            this.id_name_label = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.help_btn = new System.Windows.Forms.Button();
            this.logout_btn = new System.Windows.Forms.Button();
            this.panelSlide = new System.Windows.Forms.Panel();
            this.issue_btn = new System.Windows.Forms.Button();
            this.search_form_btn = new System.Windows.Forms.Button();
            this.mypage_btn = new System.Windows.Forms.Button();
            this.home_btn = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // id_name_label
            // 
            this.id_name_label.AutoSize = true;
            this.id_name_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.id_name_label.Location = new System.Drawing.Point(36, 47);
            this.id_name_label.Name = "id_name_label";
            this.id_name_label.Size = new System.Drawing.Size(63, 25);
            this.id_name_label.TabIndex = 1;
            this.id_name_label.Text = "회원 님";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.help_btn);
            this.panel2.Controls.Add(this.logout_btn);
            this.panel2.Controls.Add(this.panelSlide);
            this.panel2.Controls.Add(this.issue_btn);
            this.panel2.Controls.Add(this.id_name_label);
            this.panel2.Controls.Add(this.search_form_btn);
            this.panel2.Controls.Add(this.mypage_btn);
            this.panel2.Controls.Add(this.home_btn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(144, 1450);
            this.panel2.TabIndex = 0;
            // 
            // help_btn
            // 
            this.help_btn.FlatAppearance.BorderSize = 0;
            this.help_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.help_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.help_btn.Location = new System.Drawing.Point(1, 447);
            this.help_btn.Name = "help_btn";
            this.help_btn.Size = new System.Drawing.Size(143, 58);
            this.help_btn.TabIndex = 6;
            this.help_btn.Text = "도움말";
            this.help_btn.UseVisualStyleBackColor = true;
            this.help_btn.Click += new System.EventHandler(this.help_btn_Click);
            // 
            // logout_btn
            // 
            this.logout_btn.FlatAppearance.BorderSize = 0;
            this.logout_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.logout_btn.Location = new System.Drawing.Point(1, 383);
            this.logout_btn.Name = "logout_btn";
            this.logout_btn.Size = new System.Drawing.Size(143, 58);
            this.logout_btn.TabIndex = 5;
            this.logout_btn.Text = "로그아웃";
            this.logout_btn.UseVisualStyleBackColor = true;
            this.logout_btn.Click += new System.EventHandler(this.logout_btn_Click);
            // 
            // panelSlide
            // 
            this.panelSlide.BackColor = System.Drawing.Color.White;
            this.panelSlide.Location = new System.Drawing.Point(1, 127);
            this.panelSlide.Name = "panelSlide";
            this.panelSlide.Size = new System.Drawing.Size(16, 58);
            this.panelSlide.TabIndex = 2;
            // 
            // issue_btn
            // 
            this.issue_btn.FlatAppearance.BorderSize = 0;
            this.issue_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.issue_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.issue_btn.Location = new System.Drawing.Point(1, 318);
            this.issue_btn.Name = "issue_btn";
            this.issue_btn.Size = new System.Drawing.Size(143, 58);
            this.issue_btn.TabIndex = 4;
            this.issue_btn.Text = "이슈";
            this.issue_btn.UseVisualStyleBackColor = true;
            this.issue_btn.Click += new System.EventHandler(this.issue_btn_Click);
            // 
            // search_form_btn
            // 
            this.search_form_btn.FlatAppearance.BorderSize = 0;
            this.search_form_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_form_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_form_btn.Location = new System.Drawing.Point(1, 255);
            this.search_form_btn.Name = "search_form_btn";
            this.search_form_btn.Size = new System.Drawing.Size(143, 58);
            this.search_form_btn.TabIndex = 3;
            this.search_form_btn.Text = "도서 검색";
            this.search_form_btn.UseVisualStyleBackColor = true;
            this.search_form_btn.Click += new System.EventHandler(this.search_form_btn_Click);
            // 
            // mypage_btn
            // 
            this.mypage_btn.FlatAppearance.BorderSize = 0;
            this.mypage_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mypage_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mypage_btn.Location = new System.Drawing.Point(0, 192);
            this.mypage_btn.Name = "mypage_btn";
            this.mypage_btn.Size = new System.Drawing.Size(144, 58);
            this.mypage_btn.TabIndex = 2;
            this.mypage_btn.Text = "마이페이지";
            this.mypage_btn.UseVisualStyleBackColor = true;
            this.mypage_btn.Click += new System.EventHandler(this.mypage_btn_Click);
            // 
            // home_btn
            // 
            this.home_btn.FlatAppearance.BorderSize = 0;
            this.home_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.home_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.home_btn.Location = new System.Drawing.Point(0, 127);
            this.home_btn.Name = "home_btn";
            this.home_btn.Size = new System.Drawing.Size(144, 58);
            this.home_btn.TabIndex = 1;
            this.home_btn.Text = "홈";
            this.home_btn.UseVisualStyleBackColor = true;
            this.home_btn.Click += new System.EventHandler(this.home_btn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2184, 1450);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.main_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button search_form_btn;
        private System.Windows.Forms.Button mypage_btn;
        private System.Windows.Forms.Button home_btn;
        private System.Windows.Forms.Label id_name_label;
        private System.Windows.Forms.Button issue_btn;
        private System.Windows.Forms.Panel panelSlide;
        private System.Windows.Forms.Button logout_btn;
        private System.Windows.Forms.Button help_btn;
    }
}