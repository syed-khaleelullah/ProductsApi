using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AzureDevopsDemoProductsApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AzureDevopsDemoProductsApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ProductsRepository repository;

        public ProductsController(ProductsRepository repository)
        {
            this.repository = repository;
        }

        public IActionResult Get()
        {
            return Ok(repository.GetAll());
        }

        [HttpGet("{id}")]
        //[Route("{id}")]
        public IActionResult Get(int id)
        {
            var product = repository.Get(id);
            if (product == null)
                return NotFound();
            return Ok(product);
        }

    }
}
