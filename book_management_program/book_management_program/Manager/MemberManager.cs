using static book_management_program.Util.MySql_Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_management_program.Manager
{
    class MemberManager
    {

        /* 회원 정보 등록 */
        public static bool MemInfoInsert(Model.Member member)
        {
            //string sql = "INSERT INTO member VALUES(입력)";
            //bool result = Instance.Insert_Sql(sql);
            //return result;
            return true;
        }


        //string sql = "SELECT * FROM conntest;"
        //MySql_Util.Instance.Select_Sql(sql);

    }
}
