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
    public class ProductController : ControllerBase
    {
        private INorthwindData northData;

        public ProductController(INorthwindData _northdata)
        {
            northData = _northdata;
        }

        [HttpGet]
        public IEnumerable<Product> GetProducts()
        {
            return northData.GetAllProducts();
        }

        [HttpGet("{prodid}")]
        public Product GetCustomer(int prodid)
        {
            return northData.GetProductById(prodid);
        }

        [HttpPut("update")]
        public void UpdateAProduct(Product prod)
        {
            northData.UpdateProduct(prod);
        }

        [HttpDelete("delete/{custid}")]
        public void DeleteCustomer(int custid)
        {
            northData.DeleteCustomerById(custid);
        }
    }
}
