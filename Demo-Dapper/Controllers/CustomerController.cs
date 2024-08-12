using Demo_Dapper.Models;
using Demo_Dapper.Repository;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace Demo_Dapper.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CustomerController : ControllerBase
{
    readonly CustomerRepository _repository;

    public CustomerController(CustomerRepository repository) => _repository = repository;

    public IEnumerable<CustomerModel> Get()
    {
        var result = _repository.Select_Customer();
        return result;
    }

    [HttpGet("[action]")]
    public IEnumerable<CustomerModel> ByIds(IEnumerable<int> ids)
    {
        var result = _repository.Select_Customer(ids);
        return result;
    }

    [HttpPost]
    public void Post(IEnumerable<CustomerModel> model)
    {
        _repository.Insert(model);
    }

    [HttpDelete]
    public void Delete(IEnumerable<int> id)
    {
        _repository.Delete(id);
    }
}
