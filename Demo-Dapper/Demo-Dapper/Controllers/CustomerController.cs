using Demo_Dapper.SqlClientHelper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Demo_Dapper.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private readonly IConfiguration _configuration;
        private readonly IMsSql _msSql;

        public CustomerController(ILogger<CustomerController> logger, IConfiguration configuration, IMsSql msSql)
        {
            _logger = logger;
            _configuration = configuration;
            _msSql = msSql;
        }

        [HttpGet]
        public IEnumerable<Customer> Get()
        {
            var customers = _msSql.Select_Customer();

            List<Customer> name = new List<Customer>();
            foreach (DataRow customer in customers.Rows)
            {
                name.Add(new Customer
                {
                    Name = customer[nameof(Customer.Name)].ToString(),
                    Age = int.Parse(customer[nameof(Customer.Age)].ToString())
                });
            }

            return name;
        }
    }
}
