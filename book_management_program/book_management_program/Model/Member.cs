using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management_program.Model
{
    class Member
    {
        private string mem_nm;
        private string pw;
        private string mem_grade;
        private string phone_no;


        public string Mem_nm
        {
            get { return mem_nm; }
            set { mem_nm = value; }
        }

        public string Pw
        {
            get { return pw; }
            set { pw = value; }
        }

        public string Mem_grade
        {
            get { return mem_grade; }
            set { mem_grade = value; }
        }

        public string Phone_no
        {
            get { return phone_no; }
            set { phone_no = value; }
        }
    }
}
