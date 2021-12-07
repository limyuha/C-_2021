
namespace book_management_program.Forms
{
    partial class book_manager_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(book_manager_Form));
            this.panel7 = new System.Windows.Forms.Panel();
            this.book_listView = new System.Windows.Forms.ListView();
            this.book_number = new System.Windows.Forms.ColumnHeader();
            this.cat_no = new System.Windows.Forms.ColumnHeader();
            this.book_writer = new System.Windows.Forms.ColumnHeader();
            this.book_publisher = new System.Windows.Forms.ColumnHeader();
            this.pub_dt = new System.Windows.Forms.ColumnHeader();
            this.book_name = new System.Windows.Forms.ColumnHeader();
            this.book_stock = new System.Windows.Forms.ColumnHeader();
            this.book_manager_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pub_dt_label = new System.Windows.Forms.Label();
            this.pub_dt_textBox = new System.Windows.Forms.TextBox();
            this.cat_no_label = new System.Windows.Forms.Label();
            this.cat_no_textBox = new System.Windows.Forms.TextBox();
            this.book_delete_btn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.book_stock_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.book_publisher_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.book_writer_textBox = new System.Windows.Forms.TextBox();
            this.stock_add_btn = new System.Windows.Forms.Button();
            this.modify_btn = new System.Windows.Forms.Button();
            this.rent_btn = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.book_name_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.book_number_textBox = new System.Windows.Forms.TextBox();
            this.all_btn = new System.Windows.Forms.Button();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.group_comboBox = new System.Windows.Forms.ComboBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.book_listView);
            this.panel7.Controls.Add(this.book_manager_label);
            this.panel7.Location = new System.Drawing.Point(22, 300);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1979, 613);
            this.panel7.TabIndex = 15;
            // 
            // book_listView
            // 
            this.book_listView.Activation = System.Windows.Forms.ItemActivation.OneClick;
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
            this.book_listView.Location = new System.Drawing.Point(0, 32);
            this.book_listView.Name = "book_listView";
            this.book_listView.Size = new System.Drawing.Size(1979, 581);
            this.book_listView.TabIndex = 7;
            this.book_listView.UseCompatibleStateImageBehavior = false;
            this.book_listView.View = System.Windows.Forms.View.Details;
            this.book_listView.ItemActivate += new System.EventHandler(this.book_listView_ItemActivate);
            // 
            // book_number
            // 
            this.book_number.Text = "ISBN";
            this.book_number.Width = 100;
            // 
            // cat_no
            // 
            this.cat_no.Text = "분류";
            this.cat_no.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.cat_no.Width = 110;
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
            this.book_name.Width = 980;
            // 
            // book_stock
            // 
            this.book_stock.Text = "재고";
            this.book_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_stock.Width = 80;
            // 
            // book_manager_label
            // 
            this.book_manager_label.AutoSize = true;
            this.book_manager_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_manager_label.Location = new System.Drawing.Point(0, 0);
            this.book_manager_label.Name = "book_manager_label";
            this.book_manager_label.Size = new System.Drawing.Size(61, 20);
            this.book_manager_label.TabIndex = 6;
            this.book_manager_label.Text = "도서 관리";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pub_dt_label);
            this.groupBox1.Controls.Add(this.pub_dt_textBox);
            this.groupBox1.Controls.Add(this.cat_no_label);
            this.groupBox1.Controls.Add(this.cat_no_textBox);
            this.groupBox1.Controls.Add(this.book_delete_btn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.book_stock_textBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.book_publisher_textBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.book_writer_textBox);
            this.groupBox1.Controls.Add(this.stock_add_btn);
            this.groupBox1.Controls.Add(this.modify_btn);
            this.groupBox1.Controls.Add(this.rent_btn);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.book_name_textBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.book_number_textBox);
            this.groupBox1.Location = new System.Drawing.Point(167, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1700, 199);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록 / 수정 / 재고 추가 / 삭제";
            // 
            // pub_dt_label
            // 
            this.pub_dt_label.AutoSize = true;
            this.pub_dt_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pub_dt_label.Location = new System.Drawing.Point(400, 43);
            this.pub_dt_label.Name = "pub_dt_label";
            this.pub_dt_label.Size = new System.Drawing.Size(47, 18);
            this.pub_dt_label.TabIndex = 24;
            this.pub_dt_label.Text = "발행일";
            // 
            // pub_dt_textBox
            // 
            this.pub_dt_textBox.BackColor = System.Drawing.Color.White;
            this.pub_dt_textBox.Location = new System.Drawing.Point(400, 72);
            this.pub_dt_textBox.Name = "pub_dt_textBox";
            this.pub_dt_textBox.Size = new System.Drawing.Size(142, 23);
            this.pub_dt_textBox.TabIndex = 23;
            // 
            // cat_no_label
            // 
            this.cat_no_label.AutoSize = true;
            this.cat_no_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cat_no_label.Location = new System.Drawing.Point(211, 43);
            this.cat_no_label.Name = "cat_no_label";
            this.cat_no_label.Size = new System.Drawing.Size(34, 18);
            this.cat_no_label.TabIndex = 22;
            this.cat_no_label.Text = "분류";
            // 
            // cat_no_textBox
            // 
            this.cat_no_textBox.BackColor = System.Drawing.Color.White;
            this.cat_no_textBox.Location = new System.Drawing.Point(211, 72);
            this.cat_no_textBox.Name = "cat_no_textBox";
            this.cat_no_textBox.Size = new System.Drawing.Size(142, 23);
            this.cat_no_textBox.TabIndex = 21;
            // 
            // book_delete_btn
            // 
            this.book_delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.book_delete_btn.FlatAppearance.BorderSize = 0;
            this.book_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_delete_btn.ForeColor = System.Drawing.Color.White;
            this.book_delete_btn.Location = new System.Drawing.Point(1541, 128);
            this.book_delete_btn.Name = "book_delete_btn";
            this.book_delete_btn.Size = new System.Drawing.Size(135, 48);
            this.book_delete_btn.TabIndex = 20;
            this.book_delete_btn.Text = "삭제";
            this.book_delete_btn.UseVisualStyleBackColor = false;
            this.book_delete_btn.Click += new System.EventHandler(this.book_delete_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(1297, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "재고";
            // 
            // book_stock_textBox
            // 
            this.book_stock_textBox.BackColor = System.Drawing.Color.White;
            this.book_stock_textBox.Location = new System.Drawing.Point(1297, 72);
            this.book_stock_textBox.Name = "book_stock_textBox";
            this.book_stock_textBox.Size = new System.Drawing.Size(64, 23);
            this.book_stock_textBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(960, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 17;
            this.label2.Text = "출판사";
            // 
            // book_publisher_textBox
            // 
            this.book_publisher_textBox.BackColor = System.Drawing.Color.White;
            this.book_publisher_textBox.Location = new System.Drawing.Point(960, 72);
            this.book_publisher_textBox.Name = "book_publisher_textBox";
            this.book_publisher_textBox.Size = new System.Drawing.Size(300, 23);
            this.book_publisher_textBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(593, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 18);
            this.label1.TabIndex = 19;
            this.label1.Text = "저자";
            // 
            // book_writer_textBox
            // 
            this.book_writer_textBox.BackColor = System.Drawing.Color.White;
            this.book_writer_textBox.Location = new System.Drawing.Point(593, 72);
            this.book_writer_textBox.Name = "book_writer_textBox";
            this.book_writer_textBox.Size = new System.Drawing.Size(316, 23);
            this.book_writer_textBox.TabIndex = 18;
            // 
            // stock_add_btn
            // 
            this.stock_add_btn.BackColor = System.Drawing.Color.Red;
            this.stock_add_btn.FlatAppearance.BorderSize = 0;
            this.stock_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stock_add_btn.ForeColor = System.Drawing.Color.White;
            this.stock_add_btn.Location = new System.Drawing.Point(1388, 128);
            this.stock_add_btn.Name = "stock_add_btn";
            this.stock_add_btn.Size = new System.Drawing.Size(135, 48);
            this.stock_add_btn.TabIndex = 17;
            this.stock_add_btn.Text = "재고 추가";
            this.stock_add_btn.UseVisualStyleBackColor = false;
            this.stock_add_btn.Click += new System.EventHandler(this.stock_add_btn_Click);
            // 
            // modify_btn
            // 
            this.modify_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.modify_btn.FlatAppearance.BorderSize = 0;
            this.modify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modify_btn.ForeColor = System.Drawing.Color.White;
            this.modify_btn.Location = new System.Drawing.Point(1541, 55);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(135, 48);
            this.modify_btn.TabIndex = 16;
            this.modify_btn.Text = "수정";
            this.modify_btn.UseVisualStyleBackColor = false;
            this.modify_btn.Click += new System.EventHandler(this.modify_btn_Click);
            // 
            // rent_btn
            // 
            this.rent_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rent_btn.FlatAppearance.BorderSize = 0;
            this.rent_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rent_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rent_btn.ForeColor = System.Drawing.Color.White;
            this.rent_btn.Location = new System.Drawing.Point(1388, 55);
            this.rent_btn.Name = "rent_btn";
            this.rent_btn.Size = new System.Drawing.Size(135, 48);
            this.rent_btn.TabIndex = 9;
            this.rent_btn.Text = "등록";
            this.rent_btn.UseVisualStyleBackColor = false;
            this.rent_btn.Click += new System.EventHandler(this.rent_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 113);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 18);
            this.label11.TabIndex = 15;
            this.label11.Text = "도서명";
            // 
            // book_name_textBox
            // 
            this.book_name_textBox.BackColor = System.Drawing.Color.White;
            this.book_name_textBox.Location = new System.Drawing.Point(23, 145);
            this.book_name_textBox.Name = "book_name_textBox";
            this.book_name_textBox.Size = new System.Drawing.Size(1338, 23);
            this.book_name_textBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 18);
            this.label10.TabIndex = 13;
            this.label10.Text = "도서번호";
            // 
            // book_number_textBox
            // 
            this.book_number_textBox.BackColor = System.Drawing.Color.White;
            this.book_number_textBox.Enabled = false;
            this.book_number_textBox.Location = new System.Drawing.Point(23, 72);
            this.book_number_textBox.Name = "book_number_textBox";
            this.book_number_textBox.Size = new System.Drawing.Size(142, 23);
            this.book_number_textBox.TabIndex = 0;
            // 
            // all_btn
            // 
            this.all_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.all_btn.FlatAppearance.BorderSize = 0;
            this.all_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.all_btn.Location = new System.Drawing.Point(1609, 251);
            this.all_btn.Name = "all_btn";
            this.all_btn.Size = new System.Drawing.Size(111, 33);
            this.all_btn.TabIndex = 24;
            this.all_btn.Text = "전체보기";
            this.all_btn.UseVisualStyleBackColor = false;
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(468, 253);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(1016, 23);
            this.search_textBox.TabIndex = 23;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(315, 253);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 21;
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
            this.group_comboBox.Location = new System.Drawing.Point(351, 252);
            this.group_comboBox.Name = "group_comboBox";
            this.group_comboBox.Size = new System.Drawing.Size(111, 23);
            this.group_comboBox.TabIndex = 20;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Location = new System.Drawing.Point(1492, 251);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(111, 33);
            this.search_btn.TabIndex = 22;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // book_manager_Form
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2034, 943);
            this.Controls.Add(this.all_btn);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group_comboBox);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "book_manager_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "book_manager";
            this.Load += new System.EventHandler(this.book_manager_Form_Load);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label book_manager_label;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button stock_add_btn;
        private System.Windows.Forms.Button modify_btn;
        private System.Windows.Forms.Button rent_btn;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox book_name_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox book_number_textBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox book_stock_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox book_publisher_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox book_writer_textBox;
        private System.Windows.Forms.Button book_delete_btn;
        private System.Windows.Forms.ListView book_listView;
        private System.Windows.Forms.ColumnHeader book_number;
        private System.Windows.Forms.ColumnHeader cat_no;
        private System.Windows.Forms.ColumnHeader book_writer;
        private System.Windows.Forms.ColumnHeader book_publisher;
        private System.Windows.Forms.ColumnHeader pub_dt;
        private System.Windows.Forms.ColumnHeader book_name;
        private System.Windows.Forms.ColumnHeader book_stock;
        private System.Windows.Forms.Label cat_no_label;
        private System.Windows.Forms.TextBox cat_no_textBox;
        private System.Windows.Forms.Label pub_dt_label;
        private System.Windows.Forms.TextBox pub_dt_textBox;
        private System.Windows.Forms.Button all_btn;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox group_comboBox;
        private System.Windows.Forms.Button search_btn;
    }
}