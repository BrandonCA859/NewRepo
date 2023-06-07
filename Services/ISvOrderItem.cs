using DataAccess.Entidades;
using Stripe;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISvOrderItem
    {
        public OrderItem add(OrderItem orderitem);

    }
}
