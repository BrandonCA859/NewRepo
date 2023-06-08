using DataAccess.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;
using System.Collections.Generic;

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShippingController : ControllerBase
    {
        private readonly ISvShipping _svShipping;

        public ShippingController(ISvShipping svShipping)
        {
            _svShipping = svShipping;
        }

        // POST api/<ShippingController>
        [HttpPost]
        public void Post([FromBody] Shipping shipping)
        {
            _svShipping.Add(shipping);
        }

    }
}
