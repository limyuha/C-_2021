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
        void MemInfoInsert();
        Member MemInfoLookup(string mem_nm);
        List<Member> MemList();

        int MemRentListCnt(string mem_nm);
        List<Book> MemRentList(string mem_nm);

        int memResvListcnt(string mem_nm);
        List<Book> MemResvList(string mem_nm);

        List<Issue> MemIssueList(string mem_nm);
    }
}
