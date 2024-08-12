using Demo_Dapper.Dtos;
using Demo_Dapper.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo_Dapper.Controllers;

[ApiController]
[Route("[controller]")]
public class CustomerController : ControllerBase
{
    readonly CustomerRepository _repository;

    public CustomerController(CustomerRepository repository) => _repository = repository;

    public IEnumerable<CustomerDto> Get()
    {
        var result = _repository.Select_Customer();
        return result;
    }
}
