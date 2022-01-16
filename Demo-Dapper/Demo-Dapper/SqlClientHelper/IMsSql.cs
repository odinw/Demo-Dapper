using System.Data;

namespace Demo_Dapper.SqlClientHelper
{
    public interface IMsSql
    {
        public DataTable Select_Customer();
    }
}
