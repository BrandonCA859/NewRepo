using DataAccess.Entidades;
using Microsoft.AspNetCore.Mvc;
using Services;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentConfirmationController : ControllerBase
    {

        private readonly ISvPaymentConfirmation _svPaymentConfirmation;
        public PaymentConfirmationController(ISvPaymentConfirmation SvPaymentConfirmation)
        {



            _svPaymentConfirmation = SvPaymentConfirmation;


        }


        // GET: api/<PaymentConfirmationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<PaymentConfirmationController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<PaymentConfirmationController>
        [HttpPost]
        public void Post([FromBody] PaymentConfirmation paymentConfirmation)
        {

            _svPaymentConfirmation.add(paymentConfirmation);

        }

        // PUT api/<PaymentConfirmationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<PaymentConfirmationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
