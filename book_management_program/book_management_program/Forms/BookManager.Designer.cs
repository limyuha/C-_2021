
namespace book_management_program.Forms
{
    partial class book_manager
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
            this.panel7 = new System.Windows.Forms.Panel();
            this.book_manager_label = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
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
            this.book_listView = new System.Windows.Forms.ListView();
            this.book_number = new System.Windows.Forms.ColumnHeader();
            this.cat_no = new System.Windows.Forms.ColumnHeader();
            this.book_writer = new System.Windows.Forms.ColumnHeader();
            this.book_publisher = new System.Windows.Forms.ColumnHeader();
            this.pub_dt = new System.Windows.Forms.ColumnHeader();
            this.book_name = new System.Windows.Forms.ColumnHeader();
            this.book_stock = new System.Windows.Forms.ColumnHeader();
            this.book_rentsum = new System.Windows.Forms.ColumnHeader();
            this.panel7.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.book_listView);
            this.panel7.Controls.Add(this.book_manager_label);
            this.panel7.Location = new System.Drawing.Point(21, 21);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(893, 788);
            this.panel7.TabIndex = 15;
            // 
            // book_manager_label
            // 
            this.book_manager_label.AutoSize = true;
            this.book_manager_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.book_manager_label.Location = new System.Drawing.Point(1, 21);
            this.book_manager_label.Name = "book_manager_label";
            this.book_manager_label.Size = new System.Drawing.Size(95, 29);
            this.book_manager_label.TabIndex = 6;
            this.book_manager_label.Text = "도서 관리";
            // 
            // groupBox1
            // 
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
            this.groupBox1.Location = new System.Drawing.Point(929, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(293, 788);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "등록 / 수정 / 재고 추가 / 삭제";
            // 
            // book_delete_btn
            // 
            this.book_delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.book_delete_btn.FlatAppearance.BorderSize = 0;
            this.book_delete_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.book_delete_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.book_delete_btn.ForeColor = System.Drawing.Color.White;
            this.book_delete_btn.Location = new System.Drawing.Point(23, 694);
            this.book_delete_btn.Name = "book_delete_btn";
            this.book_delete_btn.Size = new System.Drawing.Size(249, 48);
            this.book_delete_btn.TabIndex = 20;
            this.book_delete_btn.Text = "삭제";
            this.book_delete_btn.UseVisualStyleBackColor = false;
            this.book_delete_btn.Click += new System.EventHandler(this.book_delete_btn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(16, 390);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "재고";
            // 
            // book_stock_textBox
            // 
            this.book_stock_textBox.BackColor = System.Drawing.Color.White;
            this.book_stock_textBox.Location = new System.Drawing.Point(23, 422);
            this.book_stock_textBox.Name = "book_stock_textBox";
            this.book_stock_textBox.Size = new System.Drawing.Size(249, 31);
            this.book_stock_textBox.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(16, 303);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 26);
            this.label2.TabIndex = 17;
            this.label2.Text = "출판사";
            // 
            // book_publisher_textBox
            // 
            this.book_publisher_textBox.BackColor = System.Drawing.Color.White;
            this.book_publisher_textBox.Location = new System.Drawing.Point(23, 335);
            this.book_publisher_textBox.Name = "book_publisher_textBox";
            this.book_publisher_textBox.Size = new System.Drawing.Size(249, 31);
            this.book_publisher_textBox.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(16, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 26);
            this.label1.TabIndex = 19;
            this.label1.Text = "저자";
            // 
            // book_writer_textBox
            // 
            this.book_writer_textBox.BackColor = System.Drawing.Color.White;
            this.book_writer_textBox.Location = new System.Drawing.Point(23, 249);
            this.book_writer_textBox.Name = "book_writer_textBox";
            this.book_writer_textBox.Size = new System.Drawing.Size(249, 31);
            this.book_writer_textBox.TabIndex = 18;
            // 
            // stock_add_btn
            // 
            this.stock_add_btn.BackColor = System.Drawing.Color.Red;
            this.stock_add_btn.FlatAppearance.BorderSize = 0;
            this.stock_add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stock_add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.stock_add_btn.ForeColor = System.Drawing.Color.White;
            this.stock_add_btn.Location = new System.Drawing.Point(23, 629);
            this.stock_add_btn.Name = "stock_add_btn";
            this.stock_add_btn.Size = new System.Drawing.Size(249, 48);
            this.stock_add_btn.TabIndex = 17;
            this.stock_add_btn.Text = "재고 추가";
            this.stock_add_btn.UseVisualStyleBackColor = false;
            // 
            // modify_btn
            // 
            this.modify_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.modify_btn.FlatAppearance.BorderSize = 0;
            this.modify_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.modify_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.modify_btn.ForeColor = System.Drawing.Color.White;
            this.modify_btn.Location = new System.Drawing.Point(23, 561);
            this.modify_btn.Name = "modify_btn";
            this.modify_btn.Size = new System.Drawing.Size(249, 48);
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
            this.rent_btn.Location = new System.Drawing.Point(23, 494);
            this.rent_btn.Name = "rent_btn";
            this.rent_btn.Size = new System.Drawing.Size(249, 48);
            this.rent_btn.TabIndex = 9;
            this.rent_btn.Text = "등록";
            this.rent_btn.UseVisualStyleBackColor = false;
            this.rent_btn.Click += new System.EventHandler(this.rent_btn_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(16, 128);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(63, 26);
            this.label11.TabIndex = 15;
            this.label11.Text = "도서명";
            // 
            // book_name_textBox
            // 
            this.book_name_textBox.BackColor = System.Drawing.Color.White;
            this.book_name_textBox.Location = new System.Drawing.Point(23, 160);
            this.book_name_textBox.Name = "book_name_textBox";
            this.book_name_textBox.Size = new System.Drawing.Size(249, 31);
            this.book_name_textBox.TabIndex = 14;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(16, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 26);
            this.label10.TabIndex = 13;
            this.label10.Text = "도서번호";
            // 
            // book_number_textBox
            // 
            this.book_number_textBox.BackColor = System.Drawing.Color.White;
            this.book_number_textBox.Enabled = false;
            this.book_number_textBox.Location = new System.Drawing.Point(23, 76);
            this.book_number_textBox.Name = "book_number_textBox";
            this.book_number_textBox.Size = new System.Drawing.Size(249, 31);
            this.book_number_textBox.TabIndex = 0;
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
            this.book_stock,
            this.book_rentsum});
            this.book_listView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.book_listView.FullRowSelect = true;
            this.book_listView.HideSelection = false;
            this.book_listView.Location = new System.Drawing.Point(0, 65);
            this.book_listView.Name = "book_listView";
            this.book_listView.Size = new System.Drawing.Size(893, 723);
            this.book_listView.TabIndex = 7;
            this.book_listView.UseCompatibleStateImageBehavior = false;
            this.book_listView.View = System.Windows.Forms.View.Details;
            // 
            // book_number
            // 
            this.book_number.Text = "ISBN";
            this.book_number.Width = 110;
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
            this.book_writer.Width = 110;
            // 
            // book_publisher
            // 
            this.book_publisher.Text = "출판사";
            this.book_publisher.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_publisher.Width = 130;
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
            this.book_name.Width = 158;
            // 
            // book_stock
            // 
            this.book_stock.Text = "재고";
            this.book_stock.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_stock.Width = 80;
            // 
            // book_rentsum
            // 
            this.book_rentsum.Text = "대여량";
            this.book_rentsum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.book_rentsum.Width = 80;
            // 
            // book_manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 844);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "book_manager";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "book_manager";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.ColumnHeader book_rentsum;
    }
}