using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace test.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        [HttpGet]
        public string GetProduct()
        {
            return "this is the list of All product";
        }
        [HttpPost]
        public string CreateProduct()
        {
            return "this is create product";
        }
        [HttpPut]
        public string UpdateProduct()
        {
            return "this is update product";
        }

        [HttpDelete]
        public string DeleteProduct()
        {
            return "this is Delete product";
        }
    }
}