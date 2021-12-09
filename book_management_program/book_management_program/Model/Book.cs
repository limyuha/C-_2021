using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management_program.Model
{
    class Book
    {
        private int rent_no;
        private string isbn;
        private int cat_no;
        private string cat_nm;
        private string author;
        private string pub;
        private string pub_dt;
        private string book_nm;
        private int stock;
        private int rent_cnt;
        private string rent_dt;
        private string return_dt;
        private int rent_sum;
        private string rent_ck;
        private int overcheck;
        private string ext;

        public string Isbn { get => isbn; set => isbn = value; }
        public int Cat_no { get => cat_no; set => cat_no = value; }
        public string Cat_nm { get => cat_nm; set => cat_nm = value; }
        public string Author { get => author; set => author = value; }
        public string Pub { get => pub; set => pub = value; }
        public string Pub_dt { get => pub_dt; set => pub_dt = value; }
        public string Book_nm { get => book_nm; set => book_nm = value; }
        public int Stock { get => stock; set => stock = value; }
        public int Rent_cnt { get => rent_cnt; set => rent_cnt = value; }
        public string Rent_dt { get => rent_dt; set => rent_dt = value; }
        public string Return_dt { get => return_dt; set => return_dt = value; }
        public int Rent_no { get => rent_no; set => rent_no = value; }
        public int Rent_sum { get => rent_sum; set => rent_sum = value; }
        public int Overcheck { get => overcheck; set => overcheck = value; }
        public string Rent_ck { get => rent_ck; set => rent_ck = value; }
        public string Ext { get => ext; set => ext = value; }
    }
}
