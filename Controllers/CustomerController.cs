using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValkyraECommerce.DatabaseDto.Shop;

namespace ValkyraECommerce.Controllers
{
    [Route("api")]
    public class CustomerController : Controller
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet("Customers/{customerId}")]
        public Customer GetCustomer(int customerId)
        {
            return _customerService.GetCustomers(customerId);
        }

        [HttpPut("Customers/{customerId}")]
        public void UpdateCustomer(int customerId, [FromBody]Customer customer)
        {
            _customerService.UpdateCustomer(customer);
        }
    }
}