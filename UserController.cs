using Microsoft.AspNetCore.Mvc;
using MyApi.Models;
using MyApi.Services;


using Microsoft.Extensions.Options;

using MongoDB.Driver;

using MyApi.Models;


namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly MongoServices _services;

        public UserController(MongoServices services)
        {
            _services = services;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var user = await _services.GetUsers();
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> Create(User user)
        {
            var newUser = await _services.AddUser(user);
            return Ok(newUser);
        }
    }
}
