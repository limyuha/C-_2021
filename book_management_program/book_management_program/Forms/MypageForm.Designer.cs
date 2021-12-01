
namespace book_management_program.Forms
{
    partial class MypageForm
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
            this.rent_listView = new System.Windows.Forms.ListView();
            this.rent_booknumber = new System.Windows.Forms.ColumnHeader();
            this.rent_bookname = new System.Windows.Forms.ColumnHeader();
            this.rent_bookwrite = new System.Windows.Forms.ColumnHeader();
            this.rent_publisher = new System.Windows.Forms.ColumnHeader();
            this.rent_date = new System.Windows.Forms.ColumnHeader();
            this.rent_return = new System.Windows.Forms.ColumnHeader();
            this.rent_book = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rent_extend_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.rent_bookname_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.rent_booknumber_textBox = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.resv_listView = new System.Windows.Forms.ListView();
            this.resv_booknumber = new System.Windows.Forms.ColumnHeader();
            this.resv_bookname = new System.Windows.Forms.ColumnHeader();
            this.resv_bookwrite = new System.Windows.Forms.ColumnHeader();
            this.resv_publisher = new System.Windows.Forms.ColumnHeader();
            this.resv_rent = new System.Windows.Forms.ColumnHeader();
            this.resv_book = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rent_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.resv_bookname_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.resv_booknumber_textBox = new System.Windows.Forms.TextBox();
            this.cat_no = new System.Windows.Forms.ColumnHeader();
            this.pub_dt = new System.Windows.Forms.ColumnHeader();
            this.resv_cat_no = new System.Windows.Forms.ColumnHeader();
            this.resv_pub_dt = new System.Windows.Forms.ColumnHeader();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rent_listView);
            this.panel1.Controls.Add(this.rent_book);
            this.panel1.Location = new System.Drawing.Point(24, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 350);
            this.panel1.TabIndex = 0;
            // 
            // rent_listView
            // 
            this.rent_listView.BackColor = System.Drawing.Color.White;
            this.rent_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.rent_booknumber,
            this.cat_no,
            this.rent_bookwrite,
            this.rent_publisher,
            this.pub_dt,
            this.rent_bookname,
            this.rent_date,
            this.rent_return});
            this.rent_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.rent_listView.FullRowSelect = true;
            this.rent_listView.HideSelection = false;
            this.rent_listView.Location = new System.Drawing.Point(0, 83);
            this.rent_listView.Name = "rent_listView";
            this.rent_listView.Size = new System.Drawing.Size(900, 267);
            this.rent_listView.TabIndex = 1;
            this.rent_listView.UseCompatibleStateImageBehavior = false;
            this.rent_listView.View = System.Windows.Forms.View.Details;
            this.rent_listView.Click += new System.EventHandler(this.rent_listView_Click);
            // 
            // rent_booknumber
            // 
            this.rent_booknumber.Text = "ISBN";
            this.rent_booknumber.Width = 112;
            // 
            // rent_bookname
            // 
            this.rent_bookname.Text = "도서명";
            this.rent_bookname.Width = 112;
            // 
            // rent_bookwrite
            // 
            this.rent_bookwrite.Text = "저자";
            this.rent_bookwrite.Width = 112;
            // 
            // rent_publisher
            // 
            this.rent_publisher.Text = "출판사";
            this.rent_publisher.Width = 112;
            // 
            // rent_date
            // 
            this.rent_date.Text = "대여일";
            this.rent_date.Width = 112;
            // 
            // rent_return
            // 
            this.rent_return.Text = "반납일";
            this.rent_return.Width = 112;
            // 
            // rent_book
            // 
            this.rent_book.AutoSize = true;
            this.rent_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rent_book.Location = new System.Drawing.Point(-3, 23);
            this.rent_book.Name = "rent_book";
            this.rent_book.Size = new System.Drawing.Size(177, 32);
            this.rent_book.TabIndex = 0;
            this.rent_book.Text = "내가 대여한 도서";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.rent_extend_btn);
            this.panel2.Controls.Add(this.return_btn);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.rent_bookname_textBox);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.rent_booknumber_textBox);
            this.panel2.Location = new System.Drawing.Point(949, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(259, 350);
            this.panel2.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(119, 197);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 21);
            this.label5.TabIndex = 25;
            this.label5.Text = "7일 연장됩니다.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(40, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 21);
            this.label2.TabIndex = 24;
            this.label2.Text = "* 대여 연장은 1회 한정";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(9, 175);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 21);
            this.label1.TabIndex = 23;
            this.label1.Text = "* 대여 연장은 1회 한정";
            // 
            // rent_extend_btn
            // 
            this.rent_extend_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.rent_extend_btn.FlatAppearance.BorderSize = 0;
            this.rent_extend_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_extend_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rent_extend_btn.ForeColor = System.Drawing.Color.White;
            this.rent_extend_btn.Location = new System.Drawing.Point(9, 228);
            this.rent_extend_btn.Name = "rent_extend_btn";
            this.rent_extend_btn.Size = new System.Drawing.Size(234, 48);
            this.rent_extend_btn.TabIndex = 22;
            this.rent_extend_btn.Text = "대여 연장";
            this.rent_extend_btn.UseVisualStyleBackColor = false;
            this.rent_extend_btn.Click += new System.EventHandler(this.rent_extend_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.return_btn.ForeColor = System.Drawing.Color.White;
            this.return_btn.Location = new System.Drawing.Point(9, 290);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(234, 48);
            this.return_btn.TabIndex = 21;
            this.return_btn.Text = "반납";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(9, 97);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 26);
            this.label11.TabIndex = 20;
            this.label11.Text = "도서명";
            // 
            // rent_bookname_textBox
            // 
            this.rent_bookname_textBox.BackColor = System.Drawing.Color.White;
            this.rent_bookname_textBox.Location = new System.Drawing.Point(9, 128);
            this.rent_bookname_textBox.Name = "rent_bookname_textBox";
            this.rent_bookname_textBox.ReadOnly = true;
            this.rent_bookname_textBox.Size = new System.Drawing.Size(234, 31);
            this.rent_bookname_textBox.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(9, 13);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "도서번호";
            // 
            // rent_booknumber_textBox
            // 
            this.rent_booknumber_textBox.BackColor = System.Drawing.Color.White;
            this.rent_booknumber_textBox.Location = new System.Drawing.Point(9, 45);
            this.rent_booknumber_textBox.Name = "rent_booknumber_textBox";
            this.rent_booknumber_textBox.ReadOnly = true;
            this.rent_booknumber_textBox.Size = new System.Drawing.Size(234, 31);
            this.rent_booknumber_textBox.TabIndex = 17;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.resv_listView);
            this.panel3.Controls.Add(this.resv_book);
            this.panel3.Location = new System.Drawing.Point(24, 457);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(900, 350);
            this.panel3.TabIndex = 2;
            // 
            // resv_listView
            // 
            this.resv_listView.BackColor = System.Drawing.Color.White;
            this.resv_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.resv_booknumber,
            this.resv_cat_no,
            this.resv_bookwrite,
            this.resv_publisher,
            this.resv_pub_dt,
            this.resv_bookname,
            this.resv_rent});
            this.resv_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.resv_listView.FullRowSelect = true;
            this.resv_listView.HideSelection = false;
            this.resv_listView.Location = new System.Drawing.Point(0, 83);
            this.resv_listView.Name = "resv_listView";
            this.resv_listView.Size = new System.Drawing.Size(900, 267);
            this.resv_listView.TabIndex = 1;
            this.resv_listView.UseCompatibleStateImageBehavior = false;
            this.resv_listView.View = System.Windows.Forms.View.Details;
            this.resv_listView.SelectedIndexChanged += new System.EventHandler(this.resv_listView_SelectedIndexChanged);
            this.resv_listView.Click += new System.EventHandler(this.resv_listView_Click);
            // 
            // resv_booknumber
            // 
            this.resv_booknumber.Text = "ISBN";
            this.resv_booknumber.Width = 128;
            // 
            // resv_bookname
            // 
            this.resv_bookname.Text = "도서명";
            this.resv_bookname.Width = 128;
            // 
            // resv_bookwrite
            // 
            this.resv_bookwrite.Text = "저자";
            this.resv_bookwrite.Width = 128;
            // 
            // resv_publisher
            // 
            this.resv_publisher.Text = "출판사";
            this.resv_publisher.Width = 128;
            // 
            // resv_rent
            // 
            this.resv_rent.Text = "대여 가능";
            this.resv_rent.Width = 128;
            // 
            // resv_book
            // 
            this.resv_book.AutoSize = true;
            this.resv_book.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resv_book.Location = new System.Drawing.Point(-3, 23);
            this.resv_book.Name = "resv_book";
            this.resv_book.Size = new System.Drawing.Size(177, 32);
            this.resv_book.TabIndex = 0;
            this.resv_book.Text = "내가 예약한 도서";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rent_btn);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Controls.Add(this.resv_bookname_textBox);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.resv_booknumber_textBox);
            this.panel4.Location = new System.Drawing.Point(949, 540);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(259, 267);
            this.panel4.TabIndex = 22;
            // 
            // rent_btn
            // 
            this.rent_btn.BackColor = System.Drawing.Color.Fuchsia;
            this.rent_btn.FlatAppearance.BorderSize = 0;
            this.rent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rent_btn.ForeColor = System.Drawing.Color.White;
            this.rent_btn.Location = new System.Drawing.Point(9, 187);
            this.rent_btn.Name = "rent_btn";
            this.rent_btn.Size = new System.Drawing.Size(234, 48);
            this.rent_btn.TabIndex = 23;
            this.rent_btn.Text = "대여";
            this.rent_btn.UseVisualStyleBackColor = false;
            this.rent_btn.Click += new System.EventHandler(this.rent_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(9, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 26);
            this.label3.TabIndex = 20;
            this.label3.Text = "도서명";
            // 
            // resv_bookname_textBox
            // 
            this.resv_bookname_textBox.BackColor = System.Drawing.Color.White;
            this.resv_bookname_textBox.Location = new System.Drawing.Point(9, 128);
            this.resv_bookname_textBox.Name = "resv_bookname_textBox";
            this.resv_bookname_textBox.ReadOnly = true;
            this.resv_bookname_textBox.Size = new System.Drawing.Size(234, 31);
            this.resv_bookname_textBox.TabIndex = 19;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(9, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "도서번호";
            // 
            // resv_booknumber_textBox
            // 
            this.resv_booknumber_textBox.BackColor = System.Drawing.Color.White;
            this.resv_booknumber_textBox.Location = new System.Drawing.Point(9, 45);
            this.resv_booknumber_textBox.Name = "resv_booknumber_textBox";
            this.resv_booknumber_textBox.ReadOnly = true;
            this.resv_booknumber_textBox.Size = new System.Drawing.Size(234, 31);
            this.resv_booknumber_textBox.TabIndex = 17;
            // 
            // cat_no
            // 
            this.cat_no.Text = "분류";
            this.cat_no.Width = 112;
            // 
            // pub_dt
            // 
            this.pub_dt.Text = "발행일";
            this.pub_dt.Width = 112;
            // 
            // resv_cat_no
            // 
            this.resv_cat_no.Text = "분류";
            this.resv_cat_no.Width = 128;
            // 
            // resv_pub_dt
            // 
            this.resv_pub_dt.Text = "발행일";
            this.resv_pub_dt.Width = 128;
            // 
            // MypageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 843);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MypageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "mypage";
            this.Load += new System.EventHandler(this.MypageForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView rent_listView;
        private System.Windows.Forms.Label rent_book;
        private System.Windows.Forms.ColumnHeader rent_booknumber;
        private System.Windows.Forms.ColumnHeader rent_bookname;
        private System.Windows.Forms.ColumnHeader rent_bookwrite;
        private System.Windows.Forms.ColumnHeader rent_publisher;
        private System.Windows.Forms.ColumnHeader rent_date;
        private System.Windows.Forms.ColumnHeader rent_return;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox rent_bookname_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox rent_booknumber_textBox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ListView resv_listView;
        private System.Windows.Forms.ColumnHeader resv_booknumber;
        private System.Windows.Forms.ColumnHeader resv_bookname;
        private System.Windows.Forms.ColumnHeader resv_bookwrite;
        private System.Windows.Forms.ColumnHeader resv_publisher;
        private System.Windows.Forms.ColumnHeader resv_rent;
        private System.Windows.Forms.Label resv_book;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resv_bookname_textBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox resv_booknumber_textBox;
        private System.Windows.Forms.Button rent_btn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button rent_extend_btn;
        private System.Windows.Forms.ColumnHeader cat_no;
        private System.Windows.Forms.ColumnHeader pub_dt;
        private System.Windows.Forms.ColumnHeader resv_cat_no;
        private System.Windows.Forms.ColumnHeader resv_pub_dt;
    }
}