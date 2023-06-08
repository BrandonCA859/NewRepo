 using DataAccess.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ISvUser _svUser;
        public UsersController(ISvUser svUser)
        {
            _svUser = svUser;
        }
        // GET: api/<UsersController>
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _svUser.ListUsers();
        }
        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] User user)
        {
            _svUser.Add(user);
        }

    }
}
