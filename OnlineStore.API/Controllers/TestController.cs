using Microsoft.AspNetCore.Mvc;
using OnlineStore.DAL.Repository;

namespace OnlineStore.API.Controllers
{
    [Route("api/test")]
    public class TestController: Controller
    {
        private readonly IStoreRepository repository;

        public TestController(IStoreRepository repository)
        {
            this.repository = repository;
        }

        [HttpGet]
        public IActionResult Test()
        {
            return Ok();
        }
    }
}
