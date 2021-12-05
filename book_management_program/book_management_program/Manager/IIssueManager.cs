using book_management_program.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management_program.Manager
{
    interface IIssueManager
    {
        void IssueInsert(Issue issue);
        void IssueDelete(int issue_no);

        List<Issue> IssueList();
        List<Issue> IssueList(int mem_no);
    }
}
