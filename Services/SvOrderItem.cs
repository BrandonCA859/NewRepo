using DataAccess.Entidades;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvOrderItem : ISvOrderItem
    {


        private readonly MyDbContext _myDbContext;

        public SvOrderItem (MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public OrderItem add(OrderItem orderItem)
        {
            _myDbContext.OrderItems.Add(orderItem);
            _myDbContext.SaveChanges();

            return orderItem;
        }




    }
}
