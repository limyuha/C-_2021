
namespace book_management_program.Forms
{
    partial class JoinForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.pw_label = new System.Windows.Forms.Label();
            this.pw_textBox = new System.Windows.Forms.TextBox();
            this.id_label = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.close_btn = new System.Windows.Forms.Button();
            this.join_btn = new System.Windows.Forms.Button();
            this.tel_label = new System.Windows.Forms.Label();
            this.tel_textBox = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(2178, 72);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(11, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(287, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "2021C 도서관리 프로그램";
            // 
            // pw_label
            // 
            this.pw_label.AutoSize = true;
            this.pw_label.Location = new System.Drawing.Point(951, 657);
            this.pw_label.Name = "pw_label";
            this.pw_label.Size = new System.Drawing.Size(84, 25);
            this.pw_label.TabIndex = 12;
            this.pw_label.Text = "비밀번호";
            // 
            // pw_textBox
            // 
            this.pw_textBox.Location = new System.Drawing.Point(950, 686);
            this.pw_textBox.Name = "pw_textBox";
            this.pw_textBox.Size = new System.Drawing.Size(278, 31);
            this.pw_textBox.TabIndex = 11;
            // 
            // id_label
            // 
            this.id_label.AutoSize = true;
            this.id_label.Location = new System.Drawing.Point(950, 559);
            this.id_label.Name = "id_label";
            this.id_label.Size = new System.Drawing.Size(66, 25);
            this.id_label.TabIndex = 10;
            this.id_label.Text = "아이디";
            // 
            // id_textBox
            // 
            this.id_textBox.Location = new System.Drawing.Point(950, 587);
            this.id_textBox.Name = "id_textBox";
            this.id_textBox.Size = new System.Drawing.Size(278, 31);
            this.id_textBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("한컴 고딕", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(1047, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "회원가입";
            // 
            // close_btn
            // 
            this.close_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.close_btn.FlatAppearance.BorderSize = 0;
            this.close_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.close_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.close_btn.ForeColor = System.Drawing.Color.White;
            this.close_btn.Location = new System.Drawing.Point(951, 892);
            this.close_btn.Name = "close_btn";
            this.close_btn.Size = new System.Drawing.Size(279, 40);
            this.close_btn.TabIndex = 14;
            this.close_btn.Text = "취소";
            this.close_btn.UseVisualStyleBackColor = false;
            this.close_btn.Click += new System.EventHandler(this.close_btn_Click);
            // 
            // join_btn
            // 
            this.join_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.join_btn.FlatAppearance.BorderSize = 0;
            this.join_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.join_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.join_btn.ForeColor = System.Drawing.Color.White;
            this.join_btn.Location = new System.Drawing.Point(951, 845);
            this.join_btn.Name = "join_btn";
            this.join_btn.Size = new System.Drawing.Size(279, 40);
            this.join_btn.TabIndex = 13;
            this.join_btn.Text = "회원가입";
            this.join_btn.UseVisualStyleBackColor = false;
            this.join_btn.Click += new System.EventHandler(this.join_btn_Click);
            // 
            // tel_label
            // 
            this.tel_label.AutoSize = true;
            this.tel_label.Location = new System.Drawing.Point(950, 752);
            this.tel_label.Name = "tel_label";
            this.tel_label.Size = new System.Drawing.Size(84, 25);
            this.tel_label.TabIndex = 16;
            this.tel_label.Text = "전화번호";
            // 
            // tel_textBox
            // 
            this.tel_textBox.Location = new System.Drawing.Point(949, 781);
            this.tel_textBox.Name = "tel_textBox";
            this.tel_textBox.Size = new System.Drawing.Size(278, 31);
            this.tel_textBox.TabIndex = 15;
            // 
            // JoinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2178, 1444);
            this.Controls.Add(this.tel_label);
            this.Controls.Add(this.tel_textBox);
            this.Controls.Add(this.close_btn);
            this.Controls.Add(this.join_btn);
            this.Controls.Add(this.pw_label);
            this.Controls.Add(this.pw_textBox);
            this.Controls.Add(this.id_label);
            this.Controls.Add(this.id_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Name = "JoinForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "join";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pw_label;
        private System.Windows.Forms.TextBox pw_textBox;
        private System.Windows.Forms.Label id_label;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button close_btn;
        private System.Windows.Forms.Button join_btn;
        private System.Windows.Forms.Label tel_label;
        private System.Windows.Forms.TextBox tel_textBox;
    }
}