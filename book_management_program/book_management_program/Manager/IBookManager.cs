using book_management_program.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management_program.Manager
{
    interface IBookManager
    {
        void BookInfoInsert(Book book);
        void BookInfoDelete(String isbn);

        List<Book> BookInfoList();
        void BookRent(String isbn);
        void BookReturn(String isbn);
        void BookResvUpdate(String isbn);
        void BookResvCancel(String isbn);
        List<Book> BookSearch(String type, String search); //type = 검색 기준 : 도서명-book_nm, 저자-author, 출판사-pub

        int TodayRentSum();
        float TermRentAvg();
        int BookCount();
        List<Book> BookRentRanking();

        void RentListIn(string mem_nm, string isbn);
        void RentListDel(string mem_nm, string isbn);

        string RentExtCheck(string mem_nm, string isbn);
        void RentExtUpdate(string mem_nm, string isbn);

        void ResvListIn(string mem_nm, string isbn);
        void ResvListDel(string mem_nm, string isbn);
    }
}
