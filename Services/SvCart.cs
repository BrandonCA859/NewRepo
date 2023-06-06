using DataAccess.Entidades;
using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SvCart : ISvCart
    {
        private readonly MyDbContext _myDbContext;

        public SvCart(MyDbContext myDbContext)
        {
            _myDbContext = myDbContext;
        }
        public Cart Add(Cart cart)
        {
            _myDbContext.Categorys.Add(cart);
            _myDbContext.SaveChanges();

            return cart;
        }

        public IEnumerable<Cart> GetAll()
        {
            return _myDbContext.Categorys.ToList();
        }
    }
}