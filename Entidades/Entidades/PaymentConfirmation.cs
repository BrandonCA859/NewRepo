using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Entidades
{
    public class PaymentConfirmation
    {
        public string PaymentMethod { get; set; }
        public double AmountPaid { get; set; }
        public DateTime PaymentDate { get; set; }

    }
}
