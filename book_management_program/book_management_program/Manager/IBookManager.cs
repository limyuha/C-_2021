using book_management_program.Model;
using System;
using System.Collections.Generic;
using System;
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

            bool BookRent(int mem_no, String isbn);
            bool BookReturn(int mem_no, String isbn);
            //void BookResvUpdate(String mem_no, String isbn);
            //void BookResvCancel(String mem_no, String isbn);
            List<Book> BookSearch(String type, String search);  //type = 검색 기준 : 도서명-book_nm, 저자-author, 출판사-pub

            int TodayRentSum();
            float TermRentAvg();
            int BookCount();
            List<Book> BookRentRanking();

            string RentExtCheck(int mem_no, string isbn);
            bool RentExtUpdate(int mem_no, string isbn);

            bool ResvListIn(int mem_no, string isbn);
            bool ResvListDel(int mem_no, string isbn);
        }
    }
