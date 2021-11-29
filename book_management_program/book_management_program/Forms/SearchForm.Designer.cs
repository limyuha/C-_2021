﻿
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
            this.search_listView = new System.Windows.Forms.ListView();
            this.book_number = new System.Windows.Forms.ColumnHeader();
            this.book_name = new System.Windows.Forms.ColumnHeader();
            this.book_writer = new System.Windows.Forms.ColumnHeader();
            this.book_publisher = new System.Windows.Forms.ColumnHeader();
            this.book_stock = new System.Windows.Forms.ColumnHeader();
            this.book_rentsum = new System.Windows.Forms.ColumnHeader();
            this.search_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // group_comboBox
            // 
            this.group_comboBox.BackColor = System.Drawing.Color.White;
            this.group_comboBox.FormattingEnabled = true;
            this.group_comboBox.Items.AddRange(new object[] {
            "도서명",
            "저자",
            "출판사"});
            this.group_comboBox.Location = new System.Drawing.Point(336, 63);
            this.group_comboBox.Name = "group_comboBox";
            this.group_comboBox.Size = new System.Drawing.Size(95, 33);
            this.group_comboBox.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(297, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // search_btn
            // 
            this.search_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.search_btn.FlatAppearance.BorderSize = 0;
            this.search_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.search_btn.Location = new System.Drawing.Point(803, 62);
            this.search_btn.Name = "search_btn";
            this.search_btn.Size = new System.Drawing.Size(112, 34);
            this.search_btn.TabIndex = 2;
            this.search_btn.Text = "검색";
            this.search_btn.UseVisualStyleBackColor = false;
            // 
            // search_listView
            // 
            this.search_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.book_number,
            this.book_name,
            this.book_writer,
            this.book_publisher,
            this.book_stock,
            this.book_rentsum});
            this.search_listView.HideSelection = false;
            this.search_listView.Location = new System.Drawing.Point(117, 145);
            this.search_listView.Name = "search_listView";
            this.search_listView.Size = new System.Drawing.Size(1000, 600);
            this.search_listView.TabIndex = 3;
            this.search_listView.UseCompatibleStateImageBehavior = false;
            this.search_listView.View = System.Windows.Forms.View.Details;
            // 
            // book_number
            // 
            this.book_number.Text = "도서 번호";
            this.book_number.Width = 166;
            // 
            // book_name
            // 
            this.book_name.Text = "도서명";
            this.book_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_name.Width = 166;
            // 
            // book_writer
            // 
            this.book_writer.Text = "저자";
            this.book_writer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_writer.Width = 166;
            // 
            // book_publisher
            // 
            this.book_publisher.Text = "출판사";
            this.book_publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_publisher.Width = 166;
            // 
            // book_stock
            // 
            this.book_stock.Text = "재고";
            this.book_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_stock.Width = 166;
            // 
            // book_rentsum
            // 
            this.book_rentsum.Text = "대여량";
            this.book_rentsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_rentsum.Width = 166;
            // 
            // search_textBox
            // 
            this.search_textBox.Location = new System.Drawing.Point(437, 64);
            this.search_textBox.Name = "search_textBox";
            this.search_textBox.Size = new System.Drawing.Size(360, 31);
            this.search_textBox.TabIndex = 4;
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 844);
            this.Controls.Add(this.search_textBox);
            this.Controls.Add(this.search_listView);
            this.Controls.Add(this.search_btn);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.group_comboBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "search_form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox group_comboBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button search_btn;
        private System.Windows.Forms.ListView search_listView;
        private System.Windows.Forms.ColumnHeader book_number;
        private System.Windows.Forms.ColumnHeader book_name;
        private System.Windows.Forms.ColumnHeader book_writer;
        private System.Windows.Forms.ColumnHeader book_publisher;
        private System.Windows.Forms.ColumnHeader book_stock;
        private System.Windows.Forms.ColumnHeader book_rentsum;
        private System.Windows.Forms.TextBox search_textBox;
    }
}