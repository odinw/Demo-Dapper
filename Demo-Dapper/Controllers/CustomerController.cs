using Demo_Dapper.Dtos;
using Demo_Dapper.SqlHelper;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo_Dapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        readonly IDb _db;

        public CustomerController(IDb db)
        {
            _db = db;
        }

        public IEnumerable<CustomerDto> Get()
        {
            var result = _db.Select_Customer();
            return result;
        }

        [HttpGet]
        public IEnumerable<CustomerDto> Get([FromBody] int[] id)
        {
            var result = _db.Select_Customer(id);
            return result;
        }
    }
}
