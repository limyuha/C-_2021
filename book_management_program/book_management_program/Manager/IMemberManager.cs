using book_management_program.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management_program.Manager
{
    interface IMemberManager
    {
        bool MemLogin(string id, string password);
        void MemInfoDelete(int mem_no);
        void MemInfoInsert(Member member);
        Member MemInfoLookup(string mem_nm);
        List<Member> MemList();

        int MemRentListCnt(int mem_no);
        List<Book> MemRentList(int mem_no);

        int memResvListcnt(int mem_no);
        List<Book> MemResvList(int mem_no);

        List<Issue> MemIssueList(int mem_no);
    }
}
