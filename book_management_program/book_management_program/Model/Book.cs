using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management_program.Model
{
    class Book
    {
        private string isbn;
        private int cat_no;
        private string author;
        private string pub;
        private DateTime pub_dt;
        private string book_nm;
        private int stock;

        public string Isbn { get => isbn; set => isbn = value; }
        public int Cat_no { get => cat_no; set => cat_no = value; }
        public string Author { get => author; set => author = value; }
        public string Pub { get => pub; set => pub = value; }
        public DateTime Pub_dt { get => pub_dt; set => pub_dt = value; }
        public string Book_nm { get => book_nm; set => book_nm = value; }
        public int Stock { get => stock; set => stock = value; }
    }
}
