using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISvPaymentConfirmation
    {

        public PaymentConfirmation add(PaymentConfirmation paymentConfirmation);


    }
}
