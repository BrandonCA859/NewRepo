using System;
using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Services;

namespace DataAccess.Entidades
{
    public class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public List<Products> Products { get; set; }
        public List<OrderItem> Items { get; set; }
        public double TotalPrice { get; set; }
        public int PaymentConfirmationId { get; set; }

        public PaymentConfirmation PaymentConfirmation { get; set; }
        public DateTime DateOfPurchase { get; set; }

        public void SendConfirmationEmail()
        {
            // Crear una instancia de EmailService (o inyectarla desde una clase superior si estás utilizando inyección de dependencias)
            EmailService emailService = new EmailService();

            // Construir el cuerpo del correo
            string toAddress = "destinatario@ejemplo.com";
            string subject = "Confirmación de compra";
            string body = $"¡Hola! Tu compra con el ID {Id} ha sido confirmada.";

            // Enviar el correo electrónico
            emailService.SendEmail(toAddress, subject, body);
        }
    }
}

//Lo de email :)