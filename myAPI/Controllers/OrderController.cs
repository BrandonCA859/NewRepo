using DataAccess.Entidades;
using MailKit.Security;
using Microsoft.AspNetCore.Mvc;
using MimeKit;
using Services;
using System.Net.Mail;
using MailKit.Net.Smtp;

namespace myAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly ISvOrder _svOrder;

        public OrderController(ISvOrder svOrder)
        {
            _svOrder = svOrder;
        }

        // GET: api/<OrderController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<OrderController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<OrderController>
        [HttpPost("add")]
        public void AddOrder([FromBody] Order order)
        {
            _svOrder.Add(order);
        }

        // PUT api/<OrderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<OrderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        [HttpPost("create")]
        public IActionResult CreateOrder(Order order)
        {
            try
            {
                _svOrder.CreateOrder(order);
                SendConfirmationEmail(order);

                return Ok("Order created successfully and email sent");
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"An error occurred while creating the order: {ex.Message}");
            }
        }

        private void SendConfirmationEmail(Order order)
        {
            var message = new MimeMessage();
            message.From.Add(new MailboxAddress("Juan Delgado", "juandla78966@gmail.com"));
            message.To.Add(new MailboxAddress("", order.Address));
            message.Subject = "Confirmación de pedido";

            var bodyBuilder = new BodyBuilder();
            bodyBuilder.TextBody = $"Gracias por tu pedido. Tu número de pedido es {order.Id} y el total a pagar es {order.TotalPrice} colones. Su método de pago fue por medio de: {order.PaymentConfirmation.PaymentMethod}";
            message.Body = bodyBuilder.ToMessageBody();

            using (var client = new MailKit.Net.Smtp.SmtpClient())
            {
                client.Connect("smtp.gmail.com", 587, SecureSocketOptions.StartTls);
                client.Authenticate("hezroncastaneda@gmail.com", "vbpfwcecrcmteyuv");
                client.Send(message);
                client.Disconnect(true);
            }
        }
    }
}


