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
        void IssueInsert(Issue issue); //글 등록 
        void IssueDelete(int issue_no); // 글 삭제
        Issue IssueSelect(int issue_no); //글 내용 보기 

        List<Issue> IssueList(); // 전체 글 목록 조회
    }
}
