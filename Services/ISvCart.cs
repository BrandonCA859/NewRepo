using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISvCart
    {
        public Cart Add(Cart cart);
        IEnumerable<Cart> GetAll();
    }
}
