using Dapper;
using Demo_Dapper.Dtos;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Demo_Dapper.SqlHelper
{
    public class Db : IDb
    {
        readonly SqlConnection _sqlconnection;

        public Db(string dbString)
        {
            _sqlconnection = new SqlConnection(dbString);
        }

        public IEnumerable<CustomerDto> Select_Customer()
        {
            var sql = "SELECT * FROM Customer";
            var result = _sqlconnection.Query<CustomerDto>(sql);
            return result;
        }

        public IEnumerable<CustomerDto> Select_Customer(int[] id)
        {
            var sql = "SELECT * FROM Customer WHERE id IN @id";
            var parameters = new
            {
                id = id
            };
            var result = _sqlconnection.Query<CustomerDto>(sql, parameters);
            return result;
        }
    }
}
