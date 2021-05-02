using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using web_api_metrics.Models;
using web_api_metrics.Repositories;

namespace web_api_metrics.Controllers
{
    [ApiController]
    [Route("api/customers")]
    public class CustomerController : ControllerBase
    {
        private readonly ILogger<CustomerController> _logger;
        private CustomerRepository _customerRepository;


        public CustomerController(ILogger<CustomerController> logger)
        {
            _logger = logger;
            _customerRepository = new CustomerRepository();
        }

        [HttpGet]
        [Route("")]
        public IEnumerable<Customer> Customers()
        {
            return _customerRepository.GetCustomers();
        }


        [HttpGet]
        [Route("customer")]
        public Customer CustomerById([FromQuery] int id)
        {
            return _customerRepository.CustomerById(id);
        }
    }
}
