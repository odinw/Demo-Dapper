using Dapper;
using Demo_Dapper.Models;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;

namespace Demo_Dapper.Repository;

public class CustomerRepository
{
    readonly SqlConnection _db;

    public CustomerRepository(string dbString) => _db = new SqlConnection(dbString);

    public IEnumerable<CustomerModel> Select_Customer()
    {
        var sql = @"
SELECT
    *
FROM
    Customer";
        var result = _db.Query<CustomerModel>(sql);
        return result;
    }

    public IEnumerable<CustomerModel> Select_Customer(IEnumerable<int> id)
    {
        var sql = @"
SELECT
    *
FROM
    Customer
WHERE
    id IN @id";
        var parameters = new
        {
            id
        };
        var result = _db.Query<CustomerModel>(sql, parameters);
        return result;
    }

    public void Insert(IEnumerable<CustomerModel> data)
    {
        var sql = @"
INSERT INTO
	Customer
VALUES
	(@Name, @Age)
";
        _db.Execute(sql, data);
    }

    public void Delete(IEnumerable<int> id)
    {
        var sql = @"
DELETE FROM
	Customer
WHERE
	id IN @id
";
        var parameters = new
        {
            id
        };
        _db.Execute(sql, parameters);
    }
}
