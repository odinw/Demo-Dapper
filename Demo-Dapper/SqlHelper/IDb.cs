using Demo_Dapper.Dtos;
using System.Collections.Generic;

namespace Demo_Dapper.SqlHelper
{
    public interface IDb
    {
        /// <summary>
        /// get all customer
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerDto> Select_Customer();
    }
}
