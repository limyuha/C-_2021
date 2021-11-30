using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public MySql_Util()
        {

            return_value = false;

            string database = "c2021";
            string server = "localhost";
            string user = "c2021";
            string password = "yuhan";
            connection = "server=" + server 
                + ";user=" + user 
                + ";database=" + database 
                + ";password=" + password;
        }

        public bool Insert_Sql(String sql)
        {
            try
            {
                sqlConn = new MySqlConnection(connection);
                sqlConn.Open();
                sqlCmd = new MySqlCommand(sql, sqlConn);
                if (sqlCmd.ExecuteNonQuery() == 1) // ExecuteNonQuery() : Insert,Delete 메소드
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
                return false;
            }
        }

        public string Select_Sql(String sql)
        {
            try
            {
                sqlConn = new MySqlConnection(connection);
                sqlConn.Open();
                var dataTable = new DataTable();
                sqlCmd = new MySqlCommand(sql, sqlConn);
                MySqlDataReader mySqlDataReader = sqlCmd.ExecuteReader();  // Select 결과
                dataTable.Load(mySqlDataReader);

                /*
                StringBuilder output = new StringBuilder();
                foreach(DataColumn column in dataTable.Columns)
                {
                    output.AppendFormat("{0}", column);
                }
                output.AppendLine();

                foreach (DataRow page in dataTable.Rows)
                {
                    foreach(DataColumn column in dataTable.Columns)
                    {
                        output.AppendFormat("{0}", page[column]);
                    }
                    output.AppendLine();
                }*/

                mySqlDataReader.Close();
                return_value = true;
                return "true";
            }
            catch (Exception e)
            {
                return "false:" + e.ToString();
            }
            sqlConn.Close();
        }
    }
}
