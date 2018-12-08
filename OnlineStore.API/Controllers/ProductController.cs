using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.Models;
using OnlineStore.DAL.Repository;
using System.Collections.Generic;

namespace OnlineStore.API.Controllers
{
    [Route("api/product")]
    public class ProductController: Controller
    {
        private readonly IStoreRepository repository;

        public ProductController(IStoreRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetProducts()
        {
            var productEntities = repository.GetProducts();
            var productDtos = Mapper.Map<IEnumerable<ProductDto>>(productEntities);

            return Ok(productDtos);
        }

        [HttpPost]
        public IActionResult CreateProduct([FromBody] ProductForCreationDto productForCreationDto)
        {

        }
    }
}
