﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_management_program.Forms
{
    public partial class issue : Form
    {
        public issue()
        {
            InitializeComponent();
        }

        private void issue_write_btn_Click(object sender, EventArgs e)
        {
            issue_write issue_write = new issue_write();
            issue_write.ShowDialog();
        }
    }
}
