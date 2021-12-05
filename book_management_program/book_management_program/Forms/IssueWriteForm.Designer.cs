
namespace book_management_program.Forms
{
    partial class IssueWriteForm
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
            this.title_label = new System.Windows.Forms.Label();
            this.title_textBox = new System.Windows.Forms.TextBox();
            this.context_label = new System.Windows.Forms.Label();
            this.context_textBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.add_btn = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.title_label.ForeColor = System.Drawing.Color.White;
            this.title_label.Location = new System.Drawing.Point(66, 16);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(33, 20);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "제목";
            // 
            // title_textBox
            // 
            this.title_textBox.Location = new System.Drawing.Point(66, 37);
            this.title_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.title_textBox.Name = "title_textBox";
            this.title_textBox.Size = new System.Drawing.Size(344, 23);
            this.title_textBox.TabIndex = 1;
            // 
            // context_label
            // 
            this.context_label.AutoSize = true;
            this.context_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.context_label.ForeColor = System.Drawing.Color.White;
            this.context_label.Location = new System.Drawing.Point(66, 67);
            this.context_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.context_label.Name = "context_label";
            this.context_label.Size = new System.Drawing.Size(33, 20);
            this.context_label.TabIndex = 2;
            this.context_label.Text = "내용";
            // 
            // context_textBox
            // 
            this.context_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.context_textBox.Location = new System.Drawing.Point(0, 0);
            this.context_textBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.context_textBox.Multiline = true;
            this.context_textBox.Name = "context_textBox";
            this.context_textBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.context_textBox.Size = new System.Drawing.Size(342, 181);
            this.context_textBox.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.context_textBox);
            this.panel1.Location = new System.Drawing.Point(66, 91);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 181);
            this.panel1.TabIndex = 4;
            // 
            // add_btn
            // 
            this.add_btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.add_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.add_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.add_btn.ForeColor = System.Drawing.Color.White;
            this.add_btn.Location = new System.Drawing.Point(66, 280);
            this.add_btn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.add_btn.Name = "add_btn";
            this.add_btn.Size = new System.Drawing.Size(342, 29);
            this.add_btn.TabIndex = 4;
            this.add_btn.Text = "등록";
            this.add_btn.UseVisualStyleBackColor = true;
            this.add_btn.Click += new System.EventHandler(this.add_btn_Click);
            // 
            // IssueWriteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(475, 326);
            this.Controls.Add(this.add_btn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.context_label);
            this.Controls.Add(this.title_textBox);
            this.Controls.Add(this.title_label);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "IssueWriteForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "issue_write";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.TextBox title_textBox;
        private System.Windows.Forms.Label context_label;
        private System.Windows.Forms.TextBox context_textBox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button add_btn;
    }
}