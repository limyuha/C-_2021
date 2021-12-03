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
        private int mem_nm;
        private string issue_dt;
        private string issue_sub;
        private string issue_text;

        public int Issue_no
        {
            get { return issue_no; }
            set { issue_no = value; }
        }
        public int Mem_nm
        {
            get { return mem_nm; }
            set { mem_nm = value; }
        }
        public string Issue_dt
        {
            get { return issue_dt; }
            set { issue_dt = value; }
        }
        public string Issue_sub
        {
            get { return issue_sub; }
            set { issue_sub = value; }
        }
        public string Issue_text
        {
            get { return issue_text; }
            set { issue_text = value; }
        }
    }
}
