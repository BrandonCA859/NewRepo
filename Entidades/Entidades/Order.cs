using System;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

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
    }
}

//Lo de email :)