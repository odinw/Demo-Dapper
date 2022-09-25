using Dapper;
using Demo_Dapper.Dtos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Demo_Dapper.SqlHelper
{
    public class Db : IDb
    {
        readonly string _dbString;

        public Db(string dbString)
        {
            _dbString = dbString;
        }

        public IEnumerable<CustomerDto> Select_Customer()
        {
            using var connection = new SqlConnection(_dbString);
            var sql = "SELECT * FROM Customer";
            var result = connection.Query<CustomerDto>(sql);
            return result;
        }
    }
}
