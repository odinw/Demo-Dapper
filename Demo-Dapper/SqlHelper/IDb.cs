using Demo_Dapper.Dtos;
using System.Collections.Generic;

namespace Demo_Dapper.SqlHelper
{
    public interface IDb
    {
        /// <summary>
        /// get customer all
        /// </summary>
        /// <returns></returns>
        public IEnumerable<CustomerDto> Select_Customer();

        /// <summary>
        /// get customer range
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IEnumerable<CustomerDto> Select_Customer(int[] id);
    }
}
