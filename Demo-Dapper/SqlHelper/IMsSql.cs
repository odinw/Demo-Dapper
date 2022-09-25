using System.Data;

namespace Demo_Dapper.SqlHelper
{
    public interface IMsSql
    {
        public DataTable Select_Customer();
    }
}
