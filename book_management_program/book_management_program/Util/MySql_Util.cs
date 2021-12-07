using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace book_management_program.Util
{
    class MySql_Util
    {
        private static MySql_Util instance = new MySql_Util();
        public static MySql_Util Instance
        {
            get { return instance; }
            set { Instance = instance; }
        }

        private string connection;
        private MySqlConnection sqlConn;
        private MySqlCommand sqlCmd;
        private bool return_value;
        private MySqlDataReader result;

        /* DB연동 정보 */
        public MySql_Util()
        {

            return_value = false;

            string database = "c2021";
            string server = "localhost";
            //string user = "c2021";
            //string password = "yuhan";
            string user = "jspid";
            string password = "jsppass";
            connection = "server=" + server
                + ";user=" + user
                + ";database=" + database
                + ";password=" + password
                + ";Allow Zero Datetime=True";
        }

        /* 데이터 Select */
        public MySqlDataReader Select_Sql(String sql)
        {
            var dataTable = new DataTable();
            try
            {
                sqlConn = new MySqlConnection(connection);
                sqlConn.Open();
                sqlCmd = new MySqlCommand(sql, sqlConn);
                MySqlDataReader mySqlDataReader = sqlCmd.ExecuteReader();  // Select 결과

                result = mySqlDataReader;

                //sqlConn.Close();
                return result;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                sqlConn.Close();
                return null; 
            }
        }

        /* 로그인 Select */
        public DataSet Select_Sqlw(String sql)
        {
            try
            {
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                sqlConn = new MySqlConnection(connection);
                sqlConn.Open();
                var dataTable = new DataTable();

                MySqlDataAdapter adpt = new MySqlDataAdapter(sql, sqlConn);
                DataSet ds = new DataSet();
                adpt.Fill(ds, "Tab1");

                sqlConn.Close();
                return ds;

            }
            catch (Exception e)
            {

                MessageBox.Show(e.ToString());
                sqlConn.Close();
                return null;
            }

        }

        /* 관리자 : 도서 리스트 Select */
        public MySqlDataReader BSelect_Sql(String sql)
        {
            var dataTable = new DataTable();
            try
            {
                if (sqlConn != null)
                {
                    sqlConn.Close();
                }
                sqlConn = new MySqlConnection(connection);
                sqlConn.Open();
                sqlCmd = new MySqlCommand(sql, sqlConn);
                MySqlDataReader mySqlDataReader = sqlCmd.ExecuteReader();  // Select 결과

                result = mySqlDataReader;

                //sqlConn.Close();
                return result;

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                sqlConn.Close();
                return null;
            }
        }

        /* Insert, Delete, Update 문 */
        public bool Update_Sql(String sql)
        {
            try
            {
                sqlConn = new MySqlConnection(connection);
                sqlConn.Open();
                sqlCmd = new MySqlCommand(sql, sqlConn);
                if (sqlCmd.ExecuteNonQuery() == 1) // ExecuteNonQuery() : Insert,Delete,Update 메소드
                {
                    sqlConn.Close();
                    return true;
                }
                else
                {
                    sqlConn.Close();
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                sqlConn.Close();
                return false;
            }
        }
        
    }
}
