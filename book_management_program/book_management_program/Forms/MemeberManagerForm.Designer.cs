
namespace book_management_program.Forms
{
    partial class MemeberManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MemeberManagerForm));
            this.panel7 = new System.Windows.Forms.Panel();
            this.member_manager_label = new System.Windows.Forms.Label();
            this.member_manager_listView = new System.Windows.Forms.ListView();
            this.no = new System.Windows.Forms.ColumnHeader();
            this.id = new System.Windows.Forms.ColumnHeader();
            this.pw = new System.Windows.Forms.ColumnHeader();
            this.tel = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tel_textBox = new System.Windows.Forms.TextBox();
            this.member_delete_btn = new System.Windows.Forms.Button();
            this.member_add_btn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pw_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.id_textBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.no_textBox = new System.Windows.Forms.TextBox();
            this.panel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.member_manager_label);
            this.panel7.Controls.Add(this.member_manager_listView);
            resources.ApplyResources(this.panel7, "panel7");
            this.panel7.Name = "panel7";
            // 
            // member_manager_label
            // 
            resources.ApplyResources(this.member_manager_label, "member_manager_label");
            this.member_manager_label.Name = "member_manager_label";
            // 
            // member_manager_listView
            // 
            this.member_manager_listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.no,
            this.id,
            this.pw,
            this.tel});
            resources.ApplyResources(this.member_manager_listView, "member_manager_listView");
            this.member_manager_listView.HideSelection = false;
            this.member_manager_listView.Name = "member_manager_listView";
            this.member_manager_listView.UseCompatibleStateImageBehavior = false;
            this.member_manager_listView.View = System.Windows.Forms.View.Details;
            // 
            // no
            // 
            resources.ApplyResources(this.no, "no");
            // 
            // id
            // 
            resources.ApplyResources(this.id, "id");
            // 
            // pw
            // 
            resources.ApplyResources(this.pw, "pw");
            // 
            // tel
            // 
            resources.ApplyResources(this.tel, "tel");
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.tel_textBox);
            this.panel1.Controls.Add(this.member_delete_btn);
            this.panel1.Controls.Add(this.member_add_btn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pw_textBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.id_textBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.no_textBox);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // tel_textBox
            // 
            this.tel_textBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.tel_textBox, "tel_textBox");
            this.tel_textBox.Name = "tel_textBox";
            // 
            // member_delete_btn
            // 
            this.member_delete_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.member_delete_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.member_delete_btn, "member_delete_btn");
            this.member_delete_btn.ForeColor = System.Drawing.Color.White;
            this.member_delete_btn.Name = "member_delete_btn";
            this.member_delete_btn.UseVisualStyleBackColor = false;
            // 
            // member_add_btn
            // 
            this.member_add_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.member_add_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.member_add_btn, "member_add_btn");
            this.member_add_btn.ForeColor = System.Drawing.Color.White;
            this.member_add_btn.Name = "member_add_btn";
            this.member_add_btn.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // pw_textBox
            // 
            this.pw_textBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.pw_textBox, "pw_textBox");
            this.pw_textBox.Name = "pw_textBox";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // id_textBox
            // 
            this.id_textBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.id_textBox, "id_textBox");
            this.id_textBox.Name = "id_textBox";
            // 
            // label10
            // 
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // no_textBox
            // 
            this.no_textBox.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this.no_textBox, "no_textBox");
            this.no_textBox.Name = "no_textBox";
            // 
            // MemeberManagerForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            resources.ApplyResources(this, "$this");
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel7);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MemeberManagerForm";
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label member_manager_label;
        private System.Windows.Forms.ListView member_manager_listView;
        private System.Windows.Forms.ColumnHeader no;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader pw;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pw_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox id_textBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox no_textBox;
        private System.Windows.Forms.Button member_delete_btn;
        private System.Windows.Forms.Button member_add_btn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tel_textBox;
        private System.Windows.Forms.ColumnHeader tel;
    }
}