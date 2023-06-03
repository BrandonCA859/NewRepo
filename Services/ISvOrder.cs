using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal interface ISvOrder
    {

    public Order add (Order order);
    public Order delate (Order order);
    public Order Update (Order order);

    }
}
