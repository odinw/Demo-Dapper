using System.Data;
using System.Data.SqlClient;

namespace Demo_Dapper.SqlClientHelper
{
    public class MsSql : IMsSql
    {
        readonly string _connectionInfo;

        public MsSql(string connectionInfo)
        {
            _connectionInfo = connectionInfo;
        }

        private DataTable Run(string sql)
        {
            using SqlConnection connection = new SqlConnection(_connectionInfo);
            using SqlCommand command = new SqlCommand(sql, connection);
            connection.Open();
            using SqlDataReader reader = command.ExecuteReader();

            if (reader.HasRows)
            {
                DataTable dt = new DataTable();
                dt.Load(reader);
                return dt;
            }

            return new DataTable();
        }

        /// <summary>
        /// 取得客戶
        /// </summary>
        /// <returns></returns>
        public DataTable Select_Customer()
        {
            string query = @$"SELECT * FROM Customer";
            return Run(query);
        }
    }
}
