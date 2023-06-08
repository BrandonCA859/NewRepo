using DataAccess.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderItemController : ControllerBase
    {
        private readonly ISvOrderItem _svOrderItem;
        public OrderItemController(ISvOrderItem svOrderItem)
        {
            _svOrderItem = svOrderItem;
        }
       

        // POST api/<OrderItemController>
        [HttpPost]
        public void Post([FromBody] OrderItem orderItem)
        {

            _svOrderItem.add(orderItem);   

        }
    }
}
