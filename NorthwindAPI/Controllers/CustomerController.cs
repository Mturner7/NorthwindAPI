using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NorthwindAPI.Models;
using NorthwindAPI.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NorthwindAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private INorthwindData northData;

        public CustomerController(INorthwindData _northdata)
        {
            northData = _northdata;
        }

        [HttpGet]
        public IEnumerable<Customer> GetCustomers()
        {
            return northData.GetAllCustomers();
        }

        [HttpGet("{custid}")]
        public Customer GetCustomer(int custid)
        {
            return northData.GetCustomerById(custid);
        }

        [HttpPut("update")]
        public void UpdateACustomer(Customer cust)
        {
            northData.UpdateCustomer(cust);
        }

        [HttpPost("add")]
        public void CreateCategory(Customer cust)
        {
            northData.AddCustomer(cust);
        }

        [HttpDelete("delete/{custid}")]
        public void DeleteCustomer(int custid)
        {
            northData.DeleteCustomerById(custid);
        }
        
    }
}
