using DataAccess.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public interface ISvProduct
    {
        public Product Add(Product products);

        public List<Product> ListProducts();

        public Product Update(Product products, int id);
        public void Delete(int id);
        IEnumerable<Product> GetAll();
        Product GetById(int id);
    }
}