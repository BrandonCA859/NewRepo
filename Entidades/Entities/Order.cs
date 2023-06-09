using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using Services;

namespace DataAccess.Entidades
{
    public class Order
    {
        public int? Id { get; set; }
        public int? UserId { get; set; }
        public List<OrderItem>? Products { get; set; }
        public double TotalPrice { get; set; }
        public string? Address { get; set; }
        public DateTime DateOfPurchase { get; set; }

    }
}