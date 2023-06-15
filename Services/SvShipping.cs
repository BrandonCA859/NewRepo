using DataAccess;
using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvShipping : ISvShipping
    {
        private readonly MyDbContext _myDbContext;
        
        public SvShipping(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }

        public Shipping Add(Shipping shipping)
        {
            _myDbContext.Shippings.Add(shipping);
            _myDbContext.SaveChanges();

            return shipping;
        }

        public List<Shipping> ListShippings()
        {
            return _myDbContext.Shippings.ToList();
        }
    }
}
