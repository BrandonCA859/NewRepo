using DataAccess.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {

        private readonly ISvProducts _svProducts;
        public ProductsController(ISvProducts svProducts)
        {
            _svProducts = svProducts;
        }


        // GET: api/<ProductsController>
        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return _svProducts.GetAll();
        }

        // GET api/<ProductsController>/5
        [HttpGet("{id}")]
        public Product Get(int id)
        {
            return _svProducts.GetById(id);
        }

        // POST api/<ProductsController>
        [HttpPost]
        public void Post([FromBody] Product products)
        {
            _svProducts.Add(products);
        }

        // PUT api/<ProductsController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Product products)
        {
            _svProducts.Add(products);
        }

        // DELETE api/<ProductsController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _svProducts.Delete(id);

        }
    }
}