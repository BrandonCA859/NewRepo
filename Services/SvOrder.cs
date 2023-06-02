using DataAccess;
using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    internal class SvOrder : ISvOrder

    {

        private readonly MyDbContext _myDbContext;

        public SvOrder(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public Order add(Order order)
        {
            _myDbContext.Add(order);
            _myDbContext.SaveChanges();

            return order;
        }
    }
}
