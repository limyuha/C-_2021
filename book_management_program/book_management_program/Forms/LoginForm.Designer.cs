
namespace book_management_program.Forms
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.manager_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.pw_textBox = new System.Windows.Forms.TextBox();
            this.login_btn = new System.Windows.Forms.Button();
            this.join_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.manager_btn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1378, 71);
            this.panel1.TabIndex = 0;
            // 
            // manager_btn
            // 
            this.manager_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.manager_btn.FlatAppearance.BorderSize = 0;
            this.manager_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manager_btn.Font = new System.Drawing.Font("한컴 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.manager_btn.ForeColor = System.Drawing.Color.White;
            this.manager_btn.Location = new System.Drawing.Point(1254, 16);
            this.manager_btn.Name = "manager_btn";
            this.manager_btn.Size = new System.Drawing.Size(111, 40);
            this.manager_btn.TabIndex = 8;
            this.manager_btn.Text = "관리자";
            this.manager_btn.UseVisualStyleBackColor = false;
            this.manager_btn.Click += new System.EventHandler(this.manager_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴산뜻돋움", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "2021C 도서관리 프로그램";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(593, 259);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(199, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "로그인 먼저 해주세요.";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(550, 343);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(278, 31);
            this.id_textBox.TabIndex = 2;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(550, 315);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(66, 25);
            this.id_label.TabIndex = 3;
            this.id_label.Text = "아이디";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(550, 414);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(84, 25);
            this.pw_label.TabIndex = 5;
            this.pw_label.Text = "비밀번호";
            // 
            // pw_textBox
            // 
            this.pw_textBox.Location = new System.Drawing.Point(550, 442);
            this.pw_textBox.Name = "pw_textBox";
            this.pw_textBox.Size = new System.Drawing.Size(278, 31);
            this.pw_textBox.TabIndex = 4;
            // 
            // login_btn
            // 
            this.login_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.login_btn.FlatAppearance.BorderSize = 0;
            this.login_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.login_btn.Font = new System.Drawing.Font("한컴 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.login_btn.ForeColor = System.Drawing.Color.White;
            this.login_btn.Location = new System.Drawing.Point(550, 500);
            this.login_btn.Name = "login_btn";
            this.login_btn.Size = new System.Drawing.Size(278, 40);
            this.login_btn.TabIndex = 6;
            this.login_btn.Text = "로그인";
            this.login_btn.UseVisualStyleBackColor = false;
            this.login_btn.Click += new System.EventHandler(this.login_btn_Click);
            // 
            // join_btn
            // 
            this.join_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.join_btn.FlatAppearance.BorderSize = 0;
            this.join_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join_btn.Font = new System.Drawing.Font("한컴 고딕", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.join_btn.ForeColor = System.Drawing.Color.White;
            this.join_btn.Location = new System.Drawing.Point(550, 546);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(278, 40);
            this.join_btn.TabIndex = 7;
            this.join_btn.Text = "회원가입";
            this.join_btn.UseVisualStyleBackColor = false;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1378, 844);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.login_btn);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.pw_textBox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox pw_textBox;
        private System.Windows.Forms.Button login_btn;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.Button manager_btn;
    }
}

