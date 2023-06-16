using DataAccess;
using DataAccess.Entidades;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvOrder : ISvOrder
    {

        private readonly MyDbContext _myDbContext;
        private readonly ISvProduct _svProducts;
        public SvOrder(MyDbContext myDbContext, ISvProduct svProducts)
        {
            _svProducts = svProducts;
            _myDbContext = myDbContext;
        }
      
      
        public Order Add(Order order)
        {
            foreach (OrderItem item in order.OrderItems) {
                item.product = _svProducts.GetById(item.ProductId);
                item.Subtotal = item.Quantity * item.product.Price;


            }

            order.TotalPrice = order.OrderItems.Sum(x => x.Subtotal);

            _myDbContext.Orders.Add(order);
            SendEmail("juandla78966@gmail.com", "StewardxHezron", order.TotalPrice.ToString());

            _myDbContext.SaveChanges();

            return order;
        }
        public void CreateOrder(Order order)
        {
            _myDbContext.Orders.Add(order);
            _myDbContext.SaveChanges();
        }
        public void SendEmail(string toAddress, string subject, string body)
        {
            string fromAddress = "juandla78966@gmail.com";
            string password = "irfxidytuwxdllxp";

            SmtpClient smtpClient = new SmtpClient("smtp.gmail.com", 587);
            smtpClient.Credentials = new NetworkCredential(fromAddress, password);
            smtpClient.EnableSsl = true;

            MailMessage mailMessage = new MailMessage(fromAddress, toAddress, subject, body);
            mailMessage.IsBodyHtml = true;

            smtpClient.Send(mailMessage);
        }
    }
   
}