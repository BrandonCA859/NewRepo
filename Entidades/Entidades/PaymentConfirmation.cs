using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entidades
{
    public class PaymentConfirmation
    {
        public string? PaymentMethod { get; set; }
        public double? AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }

        [Key]
        public int PaymentConfirmationId { get; set; }
        public int? OrderId { get; set; }
        public Order? Order { get; set; }
    }
}
