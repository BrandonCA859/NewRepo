using DataAccess.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ISvCart _svCart;

        public CartController(ISvCart svCart)
        {
            _svCart = svCart;
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public void Post([FromBody] Cart cart)
        {
            _svCart.Add(cart);
        }

    }
}