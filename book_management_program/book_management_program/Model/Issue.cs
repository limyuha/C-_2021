using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management_program.Model
{
    class Issue
    {
        private int issue_no;
        private int mem_no;
        private string mem_nm;
        private DateTime issue_dt;
        private string issue_title;
        private string issue_text;

        public int Issue_no
        {
            get { return issue_no; }
            set { issue_no = value; }
        }
        public int Mem_no
        {
            get { return mem_no; }
            set { mem_no = value; }
        }
        public DateTime Issue_dt
        {
            get { return issue_dt; }
            set { issue_dt = value; }
        }
        public string Issue_title
        {
            get { return issue_title; }
            set { issue_title = value; }
        }
        public string Issue_text
        {
            get { return issue_text; }
            set { issue_text = value; }
        }

        public string Mem_nm { get => mem_nm; set => mem_nm = value; }
    }
}
