using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISvOrder
    {
        Order Add(Order order);

        void CreateOrder(Order order);
    }
}
