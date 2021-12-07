
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
            this.cat_no = new System.Windows.Forms.ColumnHeader();
            this.book_writer = new System.Windows.Forms.ColumnHeader();
            this.book_publisher = new System.Windows.Forms.ColumnHeader();
            this.pub_dt = new System.Windows.Forms.ColumnHeader();
            this.book_name = new System.Windows.Forms.ColumnHeader();
            this.book_stock = new System.Windows.Forms.ColumnHeader();
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
            this.isbn = new System.Windows.Forms.ColumnHeader();
            this.book_nm = new System.Windows.Forms.ColumnHeader();
            this.author = new System.Windows.Forms.ColumnHeader();
            this.pub = new System.Windows.Forms.ColumnHeader();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_comboBox = new System.Windows.Forms.ComboBox();
            this.all_btn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(32, 457);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1971, 120);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "대여 / 반납 / 예약";
            // 
            // resv_checkBox
            // 
            this.resv_checkBox.AutoCheck = false;
            this.resv_checkBox.AutoSize = true;
            this.resv_checkBox.Font = new System.Drawing.Font("맑은 고딕 Semilight", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.resv_checkBox.Location = new System.Drawing.Point(130, 56);
            this.resv_checkBox.Name = "resv_checkBox";
            this.resv_checkBox.Size = new System.Drawing.Size(84, 25);
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
            this.rent_checkBox.Location = new System.Drawing.Point(40, 56);
            this.rent_checkBox.Name = "rent_checkBox";
            this.rent_checkBox.Size = new System.Drawing.Size(84, 25);
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
            this.resv_btn.Location = new System.Drawing.Point(1743, 33);
            this.resv_btn.Name = "resv_btn";
            this.resv_btn.Size = new System.Drawing.Size(180, 62);
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
            this.return_btn.Location = new System.Drawing.Point(1548, 33);
            this.return_btn.Name = "return_btn";
            this.return_btn.Size = new System.Drawing.Size(180, 62);
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
            this.rent_btn.Location = new System.Drawing.Point(1351, 33);
            this.rent_btn.Name = "rent_btn";
            this.rent_btn.Size = new System.Drawing.Size(180, 62);
            this.rent_btn.TabIndex = 9;
            this.rent_btn.Text = "대여";
            this.rent_btn.UseVisualStyleBackColor = false;
            this.rent_btn.Click += new System.EventHandler(this.rent_btn_Click);
            // 
            // bookname_label
            // 
            this.bookname_label.AutoSize = true;
            this.bookname_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bookname_label.Location = new System.Drawing.Point(400, 53);
            this.bookname_label.Name = "bookname_label";
            this.bookname_label.Size = new System.Drawing.Size(63, 26);
            this.bookname_label.TabIndex = 15;
            this.bookname_label.Text = "도서명";
            // 
            // bookname_textBox
            // 
            this.bookname_textBox.BackColor = System.Drawing.Color.White;
            this.bookname_textBox.Location = new System.Drawing.Point(469, 50);
            this.bookname_textBox.Name = "bookname_textBox";
            this.bookname_textBox.ReadOnly = true;
            this.bookname_textBox.Size = new System.Drawing.Size(863, 31);
            this.bookname_textBox.TabIndex = 14;
            // 
            // booknumber_label
            // 
            this.booknumber_label.AutoSize = true;
            this.booknumber_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.booknumber_label.Location = new System.Drawing.Point(220, 53);
            this.booknumber_label.Name = "booknumber_label";
            this.booknumber_label.Size = new System.Drawing.Size(80, 26);
            this.booknumber_label.TabIndex = 13;
            this.booknumber_label.Text = "도서번호";
            // 
            // booknumber_textBox
            // 
            this.booknumber_textBox.BackColor = System.Drawing.Color.White;
            this.booknumber_textBox.Location = new System.Drawing.Point(306, 50);
            this.booknumber_textBox.Name = "booknumber_textBox";
            this.booknumber_textBox.ReadOnly = true;
            this.booknumber_textBox.Size = new System.Drawing.Size(73, 31);
            this.booknumber_textBox.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.book_label);
            this.panel7.Controls.Add(this.book_listView);
            this.panel7.Location = new System.Drawing.Point(32, 577);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1972, 637);
            this.panel7.TabIndex = 14;
            // 
            // book_label
            // 
            this.book_label.AutoSize = true;
            this.book_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_label.Location = new System.Drawing.Point(1, 8);
            this.book_label.Name = "book_label";
            this.book_label.Size = new System.Drawing.Size(51, 29);
            this.book_label.TabIndex = 6;
            this.book_label.Text = "도서";
            // 
            // book_listView
            // 
            this.book_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_number,
            this.cat_no,
            this.book_writer,
            this.book_publisher,
            this.pub_dt,
            this.book_name,
            this.book_stock});
            this.book_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.book_listView.FullRowSelect = true;
            this.book_listView.HideSelection = false;
            this.book_listView.Location = new System.Drawing.Point(0, 42);
            this.book_listView.Name = "book_listView";
            this.book_listView.Size = new System.Drawing.Size(1972, 595);
            this.book_listView.TabIndex = 0;
            this.book_listView.UseCompatibleStateImageBehavior = false;
            this.book_listView.View = System.Windows.Forms.View.Details;
            this.book_listView.SelectedIndexChanged += new System.EventHandler(this.book_listView_SelectedIndexChanged);
            this.book_listView.Click += new System.EventHandler(this.book_listView_Click);
            // 
            // book_number
            // 
            this.book_number.Text = "ISBN";
            this.book_number.Width = 80;
            // 
            // cat_no
            // 
            this.cat_no.Text = "분류";
            this.cat_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cat_no.Width = 100;
            // 
            // book_writer
            // 
            this.book_writer.Text = "저자";
            this.book_writer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_writer.Width = 280;
            // 
            // book_publisher
            // 
            this.book_publisher.Text = "출판사";
            this.book_publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_publisher.Width = 280;
            // 
            // pub_dt
            // 
            this.pub_dt.Text = "발행일";
            this.pub_dt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pub_dt.Width = 110;
            // 
            // book_name
            // 
            this.book_name.Text = "도서명";
            this.book_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_name.Width = 1020;
            // 
            // book_stock
            // 
            this.book_stock.Text = "재고";
            this.book_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_stock.Width = 70;
            // 
            // panel6
            // 
            this.panel6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel6.BackgroundImage")));
            this.panel6.Controls.Add(this.rent_avg_labels);
            this.panel6.Controls.Add(this.rent_avg_label);
            this.panel6.Location = new System.Drawing.Point(1410, 212);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(593, 172);
            this.panel6.TabIndex = 12;
            // 
            // rent_avg_labels
            // 
            this.rent_avg_labels.AutoSize = true;
            this.rent_avg_labels.BackColor = System.Drawing.Color.Transparent;
            this.rent_avg_labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rent_avg_labels.ForeColor = System.Drawing.Color.Black;
            this.rent_avg_labels.Location = new System.Drawing.Point(309, 60);
            this.rent_avg_labels.Name = "rent_avg_labels";
            this.rent_avg_labels.Size = new System.Drawing.Size(154, 52);
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
            this.rent_avg_label.Location = new System.Drawing.Point(104, 70);
            this.rent_avg_label.Name = "rent_avg_label";
            this.rent_avg_label.Size = new System.Drawing.Size(127, 32);
            this.rent_avg_label.TabIndex = 11;
            this.rent_avg_label.Text = "기간 대여량";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.rent_sum_labels);
            this.panel5.Controls.Add(this.rent_sum_label);
            this.panel5.Location = new System.Drawing.Point(1732, 14);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(271, 150);
            this.panel5.TabIndex = 13;
            // 
            // rent_sum_labels
            // 
            this.rent_sum_labels.AutoSize = true;
            this.rent_sum_labels.BackColor = System.Drawing.Color.Transparent;
            this.rent_sum_labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rent_sum_labels.ForeColor = System.Drawing.Color.Black;
            this.rent_sum_labels.Location = new System.Drawing.Point(112, 68);
            this.rent_sum_labels.Name = "rent_sum_labels";
            this.rent_sum_labels.Size = new System.Drawing.Size(46, 52);
            this.rent_sum_labels.TabIndex = 12;
            this.rent_sum_labels.Text = "1";
            // 
            // rent_sum_label
            // 
            this.rent_sum_label.AutoSize = true;
            this.rent_sum_label.BackColor = System.Drawing.Color.Transparent;
            this.rent_sum_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_sum_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rent_sum_label.ForeColor = System.Drawing.Color.Gray;
            this.rent_sum_label.Location = new System.Drawing.Point(29, 23);
            this.rent_sum_label.Name = "rent_sum_label";
            this.rent_sum_label.Size = new System.Drawing.Size(127, 32);
            this.rent_sum_label.TabIndex = 11;
            this.rent_sum_label.Text = "하루 대여량";
            // 
            // panel4
            // 
            this.panel4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel4.BackgroundImage")));
            this.panel4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel4.Controls.Add(this.book_count_labels);
            this.panel4.Controls.Add(this.book_count_label);
            this.panel4.Location = new System.Drawing.Point(1411, 14);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(271, 150);
            this.panel4.TabIndex = 10;
            // 
            // book_count_labels
            // 
            this.book_count_labels.AutoSize = true;
            this.book_count_labels.BackColor = System.Drawing.Color.Transparent;
            this.book_count_labels.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_count_labels.ForeColor = System.Drawing.Color.Black;
            this.book_count_labels.Location = new System.Drawing.Point(86, 68);
            this.book_count_labels.Name = "book_count_labels";
            this.book_count_labels.Size = new System.Drawing.Size(46, 52);
            this.book_count_labels.TabIndex = 10;
            this.book_count_labels.Text = "1";
            // 
            // book_count_label
            // 
            this.book_count_label.AutoSize = true;
            this.book_count_label.BackColor = System.Drawing.Color.Transparent;
            this.book_count_label.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_count_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_count_label.ForeColor = System.Drawing.Color.Gray;
            this.book_count_label.Location = new System.Drawing.Point(24, 20);
            this.book_count_label.Name = "book_count_label";
            this.book_count_label.Size = new System.Drawing.Size(77, 32);
            this.book_count_label.TabIndex = 9;
            this.book_count_label.Text = "장서량";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.ranking_label);
            this.panel3.Controls.Add(this.ranking_listView);
            this.panel3.Location = new System.Drawing.Point(32, 14);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1353, 370);
            this.panel3.TabIndex = 9;
            // 
            // ranking_label
            // 
            this.ranking_label.AutoSize = true;
            this.ranking_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ranking_label.Location = new System.Drawing.Point(0, 20);
            this.ranking_label.Name = "ranking_label";
            this.ranking_label.Size = new System.Drawing.Size(78, 25);
            this.ranking_label.TabIndex = 5;
            this.ranking_label.Text = "대여 순위";
            // 
            // ranking_listView
            // 
            this.ranking_listView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ranking_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ranking_no,
            this.isbn,
            this.book_nm,
            this.author,
            this.pub});
            this.ranking_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ranking_listView.HideSelection = false;
            this.ranking_listView.Location = new System.Drawing.Point(0, 48);
            this.ranking_listView.Name = "ranking_listView";
            this.ranking_listView.Size = new System.Drawing.Size(1353, 322);
            this.ranking_listView.TabIndex = 0;
            this.ranking_listView.UseCompatibleStateImageBehavior = false;
            this.ranking_listView.View = System.Windows.Forms.View.Details;
            // 
            // ranking_no
            // 
            this.ranking_no.Text = "No.";
            this.ranking_no.Width = 50;
            // 
            // isbn
            // 
            this.isbn.Text = "ISBN";
            this.isbn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.isbn.Width = 110;
            // 
            // book_nm
            // 
            this.book_nm.Text = "도서명";
            this.book_nm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_nm.Width = 720;
            // 
            // author
            // 
            this.author.Text = "저자";
            this.author.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.author.Width = 233;
            // 
            // pub
            // 
            this.pub.Text = "출판사";
            this.pub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.pub.Width = 233;
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(468, 419);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(1016, 31);
            this.search_textBox.TabIndex = 18;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Location = new System.Drawing.Point(1492, 417);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(111, 33);
            this.search_btn.TabIndex = 17;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 419);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // group_comboBox
            // 
            this.group_comboBox.BackColor = System.Drawing.Color.White;
            this.group_comboBox.FormattingEnabled = true;
            this.group_comboBox.Items.AddRange(new object[] {
            "ISBN",
            "도서명",
            "저자",
            "분류"});
            this.group_comboBox.Location = new System.Drawing.Point(351, 418);
            this.group_comboBox.Name = "group_comboBox";
            this.group_comboBox.Size = new System.Drawing.Size(111, 33);
            this.group_comboBox.TabIndex = 15;
            // 
            // all_btn
            // 
            this.all_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.all_btn.FlatAppearance.BorderSize = 0;
            this.all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all_btn.Location = new System.Drawing.Point(1609, 417);
            this.all_btn.Name = "all_btn";
            this.all_btn.Size = new System.Drawing.Size(111, 33);
            this.all_btn.TabIndex = 19;
            this.all_btn.Text = "전체보기";
            this.all_btn.UseVisualStyleBackColor = false;
            this.all_btn.Click += new System.EventHandler(this.all_btn_Click);
            // 
            // HomeForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2034, 1243);
            this.Controls.Add(this.all_btn);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group_comboBox);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "home";
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
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
        private System.Windows.Forms.ColumnHeader isbn;
        private System.Windows.Forms.ColumnHeader book_nm;
        private System.Windows.Forms.ColumnHeader author;
        private System.Windows.Forms.ColumnHeader pub;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox group_comboBox;
        private System.Windows.Forms.Button all_btn;
        private System.Windows.Forms.ColumnHeader cat_no;
        private System.Windows.Forms.ColumnHeader pub_dt;
    }
}