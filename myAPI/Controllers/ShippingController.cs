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

        // GET: api/<ShippingController>
        [HttpGet]
        public IEnumerable<Shipping> Get()
        {
            return _svShipping.ListShippings();
        }

        // GET api/<ShippingController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ShippingController>
        [HttpPost]
        public void Post([FromBody] Shipping value)
        {
            _svShipping.Add(value);
        }

        // POST api/<ShippingController>
        [HttpPost("{id}")]
        public void Add(int id, [FromBody] Shipping value)
        {
            _svShipping.Add(value);
        }
    }
}
