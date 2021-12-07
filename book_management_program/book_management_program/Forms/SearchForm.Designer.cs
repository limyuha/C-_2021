
namespace book_management_program.Forms
{
    partial class SearchForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchForm));
            this.group_comboBox = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.search_btn = new System.Windows.Forms.Button();
            this.search_textBox = new System.Windows.Forms.TextBox();
            this.search_listView = new System.Windows.Forms.ListView();
            this.book_number = new System.Windows.Forms.ColumnHeader();
            this.cat_no = new System.Windows.Forms.ColumnHeader();
            this.book_writer = new System.Windows.Forms.ColumnHeader();
            this.book_publisher = new System.Windows.Forms.ColumnHeader();
            this.pub_dt = new System.Windows.Forms.ColumnHeader();
            this.book_name = new System.Windows.Forms.ColumnHeader();
            this.book_stock = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.group_comboBox.Location = new System.Drawing.Point(267, 12);
            this.group_comboBox.Name = "group_comboBox";
            this.group_comboBox.Size = new System.Drawing.Size(132, 33);
            this.group_comboBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(231, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(30, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Location = new System.Drawing.Point(1463, 13);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(111, 33);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = false;
            this.search_btn.Click += new System.EventHandler(this.search_btn_Click);
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(405, 13);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(1052, 31);
            this.search_textBox.TabIndex = 4;
            // 
            // search_listView
            // 
            this.search_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_number,
            this.cat_no,
            this.book_writer,
            this.book_publisher,
            this.pub_dt,
            this.book_name,
            this.book_stock});
            this.search_listView.FullRowSelect = true;
            this.search_listView.HideSelection = false;
            this.search_listView.Location = new System.Drawing.Point(115, 133);
            this.search_listView.Name = "search_listView";
            this.search_listView.Size = new System.Drawing.Size(1805, 1176);
            this.search_listView.TabIndex = 5;
            this.search_listView.UseCompatibleStateImageBehavior = false;
            this.search_listView.View = System.Windows.Forms.View.Details;
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
            this.book_name.Width = 880;
            // 
            // book_stock
            // 
            this.book_stock.Text = "재고";
            this.book_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_stock.Width = 70;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.group_comboBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.search_textBox);
            this.panel1.Controls.Add(this.search_btn);
            this.panel1.Location = new System.Drawing.Point(115, 57);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1805, 55);
            this.panel1.TabIndex = 6;
            // 
            // SearchForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(2034, 1443);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.search_listView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "search_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox group_comboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.TextBox search_textBox;
        private System.Windows.Forms.ListView search_listView;
        private System.Windows.Forms.ColumnHeader book_number;
        private System.Windows.Forms.ColumnHeader cat_no;
        private System.Windows.Forms.ColumnHeader book_writer;
        private System.Windows.Forms.ColumnHeader book_publisher;
        private System.Windows.Forms.ColumnHeader pub_dt;
        private System.Windows.Forms.ColumnHeader book_name;
        private System.Windows.Forms.ColumnHeader book_stock;
        private System.Windows.Forms.Panel panel1;
    }
}