using DataAccess.Entidades;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvPaymentConfirmation : ISvPaymentConfirmation

    {
        private readonly MyDbContext _myDbContext;

        public SvPaymentConfirmation(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public PaymentConfirmation add(PaymentConfirmation paymentConfirmation)
        {
            _myDbContext.PaymentConfirmations.Add(paymentConfirmation);
            _myDbContext.SaveChanges();

            return paymentConfirmation;

        }
    }
}