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
        void BookInfoInsert(Book book);                     // BookManager.cs 도서 등록 버튼 기능
        void BookInfoDelete(String isbn);                   // BookManager.cs 도서 삭제 버튼 기능
        void BookInfoUpdate(Book book);
        List<Book> BookInfoList();                          // BookManager.cs 도서 리스트 기능
        void BookRent(String mem_nm , String isbn);
        void BookReturn(String mem_nm , String isbn);
        void BookResvUpdate(String mem_nm , String isbn);
        void BookResvCancel(String mem_nm , String isbn);
        List<Book> BookSearch(String type, String search);  //type = 검색 기준 : 도서명-book_nm, 저자-author, 출판사-pub

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
