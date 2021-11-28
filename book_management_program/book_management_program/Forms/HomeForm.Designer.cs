
namespace book_management_program.Forms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.resv_checkBox = new System.Windows.Forms.CheckBox();
            this.rent_checkBox = new System.Windows.Forms.CheckBox();
            this.resv_btn = new System.Windows.Forms.Button();
            this.return_btn = new System.Windows.Forms.Button();
            this.rent_btn = new System.Windows.Forms.Button();
            this.bookname_label = new System.Windows.Forms.Label();
            this.bookname_textBox = new System.Windows.Forms.TextBox();
            this.booknumber_label = new System.Windows.Forms.Label();
            this.booknumber_textBox = new System.Windows.Forms.TextBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.book_label = new System.Windows.Forms.Label();
            this.book_listView = new System.Windows.Forms.ListView();
            this.book_number = new System.Windows.Forms.ColumnHeader();
            this.book_name = new System.Windows.Forms.ColumnHeader();
            this.book_writer = new System.Windows.Forms.ColumnHeader();
            this.book_publisher = new System.Windows.Forms.ColumnHeader();
            this.book_stock = new System.Windows.Forms.ColumnHeader();
            this.book_rentsum = new System.Windows.Forms.ColumnHeader();
            this.panel6 = new System.Windows.Forms.Panel();
            this.rent_avg_labels = new System.Windows.Forms.Label();
            this.rent_avg_label = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.rent_sum_labels = new System.Windows.Forms.Label();
            this.rent_sum_label = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.book_count_labels = new System.Windows.Forms.Label();
            this.book_count_label = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ranking_label = new System.Windows.Forms.Label();
            this.ranking_listView = new System.Windows.Forms.ListView();
            this.ranking_no = new System.Windows.Forms.ColumnHeader();
            this.ranking_booknumber = new System.Windows.Forms.ColumnHeader();
            this.ranking_bookname = new System.Windows.Forms.ColumnHeader();
            this.ranking_writer = new System.Windows.Forms.ColumnHeader();
            this.ranking_publisher = new System.Windows.Forms.ColumnHeader();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.resv_checkBox);
            this.groupBox1.Controls.Add(this.rent_checkBox);
            this.groupBox1.Controls.Add(this.resv_btn);
            this.groupBox1.Controls.Add(this.return_btn);
            this.groupBox1.Controls.Add(this.rent_btn);
            this.groupBox1.Controls.Add(this.bookname_label);
            this.groupBox1.Controls.Add(this.bookname_textBox);
            this.groupBox1.Controls.Add(this.booknumber_label);
            this.groupBox1.Controls.Add(this.booknumber_textBox);
            this.groupBox1.Location = new System.Drawing.Point(647, 213);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(205, 286);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대여 / 반납 / 에약";
            // 
            // resv_checkBox
            // 
            this.resv_checkBox.AutoSize = true;
            this.resv_checkBox.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resv_checkBox.Location = new System.Drawing.Point(117, 132);
            this.resv_checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.resv_checkBox.Name = "resv_checkBox";
            this.resv_checkBox.Size = new System.Drawing.Size(59, 17);
            this.resv_checkBox.TabIndex = 19;
            this.resv_checkBox.Text = "예약중";
            this.resv_checkBox.UseVisualStyleBackColor = true;
            // 
            // rent_checkBox
            // 
            this.rent_checkBox.AutoCheck = false;
            this.rent_checkBox.AutoSize = true;
            this.rent_checkBox.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.rent_checkBox.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rent_checkBox.Location = new System.Drawing.Point(38, 132);
            this.rent_checkBox.Margin = new System.Windows.Forms.Padding(2);
            this.rent_checkBox.Name = "rent_checkBox";
            this.rent_checkBox.Size = new System.Drawing.Size(59, 17);
            this.rent_checkBox.TabIndex = 18;
            this.rent_checkBox.Text = "대여중";
            this.rent_checkBox.UseVisualStyleBackColor = true;
            // 
            // resv_btn
            // 
            this.resv_btn.BackColor = System.Drawing.Color.Red;
            this.resv_btn.FlatAppearance.BorderSize = 0;
            this.resv_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resv_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.resv_btn.ForeColor = System.Drawing.Color.White;
            this.resv_btn.Location = new System.Drawing.Point(16, 248);
            this.resv_btn.Margin = new System.Windows.Forms.Padding(2);
            this.resv_btn.Name = "resv_btn";
            this.resv_btn.Size = new System.Drawing.Size(174, 29);
            this.resv_btn.TabIndex = 17;
            this.resv_btn.Text = "예약";
            this.resv_btn.UseVisualStyleBackColor = false;
            this.resv_btn.Click += new System.EventHandler(this.resv_btn_Click);
            // 
            // return_btn
            // 
            this.return_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.return_btn.FlatAppearance.BorderSize = 0;
            this.return_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.return_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.return_btn.ForeColor = System.Drawing.Color.White;
            this.return_btn.Location = new System.Drawing.Point(16, 207);
            this.return_btn.Margin = new System.Windows.Forms.Padding(2);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(174, 29);
            this.return_btn.TabIndex = 16;
            this.return_btn.Text = "반납";
            this.return_btn.UseVisualStyleBackColor = false;
            this.return_btn.Click += new System.EventHandler(this.return_btn_Click);
            // 
            // rent_btn
            // 
            this.rent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rent_btn.FlatAppearance.BorderSize = 0;
            this.rent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rent_btn.ForeColor = System.Drawing.Color.White;
            this.rent_btn.Location = new System.Drawing.Point(16, 167);
            this.rent_btn.Margin = new System.Windows.Forms.Padding(2);
            this.rent_btn.Name = "rent_btn";
            this.rent_btn.Size = new System.Drawing.Size(174, 29);
            this.rent_btn.TabIndex = 9;
            this.rent_btn.Text = "대여";
            this.rent_btn.UseVisualStyleBackColor = false;
            this.rent_btn.Click += new System.EventHandler(this.rent_btn_Click);
            // 
            // bookname_label
            // 
            this.bookname_label.AutoSize = true;
            this.bookname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookname_label.Location = new System.Drawing.Point(11, 77);
            this.bookname_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookname_label.Name = "bookname_label";
            this.bookname_label.Size = new System.Drawing.Size(47, 18);
            this.bookname_label.TabIndex = 15;
            this.bookname_label.Text = "도서명";
            // 
            // bookname_textBox
            // 
            this.bookname_textBox.BackColor = System.Drawing.Color.White;
            this.bookname_textBox.Location = new System.Drawing.Point(16, 96);
            this.bookname_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.bookname_textBox.Name = "bookname_textBox";
            this.bookname_textBox.ReadOnly = true;
            this.bookname_textBox.Size = new System.Drawing.Size(176, 23);
            this.bookname_textBox.TabIndex = 14;
            // 
            // booknumber_label
            // 
            this.booknumber_label.AutoSize = true;
            this.booknumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.booknumber_label.Location = new System.Drawing.Point(11, 26);
            this.booknumber_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.booknumber_label.Name = "booknumber_label";
            this.booknumber_label.Size = new System.Drawing.Size(60, 18);
            this.booknumber_label.TabIndex = 13;
            this.booknumber_label.Text = "도서번호";
            // 
            // booknumber_textBox
            // 
            this.booknumber_textBox.BackColor = System.Drawing.Color.White;
            this.booknumber_textBox.Location = new System.Drawing.Point(16, 46);
            this.booknumber_textBox.Margin = new System.Windows.Forms.Padding(2);
            this.booknumber_textBox.Name = "booknumber_textBox";
            this.booknumber_textBox.ReadOnly = true;
            this.booknumber_textBox.Size = new System.Drawing.Size(176, 23);
            this.booknumber_textBox.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.book_label);
            this.panel7.Controls.Add(this.book_listView);
            this.panel7.Location = new System.Drawing.Point(9, 213);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(625, 286);
            this.panel7.TabIndex = 14;
            // 
            // book_label
            // 
            this.book_label.AutoSize = true;
            this.book_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_label.Location = new System.Drawing.Point(1, 5);
            this.book_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.book_label.Name = "book_label";
            this.book_label.Size = new System.Drawing.Size(33, 20);
            this.book_label.TabIndex = 6;
            this.book_label.Text = "도서";
            // 
            // book_listView
            // 
            this.book_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_number,
            this.book_name,
            this.book_writer,
            this.book_publisher,
            this.book_stock,
            this.book_rentsum});
            this.book_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.book_listView.FullRowSelect = true;
            this.book_listView.HideSelection = false;
            this.book_listView.Location = new System.Drawing.Point(0, 31);
            this.book_listView.Margin = new System.Windows.Forms.Padding(2);
            this.book_listView.Name = "book_listView";
            this.book_listView.Size = new System.Drawing.Size(625, 255);
            this.book_listView.TabIndex = 0;
            this.book_listView.UseCompatibleStateImageBehavior = false;
            this.book_listView.View = System.Windows.Forms.View.Details;
            this.book_listView.Click += new System.EventHandler(this.book_listView_Click);
            // 
            // book_number
            // 
            this.book_number.Text = "도서 번호";
            this.book_number.Width = 150;
            // 
            // book_name
            // 
            this.book_name.Text = "도서명";
            this.book_name.Width = 150;
            // 
            // book_writer
            // 
            this.book_writer.Text = "저자";
            this.book_writer.Width = 150;
            // 
            // book_publisher
            // 
            this.book_publisher.Text = "출판사";
            this.book_publisher.Width = 150;
            // 
            // book_stock
            // 
            this.book_stock.Text = "재고";
            this.book_stock.Width = 140;
            // 
            // book_rentsum
            // 
            this.book_rentsum.Text = "대여량";
            this.book_rentsum.Width = 150;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.rent_avg_labels);
            this.panel6.Controls.Add(this.rent_avg_label);
            this.panel6.Location = new System.Drawing.Point(431, 109);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(415, 89);
            this.panel6.TabIndex = 12;
            // 
            // rent_avg_labels
            // 
            this.rent_avg_labels.AutoSize = true;
            this.rent_avg_labels.BackColor = System.Drawing.Color.Transparent;
            this.rent_avg_labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rent_avg_labels.ForeColor = System.Drawing.Color.Black;
            this.rent_avg_labels.Location = new System.Drawing.Point(216, 26);
            this.rent_avg_labels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rent_avg_labels.Name = "rent_avg_labels";
            this.rent_avg_labels.Size = new System.Drawing.Size(108, 36);
            this.rent_avg_labels.TabIndex = 12;
            this.rent_avg_labels.Text = "10,000";
            // 
            // rent_avg_label
            // 
            this.rent_avg_label.AutoSize = true;
            this.rent_avg_label.BackColor = System.Drawing.Color.Transparent;
            this.rent_avg_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_avg_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rent_avg_label.ForeColor = System.Drawing.Color.Gray;
            this.rent_avg_label.Location = new System.Drawing.Point(73, 32);
            this.rent_avg_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rent_avg_label.Name = "rent_avg_label";
            this.rent_avg_label.Size = new System.Drawing.Size(91, 24);
            this.rent_avg_label.TabIndex = 11;
            this.rent_avg_label.Text = "기간 대여량";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.rent_sum_labels);
            this.panel5.Controls.Add(this.rent_sum_label);
            this.panel5.Location = new System.Drawing.Point(657, 7);
            this.panel5.Margin = new System.Windows.Forms.Padding(2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(190, 90);
            this.panel5.TabIndex = 13;
            // 
            // rent_sum_labels
            // 
            this.rent_sum_labels.AutoSize = true;
            this.rent_sum_labels.BackColor = System.Drawing.Color.Transparent;
            this.rent_sum_labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rent_sum_labels.ForeColor = System.Drawing.Color.Black;
            this.rent_sum_labels.Location = new System.Drawing.Point(41, 41);
            this.rent_sum_labels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rent_sum_labels.Name = "rent_sum_labels";
            this.rent_sum_labels.Size = new System.Drawing.Size(108, 36);
            this.rent_sum_labels.TabIndex = 12;
            this.rent_sum_labels.Text = "10,000";
            // 
            // rent_sum_label
            // 
            this.rent_sum_label.AutoSize = true;
            this.rent_sum_label.BackColor = System.Drawing.Color.Transparent;
            this.rent_sum_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rent_sum_label.ForeColor = System.Drawing.Color.Gray;
            this.rent_sum_label.Location = new System.Drawing.Point(20, 14);
            this.rent_sum_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rent_sum_label.Name = "rent_sum_label";
            this.rent_sum_label.Size = new System.Drawing.Size(91, 24);
            this.rent_sum_label.TabIndex = 11;
            this.rent_sum_label.Text = "하루 대여량";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.book_count_labels);
            this.panel4.Controls.Add(this.book_count_label);
            this.panel4.Location = new System.Drawing.Point(431, 7);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(190, 90);
            this.panel4.TabIndex = 10;
            // 
            // book_count_labels
            // 
            this.book_count_labels.AutoSize = true;
            this.book_count_labels.BackColor = System.Drawing.Color.Transparent;
            this.book_count_labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_count_labels.ForeColor = System.Drawing.Color.Black;
            this.book_count_labels.Location = new System.Drawing.Point(38, 39);
            this.book_count_labels.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.book_count_labels.Name = "book_count_labels";
            this.book_count_labels.Size = new System.Drawing.Size(108, 36);
            this.book_count_labels.TabIndex = 10;
            this.book_count_labels.Text = "10,000";
            // 
            // book_count_label
            // 
            this.book_count_label.AutoSize = true;
            this.book_count_label.BackColor = System.Drawing.Color.Transparent;
            this.book_count_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_count_label.ForeColor = System.Drawing.Color.Gray;
            this.book_count_label.Location = new System.Drawing.Point(17, 12);
            this.book_count_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.book_count_label.Name = "book_count_label";
            this.book_count_label.Size = new System.Drawing.Size(55, 24);
            this.book_count_label.TabIndex = 9;
            this.book_count_label.Text = "장서량";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ranking_label);
            this.panel3.Controls.Add(this.ranking_listView);
            this.panel3.Location = new System.Drawing.Point(9, 7);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(352, 190);
            this.panel3.TabIndex = 9;
            // 
            // ranking_label
            // 
            this.ranking_label.AutoSize = true;
            this.ranking_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ranking_label.Location = new System.Drawing.Point(1, 14);
            this.ranking_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ranking_label.Name = "ranking_label";
            this.ranking_label.Size = new System.Drawing.Size(61, 17);
            this.ranking_label.TabIndex = 5;
            this.ranking_label.Text = "대여 순위";
            // 
            // ranking_listView
            // 
            this.ranking_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ranking_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ranking_no,
            this.ranking_booknumber,
            this.ranking_bookname,
            this.ranking_writer,
            this.ranking_publisher});
            this.ranking_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ranking_listView.HideSelection = false;
            this.ranking_listView.Location = new System.Drawing.Point(0, 45);
            this.ranking_listView.Margin = new System.Windows.Forms.Padding(2);
            this.ranking_listView.Name = "ranking_listView";
            this.ranking_listView.Size = new System.Drawing.Size(352, 145);
            this.ranking_listView.TabIndex = 0;
            this.ranking_listView.UseCompatibleStateImageBehavior = false;
            this.ranking_listView.View = System.Windows.Forms.View.Details;
            // 
            // ranking_no
            // 
            this.ranking_no.Text = "No.";
            this.ranking_no.Width = 59;
            // 
            // ranking_booknumber
            // 
            this.ranking_booknumber.Text = "도서 번호";
            this.ranking_booknumber.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ranking_booknumber.Width = 110;
            // 
            // ranking_bookname
            // 
            this.ranking_bookname.Text = "도서명";
            this.ranking_bookname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ranking_bookname.Width = 110;
            // 
            // ranking_writer
            // 
            this.ranking_writer.Text = "저자";
            this.ranking_writer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ranking_writer.Width = 110;
            // 
            // ranking_publisher
            // 
            this.ranking_publisher.Text = "출판사";
            this.ranking_publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ranking_publisher.Width = 110;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(864, 506);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.HomeForm_FormClosing);
            this.Load += new System.EventHandler(this.HomeForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox resv_checkBox;
        private System.Windows.Forms.CheckBox rent_checkBox;
        private System.Windows.Forms.Button resv_btn;
        private System.Windows.Forms.Button return_btn;
        private System.Windows.Forms.Button rent_btn;
        private System.Windows.Forms.Label bookname_label;
        private System.Windows.Forms.TextBox bookname_textBox;
        private System.Windows.Forms.Label booknumber_label;
        private System.Windows.Forms.TextBox booknumber_textBox;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label book_label;
        private System.Windows.Forms.ListView book_listView;
        private System.Windows.Forms.ColumnHeader book_number;
        private System.Windows.Forms.ColumnHeader book_name;
        private System.Windows.Forms.ColumnHeader book_writer;
        private System.Windows.Forms.ColumnHeader book_publisher;
        private System.Windows.Forms.ColumnHeader book_stock;
        private System.Windows.Forms.ColumnHeader book_rentsum;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label rent_avg_labels;
        private System.Windows.Forms.Label rent_avg_label;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label rent_sum_labels;
        private System.Windows.Forms.Label rent_sum_label;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label book_count_labels;
        private System.Windows.Forms.Label book_count_label;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label ranking_label;
        private System.Windows.Forms.ListView ranking_listView;
        private System.Windows.Forms.ColumnHeader ranking_no;
        private System.Windows.Forms.ColumnHeader ranking_booknumber;
        private System.Windows.Forms.ColumnHeader ranking_bookname;
        private System.Windows.Forms.ColumnHeader ranking_writer;
        private System.Windows.Forms.ColumnHeader ranking_publisher;
    }
}