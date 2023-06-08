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


        // POST api/<PaymentConfirmationController>
        [HttpPost]
        public void Post([FromBody] PaymentConfirmation paymentConfirmation)
        {
            _svPaymentConfirmation.add(paymentConfirmation);
        }

    }
}
