using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.API.Models;
using OnlineStore.DAL.Entities;
using OnlineStore.DAL.Repository;
using System.Collections.Generic;

namespace OnlineStore.API.Controllers
{
    [Route("api/category")]
    public class CategoryController: Controller
    {
        private readonly IStoreRepository repository;

        public CategoryController(IStoreRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult GetCategories()
        {
            var categoryEntities = repository.GetCategories();
            var categoryDtos = Mapper.Map<IEnumerable<CategoryDto>>(categoryEntities);

            return Ok(categoryDtos);
        }

        [HttpPost]
        public IActionResult CreateCategory([FromBody] CategoryForCreationDto categoryForCreationDto)
        {
            if (categoryForCreationDto == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var categoryEntity = Mapper.Map<Category>(categoryForCreationDto);
            repository.AddCategory(categoryEntity);

            repository.Save();

            return Ok();
        }
    }
}
