using System;
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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Point parentPoint = this.Location;

            mypage mypage = new mypage();
            mypage.StartPosition = FormStartPosition.Manual;
            //mypage.Location = new Point(parentPoint.X+150, parentPoint.Y+45);
            mypage.Location = new Point(parentPoint.X + 155, parentPoint.Y + 45);
            mypage.Show();
        }
    }
}
